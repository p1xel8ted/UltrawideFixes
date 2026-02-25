// Decompiled with JetBrains decompiler
// Type: UnityEngine.Caching
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Caching(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_byref_ManagedSpanWrapper_Boolean_byref_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0;
  private static readonly Caching.get_compressionEnabledDelegate get_compressionEnabledDelegateField;
  private static readonly Caching.ClearCacheDelegate ClearCacheDelegateField;
  private static readonly Caching.ClearCache_IntDelegate ClearCache_IntDelegateField;
  private static readonly Caching.get_spaceOccupiedDelegate get_spaceOccupiedDelegateField;
  private static readonly Caching.get_spaceFreeDelegate get_spaceFreeDelegateField;
  private static readonly Caching.get_maximumAvailableDiskSpaceDelegate get_maximumAvailableDiskSpaceDelegateField;
  private static readonly Caching.set_maximumAvailableDiskSpaceDelegate set_maximumAvailableDiskSpaceDelegateField;
  private static readonly Caching.get_expirationDelayDelegate get_expirationDelayDelegateField;
  private static readonly Caching.set_expirationDelayDelegate set_expirationDelayDelegateField;
  private static readonly Caching.get_cacheCountDelegate get_cacheCountDelegateField;
  private static readonly Caching.GetCachedVersions_InjectedDelegate GetCachedVersions_InjectedDelegateField;
  private static readonly Caching.MarkAsUsed_InjectedDelegate MarkAsUsed_InjectedDelegateField;
  private static readonly Caching.GetCacheAt_InjectedDelegate GetCacheAt_InjectedDelegateField;
  private static readonly Caching.RemoveCache_InjectedDelegate RemoveCache_InjectedDelegateField;
  private static readonly Caching.MoveCacheBefore_InjectedDelegate MoveCacheBefore_InjectedDelegateField;
  private static readonly Caching.MoveCacheAfter_InjectedDelegate MoveCacheAfter_InjectedDelegateField;

  static Caching()
  {
    Il2CppClassPointerStore<Caching>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Caching));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Caching>.NativeClassPtr);
    Caching.NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663921);
    Caching.NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663922);
    Caching.NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663923);
    Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663924);
    Caching.NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663925);
    Caching.NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663926);
    Caching.NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663927);
    Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663928);
    Caching.NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663929);
    Caching.NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663930);
    Caching.NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663931);
    Caching.NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663932);
    Caching.NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663933);
    Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663934);
    Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663935);
    Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663936 /*0x06000280*/);
    Caching.NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663937);
    Caching.NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663938);
    Caching.NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_byref_ManagedSpanWrapper_Boolean_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663939);
    Caching.NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663940);
    Caching.NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663941);
    Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663942);
    Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Caching>.NativeClassPtr, 100663943);
    Caching.get_compressionEnabledDelegateField = IL2CPP.ResolveICall<Caching.get_compressionEnabledDelegate>("UnityEngine.Caching::get_compressionEnabled");
    Caching.ClearCacheDelegateField = IL2CPP.ResolveICall<Caching.ClearCacheDelegate>("UnityEngine.Caching::ClearCache");
    Caching.ClearCache_IntDelegateField = IL2CPP.ResolveICall<Caching.ClearCache_IntDelegate>("UnityEngine.Caching::ClearCache_Int");
    Caching.get_spaceOccupiedDelegateField = IL2CPP.ResolveICall<Caching.get_spaceOccupiedDelegate>("UnityEngine.Caching::get_spaceOccupied");
    Caching.get_spaceFreeDelegateField = IL2CPP.ResolveICall<Caching.get_spaceFreeDelegate>("UnityEngine.Caching::get_spaceFree");
    Caching.get_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.get_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::get_maximumAvailableDiskSpace");
    Caching.set_maximumAvailableDiskSpaceDelegateField = IL2CPP.ResolveICall<Caching.set_maximumAvailableDiskSpaceDelegate>("UnityEngine.Caching::set_maximumAvailableDiskSpace");
    Caching.get_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.get_expirationDelayDelegate>("UnityEngine.Caching::get_expirationDelay");
    Caching.set_expirationDelayDelegateField = IL2CPP.ResolveICall<Caching.set_expirationDelayDelegate>("UnityEngine.Caching::set_expirationDelay");
    Caching.get_cacheCountDelegateField = IL2CPP.ResolveICall<Caching.get_cacheCountDelegate>("UnityEngine.Caching::get_cacheCount");
    Caching.GetCachedVersions_InjectedDelegateField = IL2CPP.ResolveICall<Caching.GetCachedVersions_InjectedDelegate>("UnityEngine.Caching::GetCachedVersions_Injected");
    Caching.MarkAsUsed_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MarkAsUsed_InjectedDelegate>("UnityEngine.Caching::MarkAsUsed_Injected");
    Caching.GetCacheAt_InjectedDelegateField = IL2CPP.ResolveICall<Caching.GetCacheAt_InjectedDelegate>("UnityEngine.Caching::GetCacheAt_Injected");
    Caching.RemoveCache_InjectedDelegateField = IL2CPP.ResolveICall<Caching.RemoveCache_InjectedDelegate>("UnityEngine.Caching::RemoveCache_Injected");
    Caching.MoveCacheBefore_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MoveCacheBefore_InjectedDelegate>("UnityEngine.Caching::MoveCacheBefore_Injected");
    Caching.MoveCacheAfter_InjectedDelegateField = IL2CPP.ResolveICall<Caching.MoveCacheAfter_InjectedDelegate>("UnityEngine.Caching::MoveCacheAfter_Injected");
  }

  public static unsafe bool compressionEnabled
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417543, RefRangeEnd = 417545, XrefRangeStart = 417541, XrefRangeEnd = 417543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_compressionEnabled_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Caching.get_compressionEnabledDelegateField();
  }

  public static unsafe bool ready
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417547, RefRangeEnd = 417549, XrefRangeStart = 417545, XrefRangeEnd = 417547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_ready_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417551, RefRangeEnd = 417552, XrefRangeStart = 417549, XrefRangeEnd = 417551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearCachedVersion(string assetBundleName, Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersion_Public_Static_Boolean_String_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417566, RefRangeEnd = 417567, XrefRangeStart = 417552, XrefRangeEnd = 417566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearCachedVersionInternal(string assetBundleName, Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Internal_Static_Boolean_String_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417569, RefRangeEnd = 417571, XrefRangeStart = 417567, XrefRangeEnd = 417569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearOtherCachedVersions(string assetBundleName, Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearOtherCachedVersions_Public_Static_Boolean_String_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417573, RefRangeEnd = 417575, XrefRangeStart = 417571, XrefRangeEnd = 417573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearAllCachedVersions(string assetBundleName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(assetBundleName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearAllCachedVersions_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417589, RefRangeEnd = 417591, XrefRangeStart = 417575, XrefRangeEnd = 417589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearCachedVersions(
    string assetBundleName,
    Hash128 hash,
    bool keepInputVersion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &keepInputVersion;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersions_Internal_Static_Boolean_String_Hash128_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417595, RefRangeEnd = 417597, XrefRangeStart = 417591, XrefRangeEnd = 417595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsVersionCached(CachedAssetBundle cachedBundle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cachedBundle))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Public_Static_Boolean_CachedAssetBundle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417620, RefRangeEnd = 417621, XrefRangeStart = 417597, XrefRangeEnd = 417620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsVersionCached(string url, string assetBundleName, Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(url);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(assetBundleName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Internal_Static_Boolean_String_String_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 417658, RefRangeEnd = 417660, XrefRangeStart = 417621, XrefRangeEnd = 417658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Cache AddCache(string cachePath)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(cachePath)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Public_Static_Cache_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Cache*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 417674, RefRangeEnd = 417675, XrefRangeStart = 417660, XrefRangeEnd = 417674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Cache AddCache(string cachePath, bool isReadonly)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(cachePath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isReadonly;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Internal_Static_Cache_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Cache*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 417689, RefRangeEnd = 417692, XrefRangeStart = 417675, XrefRangeEnd = 417689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Cache GetCacheByPath(string cachePath)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(cachePath)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCacheByPath_Public_Static_Cache_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Cache*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Cache defaultCache
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 417694, RefRangeEnd = 417695, XrefRangeStart = 417692, XrefRangeEnd = 417694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_defaultCache_Public_Static_get_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Cache*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Cache currentCacheForWriting
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 417697, RefRangeEnd = 417701, XrefRangeStart = 417695, XrefRangeEnd = 417697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Public_Static_get_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Cache*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 417703, RefRangeEnd = 417705, XrefRangeStart = 417701, XrefRangeEnd = 417703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Public_Static_set_Void_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417705, XrefRangeEnd = 417707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearCachedVersionInternal_Injected(
    ref ManagedSpanWrapper assetBundleName,
    [In] ref Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref assetBundleName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersionInternal_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417707, XrefRangeEnd = 417709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ClearCachedVersions_Injected(
    ref ManagedSpanWrapper assetBundleName,
    [In] ref Hash128 hash,
    bool keepInputVersion)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref assetBundleName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &keepInputVersion;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_ClearCachedVersions_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Hash128_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417709, XrefRangeEnd = 417711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsVersionCached_Injected(
    ref ManagedSpanWrapper url,
    ref ManagedSpanWrapper assetBundleName,
    [In] ref Hash128 hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref url;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref assetBundleName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref hash;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_IsVersionCached_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_byref_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417711, XrefRangeEnd = 417713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AddCache_Injected(
    ref ManagedSpanWrapper cachePath,
    bool isReadonly,
    out Cache ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref cachePath;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isReadonly;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_AddCache_Injected_Private_Static_Void_byref_ManagedSpanWrapper_Boolean_byref_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417713, XrefRangeEnd = 417715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetCacheByPath_Injected(ref ManagedSpanWrapper cachePath, out Cache ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref cachePath;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_GetCacheByPath_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417715, XrefRangeEnd = 417717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_defaultCache_Injected(out Cache ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_defaultCache_Injected_Private_Static_Void_byref_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417717, XrefRangeEnd = 417719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_currentCacheForWriting_Injected(out Cache ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_get_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417719, XrefRangeEnd = 417721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_currentCacheForWriting_Injected([In] ref Cache value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Caching.NativeMethodInfoPtr_set_currentCacheForWriting_Injected_Private_Static_Void_byref_Cache_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static bool ClearCache() => Caching.ClearCacheDelegateField();

  public static bool ClearCache(int expiration) => Caching.ClearCache_Int(expiration);

  public static bool ClearCache_Int(int expiration)
  {
    return Caching.ClearCache_IntDelegateField(expiration);
  }

  public static unsafe Il2CppStructArray<Hash128> GetCachedVersions(string assetBundleName)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Hash128> cachedVersions;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = assetBundleName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Caching.GetCachedVersions_Injected(ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      Il2CppStructArray<Hash128> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Hash128>((Il2CppArrayBase<Hash128>&) ref il2CppStructArray);
      cachedVersions = il2CppStructArray;
    }
    return cachedVersions;
  }

  public static void GetCachedVersions(string assetBundleName, List<Hash128> outCachedVersions)
  {
    if (Il2CppSystem.String.IsNullOrEmpty(assetBundleName))
      throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
    if (outCachedVersions == null)
      throw new Il2CppSystem.ArgumentNullException("Input outCachedVersions cannot be null.");
    outCachedVersions.AddRange((IEnumerable<Hash128>) Caching.GetCachedVersions(assetBundleName));
  }

  public static bool IsVersionCached(string url, int version)
  {
    return Caching.IsVersionCached(url, new Hash128(0U, 0U, 0U, (uint) version));
  }

  public static bool IsVersionCached(string url, Hash128 hash)
  {
    return !Il2CppSystem.String.IsNullOrEmpty(url) ? Caching.IsVersionCached(url, "", hash) : throw new Il2CppSystem.ArgumentException("Input AssetBundle url cannot be null or empty.");
  }

  public static bool MarkAsUsed(string url, int version)
  {
    return Caching.MarkAsUsed(url, new Hash128(0U, 0U, 0U, (uint) version));
  }

  public static bool MarkAsUsed(string url, Hash128 hash)
  {
    return !Il2CppSystem.String.IsNullOrEmpty(url) ? Caching.MarkAsUsed(url, "", hash) : throw new Il2CppSystem.ArgumentException("Input AssetBundle url cannot be null or empty.");
  }

  public static bool MarkAsUsed(CachedAssetBundle cachedBundle)
  {
    if (Il2CppSystem.String.IsNullOrEmpty(((CachedAssetBundle) ref cachedBundle).name))
      throw new Il2CppSystem.ArgumentException("Input AssetBundle name cannot be null or empty.");
    return Caching.MarkAsUsed("", ((CachedAssetBundle) ref cachedBundle).name, ((CachedAssetBundle) ref cachedBundle).hash);
  }

  public static unsafe bool MarkAsUsed(string url, string assetBundleName, Hash128 hash)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(url, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = url.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(assetBundleName, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = assetBundleName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      ref Hash128 local3 = ref hash;
      return Caching.MarkAsUsed_Injected(ref local1, ref local2, ref local3);
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

  public static int GetVersionFromCache(string url) => -1;

  public static int spaceUsed => (int) Caching.spaceOccupied;

  public static long spaceOccupied => Caching.get_spaceOccupiedDelegateField();

  public static int spaceAvailable => (int) Caching.spaceFree;

  public static long spaceFree => Caching.get_spaceFreeDelegateField();

  public static long maximumAvailableDiskSpace
  {
    get => Caching.get_maximumAvailableDiskSpaceDelegateField();
    set => Caching.set_maximumAvailableDiskSpaceDelegateField(value);
  }

  public static int expirationDelay
  {
    get => Caching.get_expirationDelayDelegateField();
    set => Caching.set_expirationDelayDelegateField(value);
  }

  public static Cache GetCacheAt(int cacheIndex)
  {
    Cache ret;
    Caching.GetCacheAt_Injected(cacheIndex, out ret);
    return ret;
  }

  public static void GetAllCachePaths(List<string> cachePaths)
  {
    cachePaths.Clear();
    for (int cacheIndex = 0; cacheIndex < Caching.cacheCount; ++cacheIndex)
    {
      Cache cacheAt = Caching.GetCacheAt(cacheIndex);
      cachePaths.Add(cacheAt.path);
    }
  }

  public static bool RemoveCache(Cache cache) => Caching.RemoveCache_Injected(ref cache);

  public static void MoveCacheBefore(Cache src, Cache dst)
  {
    Caching.MoveCacheBefore_Injected(ref src, ref dst);
  }

  public static void MoveCacheAfter(Cache src, Cache dst)
  {
    Caching.MoveCacheAfter_Injected(ref src, ref dst);
  }

  public static int cacheCount => Caching.get_cacheCountDelegateField();

  public static bool CleanCache() => Caching.ClearCache();

  public static void GetCachedVersions_Injected(
    ref ManagedSpanWrapper assetBundleName,
    out BlittableArrayWrapper ret)
  {
    Caching.GetCachedVersions_InjectedDelegateField((System.IntPtr) ref assetBundleName, (System.IntPtr) ref ret);
  }

  public static bool MarkAsUsed_Injected(
    ref ManagedSpanWrapper url,
    ref ManagedSpanWrapper assetBundleName,
    [In] ref Hash128 hash)
  {
    return Caching.MarkAsUsed_InjectedDelegateField((System.IntPtr) ref url, (System.IntPtr) ref assetBundleName, (System.IntPtr) ref hash);
  }

  public static void GetCacheAt_Injected(int cacheIndex, out Cache ret)
  {
    Caching.GetCacheAt_InjectedDelegateField(cacheIndex, (System.IntPtr) ref ret);
  }

  public static bool RemoveCache_Injected([In] ref Cache cache)
  {
    return Caching.RemoveCache_InjectedDelegateField((System.IntPtr) ref cache);
  }

  public static void MoveCacheBefore_Injected([In] ref Cache src, [In] ref Cache dst)
  {
    Caching.MoveCacheBefore_InjectedDelegateField((System.IntPtr) ref src, (System.IntPtr) ref dst);
  }

  public static void MoveCacheAfter_Injected([In] ref Cache src, [In] ref Cache dst)
  {
    Caching.MoveCacheAfter_InjectedDelegateField((System.IntPtr) ref src, (System.IntPtr) ref dst);
  }

  private delegate bool get_compressionEnabledDelegate();

  private delegate bool ClearCacheDelegate();

  private delegate bool ClearCache_IntDelegate(int expiration);

  private delegate long get_spaceOccupiedDelegate();

  private delegate long get_spaceFreeDelegate();

  private delegate long get_maximumAvailableDiskSpaceDelegate();

  private delegate void set_maximumAvailableDiskSpaceDelegate(long value);

  private delegate int get_expirationDelayDelegate();

  private delegate void set_expirationDelayDelegate(int value);

  private delegate int get_cacheCountDelegate();

  private delegate void GetCachedVersions_InjectedDelegate(System.IntPtr assetBundleName, [Out] System.IntPtr ret);

  private delegate bool MarkAsUsed_InjectedDelegate(
    System.IntPtr url,
    System.IntPtr assetBundleName,
    [In] System.IntPtr hash);

  private delegate void GetCacheAt_InjectedDelegate(int cacheIndex, [Out] System.IntPtr ret);

  private delegate bool RemoveCache_InjectedDelegate([In] System.IntPtr cache);

  private delegate void MoveCacheBefore_InjectedDelegate([In] System.IntPtr src, [In] System.IntPtr dst);

  private delegate void MoveCacheAfter_InjectedDelegate([In] System.IntPtr src, [In] System.IntPtr dst);
}
