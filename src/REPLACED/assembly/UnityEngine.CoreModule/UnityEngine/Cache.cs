// Decompiled with JetBrains decompiler
// Type: UnityEngine.Cache
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Cache
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_handle_Internal_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_valid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_path_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cache_GetPath_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public int m_Handle;
  private static readonly Cache.Cache_IsReadyDelegate Cache_IsReadyDelegateField;
  private static readonly Cache.Cache_IsReadonlyDelegate Cache_IsReadonlyDelegateField;
  private static readonly Cache.Cache_GetIndexDelegate Cache_GetIndexDelegateField;
  private static readonly Cache.Cache_GetSpaceFreeDelegate Cache_GetSpaceFreeDelegateField;
  private static readonly Cache.Cache_GetMaximumDiskSpaceAvailableDelegate Cache_GetMaximumDiskSpaceAvailableDelegateField;
  private static readonly Cache.Cache_GetCachingDiskSpaceUsedDelegate Cache_GetCachingDiskSpaceUsedDelegateField;
  private static readonly Cache.Cache_GetExpirationDelayDelegate Cache_GetExpirationDelayDelegateField;
  private static readonly Cache.Cache_ClearCacheDelegate Cache_ClearCacheDelegateField;
  private static readonly Cache.Cache_ClearCache_ExpirationDelegate Cache_ClearCache_ExpirationDelegateField;

  static Cache()
  {
    Il2CppClassPointerStore<Cache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Cache));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cache>.NativeClassPtr);
    Cache.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cache>.NativeClassPtr, nameof (m_Handle));
    Cache.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663908);
    Cache.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663909);
    Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663910);
    Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663911);
    Cache.NativeMethodInfoPtr_get_valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663912);
    Cache.NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663913);
    Cache.NativeMethodInfoPtr_get_path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663914);
    Cache.NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663915);
    Cache.NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663916);
    Cache.NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663917);
    Cache.NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663918);
    Cache.NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663919);
    Cache.NativeMethodInfoPtr_Cache_GetPath_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cache>.NativeClassPtr, 100663920 /*0x06000270*/);
    Cache.Cache_IsReadyDelegateField = IL2CPP.ResolveICall<Cache.Cache_IsReadyDelegate>("UnityEngine.Cache::Cache_IsReady");
    Cache.Cache_IsReadonlyDelegateField = IL2CPP.ResolveICall<Cache.Cache_IsReadonlyDelegate>("UnityEngine.Cache::Cache_IsReadonly");
    Cache.Cache_GetIndexDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetIndexDelegate>("UnityEngine.Cache::Cache_GetIndex");
    Cache.Cache_GetSpaceFreeDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetSpaceFreeDelegate>("UnityEngine.Cache::Cache_GetSpaceFree");
    Cache.Cache_GetMaximumDiskSpaceAvailableDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetMaximumDiskSpaceAvailableDelegate>("UnityEngine.Cache::Cache_GetMaximumDiskSpaceAvailable");
    Cache.Cache_GetCachingDiskSpaceUsedDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetCachingDiskSpaceUsedDelegate>("UnityEngine.Cache::Cache_GetCachingDiskSpaceUsed");
    Cache.Cache_GetExpirationDelayDelegateField = IL2CPP.ResolveICall<Cache.Cache_GetExpirationDelayDelegate>("UnityEngine.Cache::Cache_GetExpirationDelay");
    Cache.Cache_ClearCacheDelegateField = IL2CPP.ResolveICall<Cache.Cache_ClearCacheDelegate>("UnityEngine.Cache::Cache_ClearCache");
    Cache.Cache_ClearCache_ExpirationDelegateField = IL2CPP.ResolveICall<Cache.Cache_ClearCache_ExpirationDelegate>("UnityEngine.Cache::Cache_ClearCache_Expiration");
  }

  public unsafe int handle
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_handle_Internal_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(239)]
  [CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417508, XrefRangeEnd = 417511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Cache other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Cache_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool valid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417513, RefRangeEnd = 417515, XrefRangeStart = 417511, XrefRangeEnd = 417513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_valid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417515, XrefRangeEnd = 417517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Cache_IsValid(int handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_IsValid_Internal_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe string path
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 417518, RefRangeEnd = 417521, XrefRangeStart = 417517, XrefRangeEnd = 417518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_get_path_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417526, RefRangeEnd = 417527, XrefRangeStart = 417521, XrefRangeEnd = 417526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string Cache_GetPath(int handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_GetPath_Internal_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe long maximumAvailableStorageSpace
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417529, RefRangeEnd = 417531, XrefRangeStart = 417527, XrefRangeEnd = 417529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_set_maximumAvailableStorageSpace_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Cache.Cache_GetMaximumDiskSpaceAvailable(this.m_Handle);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417531, XrefRangeEnd = 417533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Cache_SetMaximumDiskSpaceAvailable(int handle, long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_SetMaximumDiskSpaceAvailable_Internal_Static_Void_Int32_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int expirationDelay
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417535, RefRangeEnd = 417537, XrefRangeStart = 417533, XrefRangeEnd = 417535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_set_expirationDelay_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Cache.Cache_GetExpirationDelay(this.m_Handle);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417537, XrefRangeEnd = 417539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Cache_SetExpirationDelay(int handle, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_SetExpirationDelay_Internal_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417539, XrefRangeEnd = 417541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Cache_GetPath_Injected(int handle, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cache.NativeMethodInfoPtr_Cache_GetPath_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Cache>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(Cache lhs, Cache rhs) => lhs.handle == rhs.handle;

  public static bool operator !=(Cache lhs, Cache rhs) => lhs.handle != rhs.handle;

  public bool ready => Cache.Cache_IsReady(this.m_Handle);

  public static bool Cache_IsReady(int handle) => Cache.Cache_IsReadyDelegateField(handle);

  public bool readOnly => Cache.Cache_IsReadonly(this.m_Handle);

  public static bool Cache_IsReadonly(int handle) => Cache.Cache_IsReadonlyDelegateField(handle);

  public int index => Cache.Cache_GetIndex(this.m_Handle);

  public static int Cache_GetIndex(int handle) => Cache.Cache_GetIndexDelegateField(handle);

  public long spaceFree => Cache.Cache_GetSpaceFree(this.m_Handle);

  public static long Cache_GetSpaceFree(int handle)
  {
    return Cache.Cache_GetSpaceFreeDelegateField(handle);
  }

  public static long Cache_GetMaximumDiskSpaceAvailable(int handle)
  {
    return Cache.Cache_GetMaximumDiskSpaceAvailableDelegateField(handle);
  }

  public long spaceOccupied => Cache.Cache_GetCachingDiskSpaceUsed(this.m_Handle);

  public static long Cache_GetCachingDiskSpaceUsed(int handle)
  {
    return Cache.Cache_GetCachingDiskSpaceUsedDelegateField(handle);
  }

  public static int Cache_GetExpirationDelay(int handle)
  {
    return Cache.Cache_GetExpirationDelayDelegateField(handle);
  }

  public bool ClearCache() => Cache.Cache_ClearCache(this.m_Handle);

  public static bool Cache_ClearCache(int handle) => Cache.Cache_ClearCacheDelegateField(handle);

  public bool ClearCache(int expiration)
  {
    return Cache.Cache_ClearCache_Expiration(this.m_Handle, expiration);
  }

  public static bool Cache_ClearCache_Expiration(int handle, int expiration)
  {
    return Cache.Cache_ClearCache_ExpirationDelegateField(handle, expiration);
  }

  private delegate bool Cache_IsReadyDelegate(int handle);

  private delegate bool Cache_IsReadonlyDelegate(int handle);

  private delegate int Cache_GetIndexDelegate(int handle);

  private delegate long Cache_GetSpaceFreeDelegate(int handle);

  private delegate long Cache_GetMaximumDiskSpaceAvailableDelegate(int handle);

  private delegate long Cache_GetCachingDiskSpaceUsedDelegate(int handle);

  private delegate int Cache_GetExpirationDelayDelegate(int handle);

  private delegate bool Cache_ClearCacheDelegate(int handle);

  private delegate bool Cache_ClearCache_ExpirationDelegate(int handle, int expiration);
}
