// Decompiled with JetBrains decompiler
// Type: UnityEngine.ResourcesAPIInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public static class ResourcesAPIInternal : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindShaderByName_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_Injected_Private_Static_Il2CppReferenceArray_1_Object_byref_ManagedSpanWrapper_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_Injected_Private_Static_Void_IntPtr_0;
  private static readonly ResourcesAPIInternal.LoadAsyncInternal_InjectedDelegate LoadAsyncInternal_InjectedDelegateField;

  static ResourcesAPIInternal()
  {
    Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ResourcesAPIInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr);
    ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667781);
    ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667782);
    ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667783);
    ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667784);
    ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667785);
    ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667786);
    ResourcesAPIInternal.NativeMethodInfoPtr_Load_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667787);
    ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Injected_Private_Static_Il2CppReferenceArray_1_Object_byref_ManagedSpanWrapper_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667788);
    ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPIInternal>.NativeClassPtr, 100667789);
    ResourcesAPIInternal.LoadAsyncInternal_InjectedDelegateField = IL2CPP.ResolveICall<ResourcesAPIInternal.LoadAsyncInternal_InjectedDelegate>("UnityEngine.ResourcesAPIInternal::LoadAsyncInternal_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442114, XrefRangeEnd = 442116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442134, RefRangeEnd = 442135, XrefRangeStart = 442116, XrefRangeEnd = 442134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Shader FindShaderByName(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Public_Static_Shader_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442156, RefRangeEnd = 442157, XrefRangeStart = 442135, XrefRangeEnd = 442156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Object Load(string path, Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442177, RefRangeEnd = 442178, XrefRangeStart = 442157, XrefRangeEnd = 442177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> LoadAll(string path, Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442178, XrefRangeEnd = 442183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadAsset(Object assetToUnload)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetToUnload)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442183, XrefRangeEnd = 442185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref name
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_FindShaderByName_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442185, XrefRangeEnd = 442187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Load_Injected(
    ref ManagedSpanWrapper path,
    Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref path;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_Load_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442187, XrefRangeEnd = 442189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Object> LoadAll_Injected(
    ref ManagedSpanWrapper path,
    Il2CppSystem.Type systemTypeInstance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref path;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_LoadAll_Injected_Private_Static_Il2CppReferenceArray_1_Object_byref_ManagedSpanWrapper_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442189, XrefRangeEnd = 442191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadAsset_Injected(System.IntPtr assetToUnload)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &assetToUnload
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResourcesAPIInternal.NativeMethodInfoPtr_UnloadAsset_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ResourcesAPIInternal(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ResourceRequest LoadAsyncInternal(string path, Il2CppSystem.Type type)
  {
    System.IntPtr num1;
    ResourceRequest managed;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = path.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      num1 = ResourcesAPIInternal.LoadAsyncInternal_Injected(ref managedSpanWrapper, type);
    }
    finally
    {
      System.IntPtr num2 = num1;
      managed = num2 == System.IntPtr.Zero ? (ResourceRequest) null : ResourceRequest.BindingsMarshaller.ConvertToManaged(num2);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
    return managed;
  }

  public static System.IntPtr LoadAsyncInternal_Injected(ref ManagedSpanWrapper path, Il2CppSystem.Type type)
  {
    return ResourcesAPIInternal.LoadAsyncInternal_InjectedDelegateField((System.IntPtr) ref path, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type));
  }

  public static class EntitiesAssetGC
  {
  }

  private delegate System.IntPtr LoadAsyncInternal_InjectedDelegate(System.IntPtr path, System.IntPtr type);
}
