// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handle;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0;
  [FieldOffset(0)]
  public readonly ulong handle;
  public const ulong k_InvalidHandle = 18446744073709551615 /*0xFFFFFFFFFFFFFFFF*/;
  private static readonly ProfilerRecorderHandle.GetAvailable_InjectedDelegate GetAvailable_InjectedDelegateField;
  private static readonly ProfilerRecorderHandle.GetByName_InjectedDelegate GetByName_InjectedDelegateField;
  private static readonly ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate GetByName_Unsafe_InjectedDelegateField;

  static ProfilerRecorderHandle()
  {
    Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", nameof (ProfilerRecorderHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr);
    ProfilerRecorderHandle.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, nameof (handle));
    ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663419 /*0x0600007B*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663420 /*0x0600007C*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663421 /*0x0600007D*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663422 /*0x0600007E*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663423 /*0x0600007F*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663424 /*0x06000080*/);
    ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, 100663425 /*0x06000081*/);
    ProfilerRecorderHandle.GetAvailable_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetAvailable_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetAvailable_Injected");
    ProfilerRecorderHandle.GetByName_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Injected");
    ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegate>("Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderHandle::GetByName_Unsafe_Injected");
  }

  [CallerCount(65)]
  [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerRecorderHandle(ulong handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool Valid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 413767, RefRangeEnd = 413769, XrefRangeStart = 413767, XrefRangeEnd = 413767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 413771, RefRangeEnd = 413773, XrefRangeStart = 413769, XrefRangeEnd = 413771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerRecorderDescription GetDescription(ProfilerRecorderHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescription_Public_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorderDescription*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413773, XrefRangeEnd = 413775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerRecorderHandle GetByName__Unmanaged(
    ProfilerCategory category,
    byte* name,
    int nameLen)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &category;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Internal_Static_ProfilerRecorderHandle_ProfilerCategory_ptr_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorderHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413775, XrefRangeEnd = 413777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerRecorderDescription GetDescriptionInternal(
    ProfilerRecorderHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Private_Static_ProfilerRecorderDescription_ProfilerRecorderHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorderDescription*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413777, XrefRangeEnd = 413779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetByName__Unmanaged_Injected(
    [In] ref ProfilerCategory category,
    byte* name,
    int nameLen,
    out ProfilerRecorderHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref category;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nameLen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetByName__Unmanaged_Injected_Private_Static_Void_byref_ProfilerCategory_ptr_Byte_Int32_byref_ProfilerRecorderHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413779, XrefRangeEnd = 413781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetDescriptionInternal_Injected(
    [In] ref ProfilerRecorderHandle handle,
    out ProfilerRecorderDescription ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderHandle.NativeMethodInfoPtr_GetDescriptionInternal_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_byref_ProfilerRecorderDescription_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static ProfilerRecorderHandle Get(ProfilerMarker marker)
  {
    return new ProfilerRecorderHandle((ulong) marker.Handle.ToInt64());
  }

  public static ProfilerRecorderHandle Get(ProfilerCategory category, string statName)
  {
    return !Il2CppSystem.String.IsNullOrEmpty(statName) ? ProfilerRecorderHandle.GetByName(category, statName) : throw new Il2CppSystem.ArgumentException("String must be not null or empty", nameof (statName));
  }

  public static void GetAvailable(List<ProfilerRecorderHandle> outRecorderHandleList)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe ProfilerRecorderHandle GetByName(ProfilerCategory category, string name)
  {
    ProfilerRecorderHandle profilerRecorderHandle;
    ProfilerRecorderHandle byName;
    try
    {
      ref ProfilerCategory local1 = ref category;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper;
      ref ProfilerRecorderHandle local3 = ref profilerRecorderHandle;
      ProfilerRecorderHandle.GetByName_Injected(ref local1, ref local2, out local3);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      byName = profilerRecorderHandle;
    }
    return byName;
  }

  public static unsafe ProfilerRecorderHandle GetByName(
    ProfilerCategory category,
    char* name,
    int nameLen)
  {
    return ProfilerRecorderHandle.GetByName_Unsafe(category, name, nameLen);
  }

  public static unsafe ProfilerRecorderHandle GetByName_Unsafe(
    ProfilerCategory category,
    char* name,
    int nameLen)
  {
    ProfilerRecorderHandle ret;
    ProfilerRecorderHandle.GetByName_Unsafe_Injected(ref category, name, nameLen, out ret);
    return ret;
  }

  public static void GetAvailable_Injected(ref BlittableListWrapper outRecorderHandleList)
  {
    ProfilerRecorderHandle.GetAvailable_InjectedDelegateField((System.IntPtr) ref outRecorderHandleList);
  }

  public static void GetByName_Injected(
    [In] ref ProfilerCategory category,
    ref ManagedSpanWrapper name,
    out ProfilerRecorderHandle ret)
  {
    ProfilerRecorderHandle.GetByName_InjectedDelegateField((System.IntPtr) ref category, (System.IntPtr) ref name, (System.IntPtr) ref ret);
  }

  public static unsafe void GetByName_Unsafe_Injected(
    [In] ref ProfilerCategory category,
    char* name,
    int nameLen,
    out ProfilerRecorderHandle ret)
  {
    ProfilerRecorderHandle.GetByName_Unsafe_InjectedDelegateField((System.IntPtr) ref category, (System.IntPtr) name, nameLen, (System.IntPtr) ref ret);
  }

  private delegate void GetAvailable_InjectedDelegate(System.IntPtr outRecorderHandleList);

  private delegate void GetByName_InjectedDelegate([In] System.IntPtr category, System.IntPtr name, [Out] System.IntPtr ret);

  private delegate void GetByName_Unsafe_InjectedDelegate(
    [In] System.IntPtr category,
    System.IntPtr name,
    int nameLen,
    [Out] System.IntPtr ret);
}
