// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.LoadingManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

#nullable disable
namespace SadCatStudios.Foundation;

public class LoadingManager(System.IntPtr pointer) : GlobalSingletonBehaviour<LoadingManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_foundationLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_uiPromptsLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_loadingLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_pcInterfaceLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_pdaInterfaceLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentScenes;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentFoundationScenes;
  private static readonly System.IntPtr NativeFieldInfoPtr_loadingScreenFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_pcInterfaceInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_pdaInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_finishLoading;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentLabel;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FinishLoading_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadingScreenFinished_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentLabel_Public_get_AssetLabelReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PDALoaded_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchPDA_Public_Void_Boolean_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchPCInterface_Public_Void_Boolean_UniTaskCompletionSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddScene_Public_UniTask_1_SceneInstance_AssetLabelReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveScene_Public_UniTask_SceneInstance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchScenes_Public_Void_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCurrentScenes_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchToMainMenu_Public_UniTaskVoid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadBaseScenes_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchScenesCoroutine_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadLabelScenes_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BootstrapFinished_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LoadingManager()
  {
    Il2CppClassPointerStore<LoadingManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (LoadingManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr);
    LoadingManager.NativeFieldInfoPtr_foundationLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (foundationLabel));
    LoadingManager.NativeFieldInfoPtr_uiPromptsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (uiPromptsLabel));
    LoadingManager.NativeFieldInfoPtr_loadingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (loadingLabel));
    LoadingManager.NativeFieldInfoPtr_pcInterfaceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (pcInterfaceLabel));
    LoadingManager.NativeFieldInfoPtr_pdaInterfaceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (pdaInterfaceLabel));
    LoadingManager.NativeFieldInfoPtr_currentScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (currentScenes));
    LoadingManager.NativeFieldInfoPtr_currentFoundationScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (currentFoundationScenes));
    LoadingManager.NativeFieldInfoPtr_loadingScreenFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (loadingScreenFinished));
    LoadingManager.NativeFieldInfoPtr_pcInterfaceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (pcInterfaceInstance));
    LoadingManager.NativeFieldInfoPtr_pdaInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (pdaInstance));
    LoadingManager.NativeFieldInfoPtr_finishLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (finishLoading));
    LoadingManager.NativeFieldInfoPtr_currentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, nameof (currentLabel));
    LoadingManager.NativeMethodInfoPtr_get_FinishLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671365);
    LoadingManager.NativeMethodInfoPtr_get_LoadingScreenFinished_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671366);
    LoadingManager.NativeMethodInfoPtr_get_CurrentLabel_Public_get_AssetLabelReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671367);
    LoadingManager.NativeMethodInfoPtr_get_PDALoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671368);
    LoadingManager.NativeMethodInfoPtr_SwitchPDA_Public_Void_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671369);
    LoadingManager.NativeMethodInfoPtr_SwitchPCInterface_Public_Void_Boolean_UniTaskCompletionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671370);
    LoadingManager.NativeMethodInfoPtr_AddScene_Public_UniTask_1_SceneInstance_AssetLabelReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671371);
    LoadingManager.NativeMethodInfoPtr_RemoveScene_Public_UniTask_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671372);
    LoadingManager.NativeMethodInfoPtr_SwitchScenes_Public_Void_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671373);
    LoadingManager.NativeMethodInfoPtr_ClearCurrentScenes_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671374);
    LoadingManager.NativeMethodInfoPtr_SwitchToMainMenu_Public_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671375);
    LoadingManager.NativeMethodInfoPtr_LoadBaseScenes_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671376);
    LoadingManager.NativeMethodInfoPtr_SwitchScenesCoroutine_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671377);
    LoadingManager.NativeMethodInfoPtr_LoadLabelScenes_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671378);
    LoadingManager.NativeMethodInfoPtr_BootstrapFinished_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671379);
    LoadingManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, 100671380);
  }

  public unsafe bool FinishLoading
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_get_FinishLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LoadingScreenFinished
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_get_LoadingScreenFinished_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AssetLabelReference CurrentLabel
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72966, RefRangeEnd = 72967, XrefRangeStart = 72966, XrefRangeEnd = 72967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_get_CurrentLabel_Public_get_AssetLabelReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num3);
    }
  }

  public unsafe bool PDALoaded
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 93857, RefRangeEnd = 93858, XrefRangeStart = 93854, XrefRangeEnd = 93857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_get_PDALoaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 93868, RefRangeEnd = 93870, XrefRangeStart = 93858, XrefRangeEnd = 93868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchPDA(bool enable, ArticyObject switchToItem = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &enable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) switchToItem);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_SwitchPDA_Public_Void_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 93880, RefRangeEnd = 93884, XrefRangeStart = 93870, XrefRangeEnd = 93880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchPCInterface(bool enable, UniTaskCompletionSource done)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &enable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) done);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_SwitchPCInterface_Public_Void_Boolean_UniTaskCompletionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93892, RefRangeEnd = 93893, XrefRangeStart = 93884, XrefRangeEnd = 93892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask<SceneInstance> AddScene(AssetLabelReference sceneLabelReference)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneLabelReference)
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_AddScene_Public_UniTask_1_SceneInstance_AssetLabelReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask<SceneInstance>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93898, RefRangeEnd = 93899, XrefRangeStart = 93893, XrefRangeEnd = 93898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask RemoveScene(SceneInstance sceneInstance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sceneInstance))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_RemoveScene_Public_UniTask_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 93904, RefRangeEnd = 93910, XrefRangeStart = 93899, XrefRangeEnd = 93904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchScenes(
    AssetLabelReference label,
    Il2CppSystem.Func<UniTask> afterLoadCallback = null,
    Il2CppSystem.Action preUnloadCallback = null,
    bool needBaseScenes = false,
    DifficultyLevel initialDifficulty = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) afterLoadCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preUnloadCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &needBaseScenes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initialDifficulty);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_SwitchScenes_Public_Void_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93917, RefRangeEnd = 93918, XrefRangeStart = 93910, XrefRangeEnd = 93917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearCurrentScenes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_ClearCurrentScenes_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93921, RefRangeEnd = 93922, XrefRangeStart = 93918, XrefRangeEnd = 93921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid SwitchToMainMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_SwitchToMainMenu_Public_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93922, XrefRangeEnd = 93926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator LoadBaseScenes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_LoadBaseScenes_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93926, XrefRangeEnd = 93930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator SwitchScenesCoroutine(
    AssetLabelReference label,
    Il2CppSystem.Func<UniTask> afterLoadCallback,
    Il2CppSystem.Action preUnloadCallback,
    bool needBaseScenes,
    DifficultyLevel initialDifficulty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) afterLoadCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preUnloadCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &needBaseScenes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) initialDifficulty);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_SwitchScenesCoroutine_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_Action_Boolean_DifficultyLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93930, XrefRangeEnd = 93934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator LoadLabelScenes(
    AssetLabelReference labelReference,
    Il2CppSystem.Func<UniTask> callback = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) labelReference);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_LoadLabelScenes_Private_IEnumerator_AssetLabelReference_Func_1_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93938, RefRangeEnd = 93939, XrefRangeStart = 93934, XrefRangeEnd = 93938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator BootstrapFinished()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr_BootstrapFinished_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93939, XrefRangeEnd = 93981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoadingManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadingManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetLabelReference foundationLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_foundationLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_foundationLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetLabelReference uiPromptsLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_uiPromptsLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_uiPromptsLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetLabelReference loadingLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_loadingLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_loadingLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetLabelReference pcInterfaceLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pcInterfaceLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pcInterfaceLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetLabelReference pdaInterfaceLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pdaInterfaceLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pdaInterfaceLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SceneInstance> currentScenes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentScenes));
      return num == System.IntPtr.Zero ? (List<SceneInstance>) null : Il2CppObjectPool.Get<List<SceneInstance>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentScenes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Scene> currentFoundationScenes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentFoundationScenes));
      return num == System.IntPtr.Zero ? (List<Scene>) null : Il2CppObjectPool.Get<List<Scene>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentFoundationScenes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool loadingScreenFinished
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_loadingScreenFinished));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_loadingScreenFinished)) = value;
    }
  }

  public AsyncOperationHandle<SceneInstance> pcInterfaceInstance
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pcInterfaceInstance);
      return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pcInterfaceInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public AsyncOperationHandle<SceneInstance> pdaInstance
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pdaInstance);
      return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_pdaInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe bool finishLoading
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_finishLoading));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_finishLoading)) = value;
    }
  }

  public unsafe AssetLabelReference currentLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentLabel));
      return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.NativeFieldInfoPtr_currentLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_enable;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_switchToItem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr);
      LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, nameof (enable));
      LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
      LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_switchToItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, nameof (switchToItem));
      LoadingManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, 100671381);
      LoadingManager.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, 100671382);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93400, XrefRangeEnd = 93404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe bool enable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_enable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_enable)) = value;
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyObject switchToItem
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_switchToItem));
        return num == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.NativeFieldInfoPtr_switchToItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<>c__DisplayClass20_0+<<SwitchPDA>g__DoSwitch|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__pdaLocation_5__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique()
      {
        Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0>.NativeClassPtr, "<<SwitchPDA>g__DoSwitch|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>1__state");
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>2__current");
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>4__this");
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pdaLocation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<pdaLocation>5__2");
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671383);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671384);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671385);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671386);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671387);
        LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671388);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93383, XrefRangeEnd = 93395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93395, XrefRangeEnd = 93400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LoadingManager.__c__DisplayClass20_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (LoadingManager.__c__DisplayClass20_0) null : Il2CppObjectPool.Get<LoadingManager.__c__DisplayClass20_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public AsyncOperationHandle<IList<IResourceLocation>> _pdaLocation_5__2
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pdaLocation_5__2);
          return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass20_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pdaLocation_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_enable;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_done;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr);
      LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, nameof (enable));
      LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
      LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, nameof (done));
      LoadingManager.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, 100671389);
      LoadingManager.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, 100671390);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93419, XrefRangeEnd = 93423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    public unsafe bool enable
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_enable));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_enable)) = value;
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UniTaskCompletionSource done
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_done));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.NativeFieldInfoPtr_done), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<>c__DisplayClass21_0+<<SwitchPCInterface>g__DoSwitch|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
      private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__pcLocation_5__2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique()
      {
        Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0>.NativeClassPtr, "<<SwitchPCInterface>g__DoSwitch|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>1__state");
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>2__current");
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<>4__this");
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pcLocation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, "<pcLocation>5__2");
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671391);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671392);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671393);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671394);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671395);
        LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr, 100671396);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93404, XrefRangeEnd = 93414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93414, XrefRangeEnd = 93419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe LoadingManager.__c__DisplayClass21_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (LoadingManager.__c__DisplayClass21_0) null : Il2CppObjectPool.Get<LoadingManager.__c__DisplayClass21_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public AsyncOperationHandle<IList<IResourceLocation>> _pcLocation_5__2
      {
        get
        {
          System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pcLocation_5__2);
          return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObAs1ILIR1ObObUnique.NativeFieldInfoPtr__pcLocation_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<AddScene>d__22")]
  public sealed class _AddScene_d__22 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_sceneLabelReference;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _AddScene_d__22()
    {
      Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<AddScene>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr);
      LoadingManager._AddScene_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, "<>1__state");
      LoadingManager._AddScene_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, "<>t__builder");
      LoadingManager._AddScene_d__22.NativeFieldInfoPtr_sceneLabelReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, nameof (sceneLabelReference));
      LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, "<>u__1");
      LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, "<>u__2");
      LoadingManager._AddScene_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, 100671397);
      LoadingManager._AddScene_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr, 100671398);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 93441, RefRangeEnd = 93443, XrefRangeStart = 93423, XrefRangeEnd = 93441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._AddScene_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93443, XrefRangeEnd = 93446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._AddScene_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _AddScene_d__22(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _AddScene_d__22()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._AddScene_d__22>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder<SceneInstance> __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe AssetLabelReference sceneLabelReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr_sceneLabelReference));
        return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr_sceneLabelReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask<IList<IResourceLocation>>.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__1);
        return new UniTask<IList<IResourceLocation>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IList<IResourceLocation>>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IList<IResourceLocation>>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask<SceneInstance>.Awaiter __u__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__2);
        return new UniTask<SceneInstance>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._AddScene_d__22.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<BootstrapFinished>d__30")]
  public sealed class _BootstrapFinished_d__30(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _BootstrapFinished_d__30()
    {
      Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<BootstrapFinished>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr);
      LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, "<>1__state");
      LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, "<>2__current");
      LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, "<>4__this");
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671399);
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671400);
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671401);
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671402);
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671403);
      LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr, 100671404);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _BootstrapFinished_d__30(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._BootstrapFinished_d__30>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93446, XrefRangeEnd = 93451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93451, XrefRangeEnd = 93456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._BootstrapFinished_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._BootstrapFinished_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<LoadBaseScenes>d__27")]
  public sealed class _LoadBaseScenes_d__27(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__foundationAssetLocation_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__foundationLoading_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__uiLocation_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__uiLoading_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _LoadBaseScenes_d__27()
    {
      Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<LoadBaseScenes>d__27");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr);
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<>1__state");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<>2__current");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<>4__this");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationAssetLocation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<foundationAssetLocation>5__2");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationLoading_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<foundationLoading>5__3");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLocation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<uiLocation>5__4");
      LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLoading_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, "<uiLoading>5__5");
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671405);
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671406);
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671407);
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671408);
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671409);
      LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr, 100671410);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LoadBaseScenes_d__27(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._LoadBaseScenes_d__27>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93456, XrefRangeEnd = 93464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93464, XrefRangeEnd = 93469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadBaseScenes_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<IList<IResourceLocation>> _foundationAssetLocation_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationAssetLocation_5__2);
        return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationAssetLocation_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public AsyncOperationHandle<SceneInstance> _foundationLoading_5__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationLoading_5__3);
        return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__foundationLoading_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public AsyncOperationHandle<IList<IResourceLocation>> _uiLocation_5__4
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLocation_5__4);
        return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLocation_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public AsyncOperationHandle<SceneInstance> _uiLoading_5__5
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLoading_5__5);
        return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadBaseScenes_d__27.NativeFieldInfoPtr__uiLoading_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<LoadLabelScenes>d__29")]
  public sealed class _LoadLabelScenes_d__29(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_labelReference;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeFieldInfoPtr__labelPaths_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__sceneLoad_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _LoadLabelScenes_d__29()
    {
      Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<LoadLabelScenes>d__29");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr);
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<>1__state");
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<>2__current");
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_labelReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, nameof (labelReference));
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<>4__this");
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, nameof (callback));
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__labelPaths_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<labelPaths>5__2");
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<>7__wrap2");
      LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__sceneLoad_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, "<sceneLoad>5__4");
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671411);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671412);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671413);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671414);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671415);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671416);
      LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr, 100671417);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _LoadLabelScenes_d__29(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._LoadLabelScenes_d__29>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93469, XrefRangeEnd = 93474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93474, XrefRangeEnd = 93545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93545, XrefRangeEnd = 93548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93548, XrefRangeEnd = 93553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._LoadLabelScenes_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AssetLabelReference labelReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_labelReference));
        return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_labelReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<UniTask> callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<UniTask>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<UniTask>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<IList<IResourceLocation>> _labelPaths_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__labelPaths_5__2);
        return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__labelPaths_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe IEnumerator<IResourceLocation> __7__wrap2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___7__wrap2));
        return num == System.IntPtr.Zero ? (IEnumerator<IResourceLocation>) null : Il2CppObjectPool.Get<IEnumerator<IResourceLocation>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<SceneInstance> _sceneLoad_5__4
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__sceneLoad_5__4);
        return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._LoadLabelScenes_d__29.NativeFieldInfoPtr__sceneLoad_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<RemoveScene>d__23")]
  public sealed class _RemoveScene_d__23 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_sceneInstance;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RemoveScene_d__23()
    {
      Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<RemoveScene>d__23");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr);
      LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, "<>1__state");
      LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, "<>t__builder");
      LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr_sceneInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, nameof (sceneInstance));
      LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, "<>u__1");
      LoadingManager._RemoveScene_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, 100671418);
      LoadingManager._RemoveScene_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr, 100671419);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 93571, RefRangeEnd = 93574, XrefRangeStart = 93553, XrefRangeEnd = 93571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._RemoveScene_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._RemoveScene_d__23.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RemoveScene_d__23(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RemoveScene_d__23()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._RemoveScene_d__23>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public SceneInstance sceneInstance
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr_sceneInstance);
        return new SceneInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr_sceneInstance), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SceneInstance>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask<SceneInstance>.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___u__1);
        return new UniTask<SceneInstance>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._RemoveScene_d__23.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<SwitchScenesCoroutine>d__28")]
  public sealed class _SwitchScenesCoroutine_d__28(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_needBaseScenes;
    private static readonly System.IntPtr NativeFieldInfoPtr_initialDifficulty;
    private static readonly System.IntPtr NativeFieldInfoPtr_preUnloadCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_label;
    private static readonly System.IntPtr NativeFieldInfoPtr_afterLoadCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadingScreenLocation_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadingScreenLoading_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__bootstrapperScene_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _SwitchScenesCoroutine_d__28()
    {
      Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<SwitchScenesCoroutine>d__28");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<>1__state");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<>2__current");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<>4__this");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_needBaseScenes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, nameof (needBaseScenes));
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_initialDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, nameof (initialDifficulty));
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_preUnloadCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, nameof (preUnloadCallback));
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, nameof (label));
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_afterLoadCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, nameof (afterLoadCallback));
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLocation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<loadingScreenLocation>5__2");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLoading_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<loadingScreenLoading>5__3");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__bootstrapperScene_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<bootstrapperScene>5__4");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, "<i>5__5");
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671420);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671421);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671422);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671423);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671424);
      LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr, 100671425);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SwitchScenesCoroutine_d__28(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._SwitchScenesCoroutine_d__28>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93574, XrefRangeEnd = 93672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93672, XrefRangeEnd = 93677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchScenesCoroutine_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool needBaseScenes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_needBaseScenes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_needBaseScenes)) = value;
      }
    }

    public unsafe DifficultyLevel initialDifficulty
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_initialDifficulty));
        return num == System.IntPtr.Zero ? (DifficultyLevel) null : Il2CppObjectPool.Get<DifficultyLevel>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_initialDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action preUnloadCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_preUnloadCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_preUnloadCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AssetLabelReference label
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_label));
        return num == System.IntPtr.Zero ? (AssetLabelReference) null : Il2CppObjectPool.Get<AssetLabelReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<UniTask> afterLoadCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_afterLoadCallback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<UniTask>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<UniTask>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr_afterLoadCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<IList<IResourceLocation>> _loadingScreenLocation_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLocation_5__2);
        return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLocation_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public AsyncOperationHandle<SceneInstance> _loadingScreenLoading_5__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLoading_5__3);
        return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__loadingScreenLoading_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Scene _bootstrapperScene_5__4
    {
      get
      {
        return *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__bootstrapperScene_5__4));
      }
      [param: In] set
      {
        *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__bootstrapperScene_5__4)) = value;
      }
    }

    public unsafe int _i_5__5
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__i_5__5));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchScenesCoroutine_d__28.NativeFieldInfoPtr__i_5__5)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.LoadingManager+<SwitchToMainMenu>d__26")]
  public sealed class _SwitchToMainMenu_d__26 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadingScreenLocation_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadingScreenLoading_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SwitchToMainMenu_d__26()
    {
      Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingManager>.NativeClassPtr, "<SwitchToMainMenu>d__26");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr);
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>1__state");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>t__builder");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>4__this");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLocation_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<loadingScreenLocation>5__2");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLoading_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<loadingScreenLoading>5__3");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>u__1");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>u__2");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>u__3");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<>u__4");
      LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, "<i>5__4");
      LoadingManager._SwitchToMainMenu_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, 100671426);
      LoadingManager._SwitchToMainMenu_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr, 100671427);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93677, XrefRangeEnd = 93854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchToMainMenu_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LoadingManager._SwitchToMainMenu_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SwitchToMainMenu_d__26(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SwitchToMainMenu_d__26()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingManager._SwitchToMainMenu_d__26>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LoadingManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (LoadingManager) null : Il2CppObjectPool.Get<LoadingManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public AsyncOperationHandle<IList<IResourceLocation>> _loadingScreenLocation_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLocation_5__2);
        return new AsyncOperationHandle<IList<IResourceLocation>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLocation_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<IResourceLocation>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public AsyncOperationHandle<SceneInstance> _loadingScreenLoading_5__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLoading_5__3);
        return new AsyncOperationHandle<SceneInstance>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__loadingScreenLoading_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<SceneInstance>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask<IList<IResourceLocation>>.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__1);
        return new UniTask<IList<IResourceLocation>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IList<IResourceLocation>>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IList<IResourceLocation>>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask<SceneInstance>.Awaiter __u__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__2);
        return new UniTask<SceneInstance>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<SceneInstance>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__3);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public Awaitable.Awaiter __u__4
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__4);
        return new Awaitable.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr___u__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _i_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__i_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoadingManager._SwitchToMainMenu_d__26.NativeFieldInfoPtr__i_5__4)) = value;
      }
    }
  }
}
