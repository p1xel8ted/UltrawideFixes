// Decompiled with JetBrains decompiler
// Type: UnityEngine.Resources
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
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Resources(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0;
  private static readonly Resources.IsInstanceLoadedDelegate IsInstanceLoadedDelegateField;
  private static readonly Resources.InstanceIDToObjectListDelegate InstanceIDToObjectListDelegateField;
  private static readonly Resources.InstanceIDsToValidArray_InternalDelegate InstanceIDsToValidArray_InternalDelegateField;
  private static readonly Resources.UnloadAssetImplResourceManager_InjectedDelegate UnloadAssetImplResourceManager_InjectedDelegateField;

  static Resources()
  {
    Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Resources));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
    Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667799);
    Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667800);
    Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667801);
    Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667802);
    Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667803);
    Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667804);
    Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667805);
    Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667806);
    Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667807);
    Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667808);
    Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667809);
    Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667810);
    Resources.NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667811);
    Resources.NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667812);
    Resources.NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667813);
    Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667814);
    Resources.NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100667815);
    Resources.IsInstanceLoadedDelegateField = IL2CPP.ResolveICall<Resources.IsInstanceLoadedDelegate>("UnityEngine.Resources::IsInstanceLoaded");
    Resources.InstanceIDToObjectListDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectListDelegate>("UnityEngine.Resources::InstanceIDToObjectList");
    Resources.InstanceIDsToValidArray_InternalDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDsToValidArray_InternalDelegate>("UnityEngine.Resources::InstanceIDsToValidArray_Internal");
    Resources.UnloadAssetImplResourceManager_InjectedDelegateField = IL2CPP.ResolveICall<Resources.UnloadAssetImplResourceManager_InjectedDelegate>("UnityEngine.Resources::UnloadAssetImplResourceManager_Injected");
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 442233, RefRangeEnd = 442237, XrefRangeStart = 442226, XrefRangeEnd = 442233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rawObjects)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442242, RefRangeEnd = 442243, XrefRangeStart = 442237, XrefRangeEnd = 442242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 442249, RefRangeEnd = 442253, XrefRangeStart = 442243, XrefRangeEnd = 442249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> FindObjectsOfTypeAll<T>() where T : Object
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 442259, RefRangeEnd = 442265, XrefRangeStart = 442253, XrefRangeEnd = 442259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object Load(string path)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(path)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(37)]
  [CachedScanResults(RefRangeStart = 442271, RefRangeEnd = 442308, XrefRangeStart = 442265, XrefRangeEnd = 442271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T Load<T>(string path) where T : Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(path)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 442313, RefRangeEnd = 442318, XrefRangeStart = 442308, XrefRangeEnd = 442313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object Load(string path, Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442323, RefRangeEnd = 442324, XrefRangeStart = 442318, XrefRangeEnd = 442323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> LoadAll(string path, Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 442330, RefRangeEnd = 442332, XrefRangeStart = 442324, XrefRangeEnd = 442330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppArrayBase<T> LoadAll<T>(string path) where T : Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(path)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442353, RefRangeEnd = 442354, XrefRangeStart = 442332, XrefRangeEnd = 442353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object GetBuiltinResource(Il2CppSystem.Type type, string path)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(path);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 442360, RefRangeEnd = 442366, XrefRangeStart = 442354, XrefRangeEnd = 442360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetBuiltinResource<T>(string path) where T : Object
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(path)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 442371, RefRangeEnd = 442374, XrefRangeStart = 442366, XrefRangeEnd = 442371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadAsset(Object assetToUnload)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetToUnload)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 442376, RefRangeEnd = 442380, XrefRangeStart = 442374, XrefRangeEnd = 442376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadUnusedAssets()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 442385, RefRangeEnd = 442387, XrefRangeStart = 442380, XrefRangeEnd = 442385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object InstanceIDToObject(int instanceID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &instanceID
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_InstanceIDToObject_Public_Static_Object_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 442389, RefRangeEnd = 442391, XrefRangeStart = 442387, XrefRangeEnd = 442389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool InstanceIDIsValid(int instanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &instanceId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_InstanceIDIsValid_Public_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442391, XrefRangeEnd = 442393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetBuiltinResource_Injected(
    Il2CppSystem.Type type,
    ref ManagedSpanWrapper path)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref path;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_GetBuiltinResource_Injected_Private_Static_IntPtr_Type_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442393, XrefRangeEnd = 442395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr UnloadUnusedAssets_Injected()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Injected_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442395, XrefRangeEnd = 442397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr InstanceIDToObject_Injected(int instanceID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &instanceID
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_InstanceIDToObject_Injected_Private_Static_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static ResourceRequest LoadAsync(string path)
  {
    return Resources.LoadAsync(path, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
  }

  public static ResourceRequest LoadAsync<T>(string path) where T : Object
  {
    return Resources.LoadAsync(path, Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()));
  }

  public static ResourceRequest LoadAsync(string path, Il2CppSystem.Type type)
  {
    return ResourcesAPI.ActiveAPI.LoadAsync(path, type);
  }

  public static void UnloadAssetImplResourceManager(Object assetToUnload)
  {
    Resources.UnloadAssetImplResourceManager_Injected(Object.MarshalledUnityObject.Marshal<Object>(assetToUnload));
  }

  public static bool IsInstanceLoaded(int instanceID)
  {
    return Resources.IsInstanceLoadedDelegateField(instanceID);
  }

  public static void InstanceIDToObjectList(
    System.IntPtr instanceIDs,
    int instanceCount,
    List<Object> objects)
  {
    Resources.InstanceIDToObjectListDelegateField(instanceIDs, instanceCount, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objects));
  }

  public static unsafe void InstanceIDToObjectList(
    NativeArray<int> instanceIDs,
    List<Object> objects)
  {
    if (!((NativeArray<int>) ref instanceIDs).IsCreated)
      throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", nameof (instanceIDs));
    if (objects == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (objects));
    if (((NativeArray<int>) ref instanceIDs).Length == 0)
      objects.Clear();
    else
      Resources.InstanceIDToObjectList((System.IntPtr) instanceIDs.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref instanceIDs).Length, objects);
  }

  public static void InstanceIDsToValidArray_Internal(
    System.IntPtr instanceIDs,
    int instanceCount,
    System.IntPtr validArray,
    int validArrayCount)
  {
    Resources.InstanceIDsToValidArray_InternalDelegateField(instanceIDs, instanceCount, validArray, validArrayCount);
  }

  public static unsafe void InstanceIDsToValidArray(
    NativeArray<int> instanceIDs,
    NativeArray<bool> validArray)
  {
    if (!((NativeArray<int>) ref instanceIDs).IsCreated)
      throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", nameof (instanceIDs));
    if (!((NativeArray<bool>) ref validArray).IsCreated)
      throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", nameof (validArray));
    if (((NativeArray<int>) ref instanceIDs).Length != ((NativeArray<bool>) ref validArray).Length)
      throw new Il2CppSystem.ArgumentException("Size mismatch! Both arrays must be the same length.");
    if (((NativeArray<int>) ref instanceIDs).Length == 0)
      return;
    Resources.InstanceIDsToValidArray_Internal((System.IntPtr) instanceIDs.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref instanceIDs).Length, (System.IntPtr) validArray.GetUnsafePtr<bool>(), ((NativeArray<bool>) ref validArray).Length);
  }

  public static unsafe void InstanceIDsToValidArray(
    Il2CppSystem.ReadOnlySpan<int> instanceIDs,
    Il2CppSystem.Span<bool> validArray)
  {
    if (((Il2CppSystem.ReadOnlySpan<int>) ref instanceIDs).Length != ((Il2CppSystem.Span<bool>) ref validArray).Length)
      throw new Il2CppSystem.ArgumentException("Size mismatch! Both arrays must be the same length.");
    if (((Il2CppSystem.ReadOnlySpan<int>) ref instanceIDs).Length == 0)
      return;
    fixed (int* instanceIDs1 = &((Il2CppSystem.ReadOnlySpan<int>) ref instanceIDs).GetPinnableReference())
      fixed (bool* validArray1 = &((Il2CppSystem.Span<bool>) ref validArray).GetPinnableReference())
        Resources.InstanceIDsToValidArray_Internal((System.IntPtr) (void*) instanceIDs1, ((Il2CppSystem.ReadOnlySpan<int>) ref instanceIDs).Length, (System.IntPtr) (void*) validArray1, ((Il2CppSystem.Span<bool>) ref validArray).Length);
  }

  public static void UnloadAssetImplResourceManager_Injected(System.IntPtr assetToUnload)
  {
    Resources.UnloadAssetImplResourceManager_InjectedDelegateField(assetToUnload);
  }

  private sealed class MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private delegate bool IsInstanceLoadedDelegate(int instanceID);

  private delegate void InstanceIDToObjectListDelegate(
    System.IntPtr instanceIDs,
    int instanceCount,
    System.IntPtr objects);

  private delegate void InstanceIDsToValidArray_InternalDelegate(
    System.IntPtr instanceIDs,
    int instanceCount,
    System.IntPtr validArray,
    int validArrayCount);

  private delegate void UnloadAssetImplResourceManager_InjectedDelegate(System.IntPtr assetToUnload);
}
