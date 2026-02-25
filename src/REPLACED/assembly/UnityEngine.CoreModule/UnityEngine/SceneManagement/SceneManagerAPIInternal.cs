// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.SceneManagerAPIInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.SceneManagement;

public static class SceneManagerAPIInternal : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneByBuildIndex_Injected_Private_Static_Void_Int32_byref_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0;
  private static readonly SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate GetNumScenesInBuildSettingsDelegateField;

  static SceneManagerAPIInternal()
  {
    Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", nameof (SceneManagerAPIInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr);
    SceneManagerAPIInternal.NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669225);
    SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669226);
    SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669227);
    SceneManagerAPIInternal.NativeMethodInfoPtr_GetSceneByBuildIndex_Injected_Private_Static_Void_Int32_byref_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669228);
    SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669229);
    SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManagerAPIInternal>.NativeClassPtr, 100669230);
    SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField = IL2CPP.ResolveICall<SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegate>("UnityEngine.SceneManagement.SceneManagerAPIInternal::GetNumScenesInBuildSettings");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478742, XrefRangeEnd = 478744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Scene GetSceneByBuildIndex(int buildIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &buildIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_GetSceneByBuildIndex_Public_Static_Scene_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Scene*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478758, RefRangeEnd = 478759, XrefRangeStart = 478744, XrefRangeEnd = 478758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Public_Static_AsyncOperation_String_Int32_LoadSceneParameters_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478773, RefRangeEnd = 478774, XrefRangeStart = 478759, XrefRangeEnd = 478773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Public_Static_AsyncOperation_String_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AsyncOperation) null : Il2CppObjectPool.Get<AsyncOperation>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478774, XrefRangeEnd = 478776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSceneByBuildIndex_Injected(int buildIndex, out Scene ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &buildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_GetSceneByBuildIndex_Injected_Private_Static_Void_Int32_byref_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478776, XrefRangeEnd = 478778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr LoadSceneAsyncNameIndexInternal_Injected(
    ref ManagedSpanWrapper sceneName,
    int sceneBuildIndex,
    [In] ref LoadSceneParameters parameters,
    bool mustCompleteNextFrame)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref sceneName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mustCompleteNextFrame;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_LoadSceneAsyncNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_byref_LoadSceneParameters_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478778, XrefRangeEnd = 478780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr UnloadSceneNameIndexInternal_Injected(
    ref ManagedSpanWrapper sceneName,
    int sceneBuildIndex,
    bool immediately,
    UnloadSceneOptions options,
    out bool outSuccess)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref sceneName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sceneBuildIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &immediately;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref outSuccess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneManagerAPIInternal.NativeMethodInfoPtr_UnloadSceneNameIndexInternal_Injected_Private_Static_IntPtr_byref_ManagedSpanWrapper_Int32_Boolean_UnloadSceneOptions_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public SceneManagerAPIInternal(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static int GetNumScenesInBuildSettings()
  {
    return SceneManagerAPIInternal.GetNumScenesInBuildSettingsDelegateField();
  }

  private delegate int GetNumScenesInBuildSettingsDelegate();
}
