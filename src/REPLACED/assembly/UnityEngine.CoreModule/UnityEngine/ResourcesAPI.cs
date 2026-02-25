// Decompiled with JetBrains decompiler
// Type: UnityEngine.ResourcesAPI
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class ResourcesAPI(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultAPI;
  private static readonly System.IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0;

  static ResourcesAPI()
  {
    Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ResourcesAPI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr);
    ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, nameof (s_DefaultAPI));
    ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
    ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667790);
    ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667791);
    ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667792);
    ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667793);
    ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667794);
    ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667795);
    ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667796);
    ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr, 100667797);
  }

  public static unsafe ResourcesAPI ActiveAPI
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 442201, RefRangeEnd = 442207, XrefRangeStart = 442191, XrefRangeEnd = 442201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_ResourcesAPI_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ResourcesAPI) null : Il2CppObjectPool.Get<ResourcesAPI>(num3);
    }
  }

  public static unsafe ResourcesAPI overrideAPI
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442207, XrefRangeEnd = 442211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_ResourcesAPI_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ResourcesAPI) null : Il2CppObjectPool.Get<ResourcesAPI>(num3);
    }
    set => ResourcesAPI._overrideAPI_k__BackingField = value;
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResourcesAPI()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcesAPI>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResourcesAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442211, XrefRangeEnd = 442213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Il2CppSystem.Type systemTypeInstance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourcesAPI.NativeMethodInfoPtr_FindObjectsOfTypeAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442213, XrefRangeEnd = 442214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Shader FindShaderByName(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourcesAPI.NativeMethodInfoPtr_FindShaderByName_FamOrAssem_Virtual_New_Shader_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442214, XrefRangeEnd = 442215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Object Load(string path, Il2CppSystem.Type systemTypeInstance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourcesAPI.NativeMethodInfoPtr_Load_FamOrAssem_Virtual_New_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442215, XrefRangeEnd = 442216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppReferenceArray<Object> LoadAll(string path, Il2CppSystem.Type systemTypeInstance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemTypeInstance);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourcesAPI.NativeMethodInfoPtr_LoadAll_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_Object_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442216, XrefRangeEnd = 442226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnloadAsset(Object assetToUnload)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) assetToUnload)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ResourcesAPI.NativeMethodInfoPtr_UnloadAsset_FamOrAssem_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ResourcesAPI s_DefaultAPI
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ResourcesAPI) null : Il2CppObjectPool.Get<ResourcesAPI>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ResourcesAPI _overrideAPI_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ResourcesAPI) null : Il2CppObjectPool.Get<ResourcesAPI>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ResourcesAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public virtual ResourceRequest LoadAsync(string path, Il2CppSystem.Type systemTypeInstance)
  {
    ResourceRequest resourceRequest = ResourcesAPIInternal.LoadAsyncInternal(path, systemTypeInstance);
    resourceRequest.m_Path = path;
    resourceRequest.m_Type = systemTypeInstance;
    return resourceRequest;
  }
}
