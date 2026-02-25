// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.SceneManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Events;

#nullable disable
namespace UnityEngine.SceneManagement;

public class SceneManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_AllowLoadScene;
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneLoaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_sceneUnloaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeSceneChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_IntPtr_byref_Scene_UnloadSceneOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_IntPtr_byref_Scene_0;
  private static readonly SceneManager.get_loadedSceneCountDelegate get_loadedSceneCountDelegateField;
  private static readonly SceneManager.CanSetAsActiveScene_InjectedDelegate CanSetAsActiveScene_InjectedDelegateField;
  private static readonly SceneManager.GetSceneByPath_InjectedDelegate GetSceneByPath_InjectedDelegateField;
  private static readonly SceneManager.GetSceneByName_InjectedDelegate GetSceneByName_InjectedDelegateField;
  private static readonly SceneManager.CreateScene_InjectedDelegate CreateScene_InjectedDelegateField;
  private static readonly SceneManager.UnloadSceneInternal_InjectedDelegate UnloadSceneInternal_InjectedDelegateField;
  private static readonly SceneManager.MergeScenes_InjectedDelegate MergeScenes_InjectedDelegateField;
  private static readonly SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate MoveGameObjectsToSceneByInstanceId_InjectedDelegateField;

  static SceneManager()
  {
    Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", nameof (SceneManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
    SceneManager.NativeFieldInfoPtr_s_AllowLoadScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, nameof (s_AllowLoadScene));
    SceneManager.NativeFieldInfoPtr_sceneLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, nameof (sceneLoaded));
    SceneManager.NativeFieldInfoPtr_sceneUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, nameof (sceneUnloaded));
    SceneManager.NativeFieldInfoPtr_activeSceneChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, nameof (activeSceneChanged));
    SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669239);
    SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669240);
    SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669241);
    SceneManager.NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669242);
    SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669243);
    SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669244);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669245);
    SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669246);
    SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669247);
    SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669248);
    SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669249);
    SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669250);
    SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669251);
    SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669252);
    SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669253);
    SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669254);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669255);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669256);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669257);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669258);
    SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669259);
    SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669260);
    SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669261);
    SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669262);
    SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669263);
    SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669264);
    SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669265);
    SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669267);
    SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669268);
    SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669269);
    SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_IntPtr_byref_Scene_UnloadSceneOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669270);
    SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_IntPtr_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100669271);
    SceneManager.get_loadedSceneCountDelegateField = IL2CPP.ResolveICall<SceneManager.get_loadedSceneCountDelegate>("UnityEngine.SceneManagement.SceneManager::get_loadedSceneCount");
    SceneManager.CanSetAsActiveScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CanSetAsActiveScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CanSetAsActiveScene_Injected");
    SceneManager.GetSceneByPath_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByPath_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByPath_Injected");
    SceneManager.GetSceneByName_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.GetSceneByName_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::GetSceneByName_Injected");
    SceneManager.CreateScene_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.CreateScene_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::CreateScene_Injected");
    SceneManager.UnloadSceneInternal_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.UnloadSceneInternal_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::UnloadSceneInternal_Injected");
    SceneManager.MergeScenes_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MergeScenes_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MergeScenes_Injected");
    SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField = IL2CPP.ResolveICall<SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegate>("UnityEngine.SceneManagement.SceneManager::MoveGameObjectsToSceneByInstanceId_Injected");
  }

  public static unsafe int sceneCount
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 478810, RefRangeEnd = 478812, XrefRangeStart = 478808, XrefRangeEnd = 478810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_get_sceneCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 478817, RefRangeEnd = 478821, XrefRangeStart = 478812, XrefRangeEnd = 478817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Scene GetActiveScene()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Public_Static_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478826, RefRangeEnd = 478827, XrefRangeStart = 478821, XrefRangeEnd = 478826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetActiveScene(Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Public_Static_Boolean_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478832, RefRangeEnd = 478833, XrefRangeStart = 478827, XrefRangeEnd = 478832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Scene GetSceneByBuildIndex(int buildIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buildIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 478838, RefRangeEnd = 478840, XrefRangeStart = 478833, XrefRangeEnd = 478838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Scene GetSceneAt(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Public_Static_Scene_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 478845, RefRangeEnd = 478847, XrefRangeStart = 478840, XrefRangeEnd = 478845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadSceneAsyncInternal(
    Scene scene,
    UnloadSceneOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Private_Static_AsyncOperation_Scene_UnloadSceneOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 478856, RefRangeEnd = 478863, XrefRangeStart = 478847, XrefRangeEnd = 478856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsyncNameIndexInternal(
    string sceneName,
    int sceneBuildIndex,
    LoadSceneParameters parameters,
    bool mustCompleteNextFrame)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mustCompleteNextFrame;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Private_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478863, XrefRangeEnd = 478872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadSceneNameIndexInternal(
    string sceneName,
    int sceneBuildIndex,
    bool immediately,
    UnloadSceneOptions options,
    out bool outSuccess)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &immediately;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outSuccess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Private_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478879, RefRangeEnd = 478880, XrefRangeStart = 478872, XrefRangeEnd = 478879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MoveGameObjectToScene(GameObject go, Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scene;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Public_Static_Void_GameObject_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478880, XrefRangeEnd = 478885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadFirstScene_Internal(bool async)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &async
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadFirstScene_Internal_Internal_Static_AsyncOperation_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 478898, RefRangeEnd = 478903, XrefRangeStart = 478885, XrefRangeEnd = 478898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_sceneLoaded(UnityAction<Scene, LoadSceneMode> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneLoaded_Public_Static_add_Void_UnityAction_2_Scene_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 478916, RefRangeEnd = 478919, XrefRangeStart = 478903, XrefRangeEnd = 478916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_sceneLoaded(UnityAction<Scene, LoadSceneMode> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneLoaded_Public_Static_rem_Void_UnityAction_2_Scene_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 478932, RefRangeEnd = 478936, XrefRangeStart = 478919, XrefRangeEnd = 478932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void add_sceneUnloaded(UnityAction<Scene> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_add_sceneUnloaded_Public_Static_add_Void_UnityAction_1_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 478949, RefRangeEnd = 478951, XrefRangeStart = 478936, XrefRangeEnd = 478949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public static unsafe void remove_sceneUnloaded(UnityAction<Scene> value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_remove_sceneUnloaded_Public_Static_rem_Void_UnityAction_1_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478951, XrefRangeEnd = 478965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadScene(int sceneBuildIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneBuildIndex
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478965, XrefRangeEnd = 478976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadScene_Public_Static_Scene_Int32_LoadSceneParameters_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478983, RefRangeEnd = 478984, XrefRangeStart = 478976, XrefRangeEnd = 478983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsync(int sceneBuildIndex, LoadSceneMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 478991, RefRangeEnd = 478993, XrefRangeStart = 478984, XrefRangeEnd = 478991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsync(int sceneBuildIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneBuildIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478993, XrefRangeEnd = 478997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsync(
    int sceneBuildIndex,
    LoadSceneParameters parameters)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_Int32_LoadSceneParameters_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478997, XrefRangeEnd = 479004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479008, RefRangeEnd = 479010, XrefRangeStart = 479004, XrefRangeEnd = 479008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation LoadSceneAsync(
    string sceneName,
    LoadSceneParameters parameters)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(sceneName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_LoadSceneAsync_Public_Static_AsyncOperation_String_LoadSceneParameters_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479021, RefRangeEnd = 479022, XrefRangeStart = 479010, XrefRangeEnd = 479021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadSceneAsync(string sceneName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(sceneName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479026, RefRangeEnd = 479028, XrefRangeStart = 479022, XrefRangeEnd = 479026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadSceneAsync(Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479032, RefRangeEnd = 479033, XrefRangeStart = 479028, XrefRangeEnd = 479032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncOperation UnloadSceneAsync(Scene scene, UnloadSceneOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsync_Public_Static_AsyncOperation_Scene_UnloadSceneOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479033, XrefRangeEnd = 479039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneLoaded_Private_Static_Void_Scene_LoadSceneMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479039, XrefRangeEnd = 479045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_SceneUnloaded(Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scene
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_SceneUnloaded_Private_Static_Void_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479045, XrefRangeEnd = 479051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_ActiveSceneChanged(
    Scene previousActiveScene,
    Scene newActiveScene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &previousActiveScene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newActiveScene;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Internal_ActiveSceneChanged_Private_Static_Void_Scene_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479051, XrefRangeEnd = 479053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetActiveScene_Injected(out Scene ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref ret
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetActiveScene_Injected_Private_Static_Void_byref_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479053, XrefRangeEnd = 479055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetActiveScene_Injected([In] ref Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref scene
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_SetActiveScene_Injected_Private_Static_Boolean_byref_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479055, XrefRangeEnd = 479057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSceneAt_Injected(int index, out Scene ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GetSceneAt_Injected_Private_Static_Void_Int32_byref_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479057, XrefRangeEnd = 479059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr UnloadSceneAsyncInternal_Injected(
    [In] ref Scene scene,
    UnloadSceneOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref scene;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_UnloadSceneAsyncInternal_Injected_Private_Static_IntPtr_byref_Scene_UnloadSceneOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479059, XrefRangeEnd = 479061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MoveGameObjectToScene_Injected(System.IntPtr go, [In] ref Scene scene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &go;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref scene;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_MoveGameObjectToScene_Injected_Private_Static_Void_IntPtr_byref_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool s_AllowLoadScene
  {
    get
    {
      bool sAllowLoadScene;
      IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*) &sAllowLoadScene);
      return sAllowLoadScene;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_s_AllowLoadScene, (void*) &value);
    }
  }

  public static unsafe UnityAction<Scene, LoadSceneMode> sceneLoaded
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (UnityAction<Scene, LoadSceneMode>) null : Il2CppObjectPool.Get<UnityAction<Scene, LoadSceneMode>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneLoaded, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe UnityAction<Scene> sceneUnloaded
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (UnityAction<Scene>) null : Il2CppObjectPool.Get<UnityAction<Scene>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_sceneUnloaded, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe UnityAction<Scene, Scene> activeSceneChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (UnityAction<Scene, Scene>) null : Il2CppObjectPool.Get<UnityAction<Scene, Scene>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_activeSceneChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static int loadedSceneCount => SceneManager.get_loadedSceneCountDelegateField();

  public static int sceneCountInBuildSettings
  {
    get => SceneManagerAPI.ActiveAPI.GetNumScenesInBuildSettings();
  }

  public static bool CanSetAsActiveScene(Scene scene)
  {
    return SceneManager.CanSetAsActiveScene_Injected(ref scene);
  }

  public static unsafe Scene GetSceneByPath(string scenePath)
  {
    Scene ret;
    Scene sceneByPath;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(scenePath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = scenePath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      SceneManager.GetSceneByPath_Injected(ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      sceneByPath = ret;
    }
    return sceneByPath;
  }

  public static unsafe Scene GetSceneByName(string name)
  {
    Scene ret;
    Scene sceneByName;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      SceneManager.GetSceneByName_Injected(ref managedSpanWrapper, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      sceneByName = ret;
    }
    return sceneByName;
  }

  public static unsafe Scene CreateScene(string sceneName, CreateSceneParameters parameters)
  {
    if (sceneName == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) sceneName, nameof (sceneName));
    Scene ret;
    Scene scene;
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(sceneName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = sceneName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      SceneManager.CreateScene_Injected(ref managedSpanWrapper, ref parameters, out ret);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      scene = ret;
    }
    return scene;
  }

  public static bool UnloadSceneInternal(Scene scene, UnloadSceneOptions options)
  {
    return SceneManager.UnloadSceneInternal_Injected(ref scene, options);
  }

  public static void MergeScenes(Scene sourceScene, Scene destinationScene)
  {
    SceneManager.MergeScenes_Injected(ref sourceScene, ref destinationScene);
  }

  public static void MoveGameObjectsToSceneByInstanceId(
    System.IntPtr instanceIds,
    int instanceCount,
    Scene scene)
  {
    SceneManager.MoveGameObjectsToSceneByInstanceId_Injected(instanceIds, instanceCount, ref scene);
  }

  public static unsafe void MoveGameObjectsToScene(NativeArray<int> instanceIDs, Scene scene)
  {
    if (!((NativeArray<int>) ref instanceIDs).IsCreated)
      throw new Il2CppSystem.ArgumentException("NativeArray is uninitialized", nameof (instanceIDs));
    if (((NativeArray<int>) ref instanceIDs).Length == 0)
      return;
    SceneManager.MoveGameObjectsToSceneByInstanceId((System.IntPtr) instanceIDs.GetUnsafeReadOnlyPtr<int>(), ((NativeArray<int>) ref instanceIDs).Length, scene);
  }

  [SpecialName]
  public static void add_activeSceneChanged(UnityAction<Scene, Scene> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_activeSceneChanged(UnityAction<Scene, Scene> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppStructArray<Scene> GetAllScenes()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Scene CreateScene(string sceneName)
  {
    CreateSceneParameters parameters = new CreateSceneParameters(LocalPhysicsMode.None);
    return SceneManager.CreateScene(sceneName, parameters);
  }

  public static void LoadScene(string sceneName, LoadSceneMode mode)
  {
    LoadSceneParameters parameters = new LoadSceneParameters(mode);
    SceneManager.LoadScene(sceneName, parameters);
  }

  public static void LoadScene(string sceneName)
  {
    LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
    SceneManager.LoadScene(sceneName, parameters);
  }

  public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
  {
    SceneManager.LoadSceneAsyncNameIndexInternal(sceneName, -1, parameters, true);
    return SceneManager.GetSceneAt(SceneManager.sceneCount - 1);
  }

  public static void LoadScene(int sceneBuildIndex, LoadSceneMode mode)
  {
    LoadSceneParameters parameters = new LoadSceneParameters(mode);
    SceneManager.LoadScene(sceneBuildIndex, parameters);
  }

  public static AsyncOperation LoadSceneAsync(string sceneName)
  {
    LoadSceneParameters parameters = new LoadSceneParameters(LoadSceneMode.Single);
    return SceneManager.LoadSceneAsync(sceneName, parameters);
  }

  public static bool UnloadScene(Scene scene)
  {
    return SceneManager.UnloadSceneInternal(scene, UnloadSceneOptions.None);
  }

  public static bool UnloadScene(int sceneBuildIndex)
  {
    bool outSuccess;
    SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, true, UnloadSceneOptions.None, out outSuccess);
    return outSuccess;
  }

  public static bool UnloadScene(string sceneName)
  {
    bool outSuccess;
    SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, true, UnloadSceneOptions.None, out outSuccess);
    return outSuccess;
  }

  public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex)
  {
    return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, UnloadSceneOptions.None, out bool _);
  }

  public static AsyncOperation UnloadSceneAsync(int sceneBuildIndex, UnloadSceneOptions options)
  {
    return SceneManager.UnloadSceneNameIndexInternal("", sceneBuildIndex, false, options, out bool _);
  }

  public static AsyncOperation UnloadSceneAsync(string sceneName, UnloadSceneOptions options)
  {
    return SceneManager.UnloadSceneNameIndexInternal(sceneName, -1, false, options, out bool _);
  }

  public static bool CanSetAsActiveScene_Injected([In] ref Scene scene)
  {
    return SceneManager.CanSetAsActiveScene_InjectedDelegateField((System.IntPtr) ref scene);
  }

  public static void GetSceneByPath_Injected(ref ManagedSpanWrapper scenePath, out Scene ret)
  {
    SceneManager.GetSceneByPath_InjectedDelegateField((System.IntPtr) ref scenePath, (System.IntPtr) ref ret);
  }

  public static void GetSceneByName_Injected(ref ManagedSpanWrapper name, out Scene ret)
  {
    SceneManager.GetSceneByName_InjectedDelegateField((System.IntPtr) ref name, (System.IntPtr) ref ret);
  }

  public static void CreateScene_Injected(
    ref ManagedSpanWrapper sceneName,
    [In] ref CreateSceneParameters parameters,
    out Scene ret)
  {
    SceneManager.CreateScene_InjectedDelegateField((System.IntPtr) ref sceneName, (System.IntPtr) ref parameters, (System.IntPtr) ref ret);
  }

  public static bool UnloadSceneInternal_Injected([In] ref Scene scene, UnloadSceneOptions options)
  {
    return SceneManager.UnloadSceneInternal_InjectedDelegateField((System.IntPtr) ref scene, options);
  }

  public static void MergeScenes_Injected([In] ref Scene sourceScene, [In] ref Scene destinationScene)
  {
    SceneManager.MergeScenes_InjectedDelegateField((System.IntPtr) ref sourceScene, (System.IntPtr) ref destinationScene);
  }

  public static void MoveGameObjectsToSceneByInstanceId_Injected(
    System.IntPtr instanceIds,
    int instanceCount,
    [In] ref Scene scene)
  {
    SceneManager.MoveGameObjectsToSceneByInstanceId_InjectedDelegateField(instanceIds, instanceCount, (System.IntPtr) ref scene);
  }

  private delegate int get_loadedSceneCountDelegate();

  private delegate bool CanSetAsActiveScene_InjectedDelegate([In] System.IntPtr scene);

  private delegate void GetSceneByPath_InjectedDelegate(System.IntPtr scenePath, [Out] System.IntPtr ret);

  private delegate void GetSceneByName_InjectedDelegate(System.IntPtr name, [Out] System.IntPtr ret);

  private delegate void CreateScene_InjectedDelegate(
    System.IntPtr sceneName,
    [In] System.IntPtr parameters,
    [Out] System.IntPtr ret);

  private delegate bool UnloadSceneInternal_InjectedDelegate(
    [In] System.IntPtr scene,
    UnloadSceneOptions options);

  private delegate void MergeScenes_InjectedDelegate([In] System.IntPtr sourceScene, [In] System.IntPtr destinationScene);

  private delegate void MoveGameObjectsToSceneByInstanceId_InjectedDelegate(
    System.IntPtr instanceIds,
    int instanceCount,
    [In] System.IntPtr scene);
}
