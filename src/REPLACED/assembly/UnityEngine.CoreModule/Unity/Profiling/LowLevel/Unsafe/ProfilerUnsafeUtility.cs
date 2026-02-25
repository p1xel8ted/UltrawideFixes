// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Profiling.LowLevel.Unsafe;

public static class ProfilerUnsafeUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0;
  public const ushort CategoryRender = 0;
  public const ushort CategoryScripts = 1;
  public const ushort CategoryGUI = 4;
  public const ushort CategoryPhysics = 5;
  public const ushort CategoryAnimation = 6;
  public const ushort CategoryAi = 7;
  public const ushort CategoryAudio = 8;
  public const ushort CategoryVideo = 11;
  public const ushort CategoryParticles = 12;
  public const ushort CategoryLighting = 13;
  public const ushort CategoryLightning = 13;
  public const ushort CategoryNetwork = 14;
  public const ushort CategoryLoading = 15;
  public const ushort CategoryOther = 16 /*0x10*/;
  public const ushort CategoryVr = 22;
  public const ushort CategoryAllocation = 23;
  public const ushort CategoryInternal = 24;
  public const ushort CategoryFileIO = 25;
  public const ushort CategoryInput = 30;
  public const ushort CategoryVirtualTexturing = 31 /*0x1F*/;
  public const ushort CategoryGPU = 32 /*0x20*/;
  public const ushort CategoryPhysics2D = 33;
  public const ushort CategoryAny = 65535 /*0xFFFF*/;
  private static readonly ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate CreateCategory_UnsafeDelegateField;
  private static readonly ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate GetCategoryByName_UnsafeDelegateField;
  private static readonly ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate CreateMarker_UnsafeDelegateField;
  private static readonly ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate SetMarkerMetadata_UnsafeDelegateField;
  private static readonly ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate BeginSampleWithMetadataDelegateField;
  private static readonly ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate SingleSampleWithMetadataDelegateField;
  private static readonly ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate CreateCounterValue_UnsafeDelegateField;
  private static readonly ProfilerUnsafeUtility.FlushCounterValueDelegate FlushCounterValueDelegateField;
  private static readonly ProfilerUnsafeUtility.CreateFlowDelegate CreateFlowDelegateField;
  private static readonly ProfilerUnsafeUtility.FlowEventDelegate FlowEventDelegateField;
  private static readonly ProfilerUnsafeUtility.get_TimestampDelegate get_TimestampDelegateField;
  private static readonly ProfilerUnsafeUtility.CreateCategory_InjectedDelegate CreateCategory_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate GetCategoryColor_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.GetMarker_InjectedDelegate GetMarker_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.SetMarkerMetadata_InjectedDelegate SetMarkerMetadata_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.CreateCounterValue_InjectedDelegate CreateCounterValue_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.Internal_BeginWithObject_InjectedDelegate Internal_BeginWithObject_InjectedDelegateField;
  private static readonly ProfilerUnsafeUtility.Internal_GetName_InjectedDelegate Internal_GetName_InjectedDelegateField;

  static ProfilerUnsafeUtility()
  {
    Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", nameof (ProfilerUnsafeUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663426 /*0x06000082*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663427 /*0x06000083*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663428 /*0x06000084*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663429 /*0x06000085*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663430 /*0x06000086*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663431 /*0x06000087*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663432 /*0x06000088*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663433 /*0x06000089*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663434 /*0x0600008A*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663435 /*0x0600008B*/);
    ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerUnsafeUtility>.NativeClassPtr, 100663436 /*0x0600008C*/);
    ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategory_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Unsafe");
    ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryByName_Unsafe");
    ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateMarker_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateMarker_Unsafe");
    ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Unsafe");
    ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.BeginSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::BeginSampleWithMetadata");
    ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SingleSampleWithMetadataDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SingleSampleWithMetadata");
    ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Unsafe");
    ProfilerUnsafeUtility.FlushCounterValueDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlushCounterValueDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlushCounterValue");
    ProfilerUnsafeUtility.CreateFlowDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateFlowDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateFlow");
    ProfilerUnsafeUtility.FlowEventDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.FlowEventDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::FlowEvent");
    ProfilerUnsafeUtility.get_TimestampDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.get_TimestampDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::get_Timestamp");
    ProfilerUnsafeUtility.CreateCategory_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCategory_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCategory_Injected");
    ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetCategoryColor_Injected");
    ProfilerUnsafeUtility.GetMarker_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.GetMarker_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::GetMarker_Injected");
    ProfilerUnsafeUtility.SetMarkerMetadata_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.SetMarkerMetadata_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::SetMarkerMetadata_Injected");
    ProfilerUnsafeUtility.CreateCounterValue_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.CreateCounterValue_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::CreateCounterValue_Injected");
    ProfilerUnsafeUtility.Internal_BeginWithObject_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_BeginWithObject_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_BeginWithObject_Injected");
    ProfilerUnsafeUtility.Internal_GetName_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerUnsafeUtility.Internal_GetName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerUnsafeUtility::Internal_GetName_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413781, XrefRangeEnd = 413783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ushort CreateCategory__Unmanaged(
    byte* name,
    int nameLen,
    ProfilerCategoryColor colorIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCategory__Unmanaged_Internal_Static_UInt16_ptr_Byte_Int32_ProfilerCategoryColor_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413783, XrefRangeEnd = 413785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerCategoryDescription GetCategoryDescription(ushort categoryId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &categoryId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Public_Static_ProfilerCategoryDescription_UInt16_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerCategoryDescription*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 413799, RefRangeEnd = 413828, XrefRangeStart = 413785, XrefRangeEnd = 413799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateMarker(
    string name,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Public_Static_IntPtr_String_UInt16_MarkerFlags_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413828, XrefRangeEnd = 413830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateMarker__Unmanaged(
    byte* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker__Unmanaged_Internal_Static_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413830, XrefRangeEnd = 413832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetMarkerMetadata__Unmanaged(
    System.IntPtr markerPtr,
    int index,
    byte* name,
    int nameLen,
    byte type,
    byte unit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &markerPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &unit;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_SetMarkerMetadata__Unmanaged_Internal_Static_Void_IntPtr_Int32_ptr_Byte_Int32_Byte_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(34)]
  [CachedScanResults(RefRangeStart = 413834, RefRangeEnd = 413868, XrefRangeStart = 413832, XrefRangeEnd = 413834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void BeginSample(System.IntPtr markerPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &markerPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_BeginSample_Public_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(93)]
  [CachedScanResults(RefRangeStart = 413870, RefRangeEnd = 413963, XrefRangeStart = 413868, XrefRangeEnd = 413870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EndSample(System.IntPtr markerPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &markerPtr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_EndSample_Public_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413963, XrefRangeEnd = 413965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* CreateCounterValue__Unmanaged(
    out System.IntPtr counterPtr,
    byte* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[9];
    numPtr[0] = (System.IntPtr) ref counterPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &dataType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &dataUnit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &dataSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &counterOptions;
    System.IntPtr num;
    System.IntPtr counterValueUnmanaged = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateCounterValue__Unmanaged_Internal_Static_ptr_Void_byref_IntPtr_ptr_Byte_Int32_UInt16_MarkerFlags_Byte_Byte_Int32_ProfilerCounterOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) counterValueUnmanaged;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413965, XrefRangeEnd = 413974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Utf8ToString(byte* chars, int charsLen)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) chars;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &charsLen;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_Utf8ToString_Internal_Static_String_ptr_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413974, XrefRangeEnd = 413976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetCategoryDescription_Injected(
    ushort categoryId,
    out ProfilerCategoryDescription ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &categoryId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_GetCategoryDescription_Injected_Private_Static_Void_UInt16_byref_ProfilerCategoryDescription_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413976, XrefRangeEnd = 413978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateMarker_Injected(
    ref ManagedSpanWrapper name,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &categoryId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &flags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &metadataCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerUnsafeUtility.NativeMethodInfoPtr_CreateMarker_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_UInt16_MarkerFlags_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public ProfilerUnsafeUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ushort CreateCategory(string name, ProfilerCategoryColor colorIndex)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return ProfilerUnsafeUtility.CreateCategory_Injected(ref managedSpanWrapper, colorIndex);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe ushort CreateCategory(
    char* name,
    int nameLen,
    ProfilerCategoryColor colorIndex)
  {
    return ProfilerUnsafeUtility.CreateCategory_Unsafe(name, nameLen, colorIndex);
  }

  public static unsafe ushort CreateCategory_Unsafe(
    char* name,
    int nameLen,
    ProfilerCategoryColor colorIndex)
  {
    return ProfilerUnsafeUtility.CreateCategory_UnsafeDelegateField((System.IntPtr) name, nameLen, colorIndex);
  }

  public static unsafe ushort GetCategoryByName(char* name, int nameLen)
  {
    return ProfilerUnsafeUtility.GetCategoryByName_Unsafe(name, nameLen);
  }

  public static unsafe ushort GetCategoryByName_Unsafe(char* name, int nameLen)
  {
    return ProfilerUnsafeUtility.GetCategoryByName_UnsafeDelegateField((System.IntPtr) name, nameLen);
  }

  public static Color32 GetCategoryColor(ProfilerCategoryColor colorIndex)
  {
    Color32 ret;
    ProfilerUnsafeUtility.GetCategoryColor_Injected(colorIndex, out ret);
    return ret;
  }

  public static unsafe System.IntPtr CreateMarker(
    char* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount)
  {
    return ProfilerUnsafeUtility.CreateMarker_Unsafe(name, nameLen, categoryId, flags, metadataCount);
  }

  public static unsafe System.IntPtr CreateMarker_Unsafe(
    char* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount)
  {
    return ProfilerUnsafeUtility.CreateMarker_UnsafeDelegateField((System.IntPtr) name, nameLen, categoryId, flags, metadataCount);
  }

  public static unsafe System.IntPtr GetMarker(string name)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return ProfilerUnsafeUtility.GetMarker_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void SetMarkerMetadata(
    System.IntPtr markerPtr,
    int index,
    string name,
    byte type,
    byte unit)
  {
    try
    {
      System.IntPtr markerPtr1 = markerPtr;
      int index1 = index;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int type1 = (int) type;
      int unit1 = (int) unit;
      ProfilerUnsafeUtility.SetMarkerMetadata_Injected(markerPtr1, index1, ref local, (byte) type1, (byte) unit1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void SetMarkerMetadata(
    System.IntPtr markerPtr,
    int index,
    char* name,
    int nameLen,
    byte type,
    byte unit)
  {
    ProfilerUnsafeUtility.SetMarkerMetadata_Unsafe(markerPtr, index, name, nameLen, type, unit);
  }

  public static unsafe void SetMarkerMetadata_Unsafe(
    System.IntPtr markerPtr,
    int index,
    char* name,
    int nameLen,
    byte type,
    byte unit)
  {
    ProfilerUnsafeUtility.SetMarkerMetadata_UnsafeDelegateField(markerPtr, index, (System.IntPtr) name, nameLen, type, unit);
  }

  public static unsafe void BeginSampleWithMetadata(
    System.IntPtr markerPtr,
    int metadataCount,
    void* metadata)
  {
    ProfilerUnsafeUtility.BeginSampleWithMetadataDelegateField(markerPtr, metadataCount, (System.IntPtr) metadata);
  }

  public static unsafe void SingleSampleWithMetadata(
    System.IntPtr markerPtr,
    int metadataCount,
    void* metadata)
  {
    ProfilerUnsafeUtility.SingleSampleWithMetadataDelegateField(markerPtr, metadataCount, (System.IntPtr) metadata);
  }

  public static unsafe void* CreateCounterValue(
    out System.IntPtr counterPtr,
    string name,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions)
  {
    try
    {
      ref System.IntPtr local1 = ref counterPtr;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper;
      int categoryId1 = (int) categoryId;
      int flags1 = (int) flags;
      int dataType1 = (int) dataType;
      int dataUnit1 = (int) dataUnit;
      int dataSize1 = dataSize;
      int counterOptions1 = (int) counterOptions;
      return ProfilerUnsafeUtility.CreateCounterValue_Injected(out local1, ref local2, (ushort) categoryId1, (MarkerFlags) flags1, (byte) dataType1, (byte) dataUnit1, dataSize1, (ProfilerCounterOptions) counterOptions1);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void* CreateCounterValue(
    out System.IntPtr counterPtr,
    char* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions)
  {
    return ProfilerUnsafeUtility.CreateCounterValue_Unsafe(out counterPtr, name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
  }

  public static unsafe void* CreateCounterValue_Unsafe(
    out System.IntPtr counterPtr,
    char* name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions)
  {
    return (void*) ProfilerUnsafeUtility.CreateCounterValue_UnsafeDelegateField((System.IntPtr) ref counterPtr, (System.IntPtr) name, nameLen, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
  }

  public static unsafe void FlushCounterValue(void* counterValuePtr)
  {
    ProfilerUnsafeUtility.FlushCounterValueDelegateField((System.IntPtr) counterValuePtr);
  }

  public static uint CreateFlow(ushort categoryId)
  {
    return ProfilerUnsafeUtility.CreateFlowDelegateField(categoryId);
  }

  public static void FlowEvent(uint flowId, ProfilerFlowEventType flowEventType)
  {
    ProfilerUnsafeUtility.FlowEventDelegateField(flowId, flowEventType);
  }

  public static void Internal_BeginWithObject(System.IntPtr markerPtr, UnityEngine.Object contextUnityObject)
  {
    ProfilerUnsafeUtility.Internal_BeginWithObject_Injected(markerPtr, UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(contextUnityObject));
  }

  public static string Internal_GetName(System.IntPtr markerPtr)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      ProfilerUnsafeUtility.Internal_GetName_Injected(markerPtr, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static long Timestamp => ProfilerUnsafeUtility.get_TimestampDelegateField();

  public static ushort CreateCategory_Injected(
    ref ManagedSpanWrapper name,
    ProfilerCategoryColor colorIndex)
  {
    return ProfilerUnsafeUtility.CreateCategory_InjectedDelegateField((System.IntPtr) ref name, colorIndex);
  }

  public static void GetCategoryColor_Injected(ProfilerCategoryColor colorIndex, out Color32 ret)
  {
    ProfilerUnsafeUtility.GetCategoryColor_InjectedDelegateField(colorIndex, (System.IntPtr) ref ret);
  }

  public static System.IntPtr GetMarker_Injected(ref ManagedSpanWrapper name)
  {
    return ProfilerUnsafeUtility.GetMarker_InjectedDelegateField((System.IntPtr) ref name);
  }

  public static void SetMarkerMetadata_Injected(
    System.IntPtr markerPtr,
    int index,
    ref ManagedSpanWrapper name,
    byte type,
    byte unit)
  {
    ProfilerUnsafeUtility.SetMarkerMetadata_InjectedDelegateField(markerPtr, index, (System.IntPtr) ref name, type, unit);
  }

  public static unsafe void* CreateCounterValue_Injected(
    out System.IntPtr counterPtr,
    ref ManagedSpanWrapper name,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions)
  {
    return (void*) ProfilerUnsafeUtility.CreateCounterValue_InjectedDelegateField((System.IntPtr) ref counterPtr, (System.IntPtr) ref name, categoryId, flags, dataType, dataUnit, dataSize, counterOptions);
  }

  public static void Internal_BeginWithObject_Injected(System.IntPtr markerPtr, System.IntPtr contextUnityObject)
  {
    ProfilerUnsafeUtility.Internal_BeginWithObject_InjectedDelegateField(markerPtr, contextUnityObject);
  }

  public static void Internal_GetName_Injected(System.IntPtr markerPtr, out ManagedSpanWrapper ret)
  {
    ProfilerUnsafeUtility.Internal_GetName_InjectedDelegateField(markerPtr, (System.IntPtr) ref ret);
  }

  private delegate ushort CreateCategory_UnsafeDelegate(
    System.IntPtr name,
    int nameLen,
    ProfilerCategoryColor colorIndex);

  private delegate ushort GetCategoryByName_UnsafeDelegate(System.IntPtr name, int nameLen);

  private delegate System.IntPtr CreateMarker_UnsafeDelegate(
    System.IntPtr name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    int metadataCount);

  private delegate void SetMarkerMetadata_UnsafeDelegate(
    System.IntPtr markerPtr,
    int index,
    System.IntPtr name,
    int nameLen,
    byte type,
    byte unit);

  private delegate void BeginSampleWithMetadataDelegate(
    System.IntPtr markerPtr,
    int metadataCount,
    System.IntPtr metadata);

  private delegate void SingleSampleWithMetadataDelegate(
    System.IntPtr markerPtr,
    int metadataCount,
    System.IntPtr metadata);

  private delegate System.IntPtr CreateCounterValue_UnsafeDelegate(
    [Out] System.IntPtr counterPtr,
    System.IntPtr name,
    int nameLen,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions);

  private delegate void FlushCounterValueDelegate(System.IntPtr counterValuePtr);

  private delegate uint CreateFlowDelegate(ushort categoryId);

  private delegate void FlowEventDelegate(uint flowId, ProfilerFlowEventType flowEventType);

  private delegate long get_TimestampDelegate();

  private delegate ushort CreateCategory_InjectedDelegate(
    System.IntPtr name,
    ProfilerCategoryColor colorIndex);

  private delegate void GetCategoryColor_InjectedDelegate(
    ProfilerCategoryColor colorIndex,
    [Out] System.IntPtr ret);

  private delegate System.IntPtr GetMarker_InjectedDelegate(System.IntPtr name);

  private delegate void SetMarkerMetadata_InjectedDelegate(
    System.IntPtr markerPtr,
    int index,
    System.IntPtr name,
    byte type,
    byte unit);

  private delegate System.IntPtr CreateCounterValue_InjectedDelegate(
    [Out] System.IntPtr counterPtr,
    System.IntPtr name,
    ushort categoryId,
    MarkerFlags flags,
    byte dataType,
    byte dataUnit,
    int dataSize,
    ProfilerCounterOptions counterOptions);

  private delegate void Internal_BeginWithObject_InjectedDelegate(
    System.IntPtr markerPtr,
    System.IntPtr contextUnityObject);

  private delegate void Internal_GetName_InjectedDelegate(System.IntPtr markerPtr, [Out] System.IntPtr ret);
}
