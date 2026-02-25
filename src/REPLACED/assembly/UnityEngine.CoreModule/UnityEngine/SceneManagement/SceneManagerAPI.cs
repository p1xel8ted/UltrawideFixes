// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.SceneManagerAPI
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.SceneManagement;

public class SceneManagerAPI(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_DefaultAPI;
  private static readonly System.IntPtr NativeFieldInfoPtr__overrideAPI_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneByBuildIndex_FamOrAssem_Virtual_New_Scene_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0;

  static SceneManagerAPI()
  {
    Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", nameof (SceneManagerAPI));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr);
    SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, nameof (s_DefaultAPI));
    SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, "<overrideAPI>k__BackingField");
    SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669231);
    SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669232);
    SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669233);
    SceneManagerAPI.NativeMethodInfoPtr_GetSceneByBuildIndex_FamOrAssem_Virtual_New_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669234);
    SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669235);
    SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669236);
    SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr, 100669237);
  }

  public static unsafe SceneManagerAPI ActiveAPI
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 478790, RefRangeEnd = 478795, XrefRangeStart = 478780, XrefRangeEnd = 478790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_ActiveAPI_Internal_Static_get_SceneManagerAPI_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SceneManagerAPI) null : Il2CppObjectPool.Get<SceneManagerAPI>(num3);
    }
  }

  public static unsafe SceneManagerAPI overrideAPI
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478795, XrefRangeEnd = 478799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr_get_overrideAPI_Public_Static_get_SceneManagerAPI_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SceneManagerAPI) null : Il2CppObjectPool.Get<SceneManagerAPI>(num3);
    }
    set => SceneManagerAPI._overrideAPI_k__BackingField = value;
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneManagerAPI()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManagerAPI>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManagerAPI.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478799, XrefRangeEnd = 478801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Scene GetSceneByBuildIndex(int buildIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buildIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneManagerAPI.NativeMethodInfoPtr_GetSceneByBuildIndex_FamOrAssem_Virtual_New_Scene_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478801, XrefRangeEnd = 478802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe AsyncOperation LoadSceneAsyncByNameOrIndex(
    string sceneName,
    int sceneBuildIndex,
    LoadSceneParameters parameters,
    bool mustCompleteNextFrame)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mustCompleteNextFrame;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneManagerAPI.NativeMethodInfoPtr_LoadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478802, XrefRangeEnd = 478808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe AsyncOperation UnloadSceneAsyncByNameOrIndex(
    string sceneName,
    int sceneBuildIndex,
    bool immediately,
    UnloadSceneOptions options,
    out bool outSuccess)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &immediately;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outSuccess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneManagerAPI.NativeMethodInfoPtr_UnloadSceneAsyncByNameOrIndex_FamOrAssem_Virtual_New_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe AsyncOperation LoadFirstScene(bool mustLoadAsync)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mustLoadAsync
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SceneManagerAPI.NativeMethodInfoPtr_LoadFirstScene_FamOrAssem_Virtual_New_AsyncOperation_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  public static unsafe SceneManagerAPI s_DefaultAPI
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SceneManagerAPI) null : Il2CppObjectPool.Get<SceneManagerAPI>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr_s_DefaultAPI, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SceneManagerAPI _overrideAPI_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SceneManagerAPI) null : Il2CppObjectPool.Get<SceneManagerAPI>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManagerAPI.NativeFieldInfoPtr__overrideAPI_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public virtual int GetNumScenesInBuildSettings()
  {
    return SceneManagerAPIInternal.GetNumScenesInBuildSettings();
  }
}
