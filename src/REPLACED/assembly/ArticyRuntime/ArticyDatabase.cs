// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyDatabase
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyDatabase(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsImporting_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_loadedObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastMirroredCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__Auxiliary_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHierarchy;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLocalization;
  private static readonly System.IntPtr NativeFieldInfoPtr_mObjectNotifications;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRuleSetId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyAssetsUseResourcesFolder;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInternalProject;
  private static readonly System.IntPtr NativeFieldInfoPtr_mImportedAssets;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultGlobalVariables;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDefaultMethodProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_mMethodProviderMethodsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_sScriptFragments;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPackages;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedPackages;
  private static readonly System.IntPtr NativeFieldInfoPtr_mObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRepository;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTechnicalNameRepository;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLiveObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLiveRepository;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTechnicalNameLiveRepository;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceUpdateDictionaries;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsDatabaseAvailable_Public_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackage_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackage_Public_Static_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_UInt64_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_Static_TObject_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAllOfType_Public_Static_List_1_TObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneFrom_Public_Static_TObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_TObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_UInt64_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_String_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_TObject_String_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveClone_Public_Static_Void_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveClone_Public_Static_Void_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShutdownRuntimeDatabase_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearDatabase_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FilterObjects_Public_Static_IList_1_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FilterObjectsBasedOn_Public_Static_IList_1_ArticyObject_IList_1_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsObjectInLoadedPackages_Public_Static_Boolean_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadedPackages_Public_Static_get_IList_1_ArticyPackage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LoadedPackagesCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Objects_Public_Static_get_IList_1_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ScriptFragments_Public_Static_get_BaseScriptFragments_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultGlobalVariables_Public_Static_get_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultMethodProvider_Public_Static_get_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DefaultMethodProvider_Public_Static_set_Void_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MethodProviderRequired_Internal_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Project_Public_Static_get_ArticyProject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Localization_Public_Static_get_ArticyLocalizationManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProjectHierarchy_Public_Static_get_ArticyHierarchyManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ObjectNotifications_Public_Static_get_ArticyObjectNotificationManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsUnityPlaying_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyDatabaseFolder_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyDatabasePath_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyDatabaseAssetFileName_Public_Static_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Packages_Public_Static_get_IList_1_ArticyPackageDefinition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_ArticyDatabase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceUnsafe_Internal_Static_get_ArticyDatabase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsImporting_Internal_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsImporting_Internal_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RuleSetId_Internal_Static_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RuleSetId_Internal_Static_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyAssetsUseResourcesFolder_Internal_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyAssetsUseResourcesFolder_Internal_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalHierarchy_Private_get_ArticyHierarchyManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalFilterObjects_Private_IList_1_ArticyObject_IList_1_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeAsync_Public_Static_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSceneLoad_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsurePackages_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsurePackagesAsync_Private_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageByName_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageByNameAsync_Private_Task_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageById_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageByIdAsync_Private_Task_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackageByName_Private_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackageById_Private_Void_UInt64_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnloadPackageByDefinition_Private_Void_ArticyPackageDefinition_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageByDefinition_Private_Void_ArticyPackageDefinition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPackageByDefinitionAsync_Private_Task_ArticyPackageDefinition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyPackage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearRuntimeDatabase_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PackagePreloadState_Internal_get_Dictionary_2_UInt64_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FlagAllPackagesDirty_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalShutdownRuntimeDatabase_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalGetAllOfType_Private_List_1_TObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalRemoveAllClones_Private_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalRemoveClone_Private_Void_UInt64_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalCloneWithConsecutiveInstanceIdFrom_Private_ArticyObject_UInt64_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalCloneFrom_Private_ArticyObject_UInt64_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureDictionary_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MirrorObjectListToDictionary_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MirrorObjectListToRuntimeDictionary_Private_Static_Void_Dictionary_2_UInt64_Dictionary_2_UInt32_ArticyObject_Dictionary_2_String_List_1_ArticyObject_List_1_ArticyObject_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalProject_Private_get_ArticyProject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InternalProject_Private_set_Void_ArticyProject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalLocalization_Private_get_ArticyLocalizationManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Auxiliary_Private_Static_get_ArticyEditorAuxiliary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Auxiliary_Private_Static_set_Void_ArticyEditorAuxiliary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ImportedAssets_Private_get_HashSet_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ImportedAssets_Private_set_Void_HashSet_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAssetsNotImportedAnymore_Private_HashSet_1_String_IEnumerable_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPackage_Private_Void_UInt64_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetDatabase_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetDatabaseAfterImport_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetWithPackageDefinitions_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearManagerReferences_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReAssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignLocalizationManager_Private_Void_ArticyLocalizationManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignHierarchyManager_Private_Void_ArticyHierarchyManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignObjectsChildren_Internal_Void_Dictionary_2_UInt64_List_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

  static ArticyDatabase()
  {
    Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyDatabase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr);
    ArticyDatabase.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (Logger));
    ArticyDatabase.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (sInstance));
    ArticyDatabase.NativeFieldInfoPtr__IsImporting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<IsImporting>k__BackingField");
    ArticyDatabase.NativeFieldInfoPtr_loadedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (loadedObjects));
    ArticyDatabase.NativeFieldInfoPtr_lastMirroredCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (lastMirroredCount));
    ArticyDatabase.NativeFieldInfoPtr__Auxiliary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<Auxiliary>k__BackingField");
    ArticyDatabase.NativeFieldInfoPtr_mHierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mHierarchy));
    ArticyDatabase.NativeFieldInfoPtr_mLocalization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mLocalization));
    ArticyDatabase.NativeFieldInfoPtr_mObjectNotifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mObjectNotifications));
    ArticyDatabase.NativeFieldInfoPtr_mRuleSetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mRuleSetId));
    ArticyDatabase.NativeFieldInfoPtr_mArticyAssetsUseResourcesFolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mArticyAssetsUseResourcesFolder));
    ArticyDatabase.NativeFieldInfoPtr_mInternalProject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mInternalProject));
    ArticyDatabase.NativeFieldInfoPtr_mImportedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mImportedAssets));
    ArticyDatabase.NativeFieldInfoPtr_mDefaultGlobalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mDefaultGlobalVariables));
    ArticyDatabase.NativeFieldInfoPtr_mDefaultMethodProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mDefaultMethodProvider));
    ArticyDatabase.NativeFieldInfoPtr_mMethodProviderMethodsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mMethodProviderMethodsCount));
    ArticyDatabase.NativeFieldInfoPtr_sScriptFragments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (sScriptFragments));
    ArticyDatabase.NativeFieldInfoPtr_mPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mPackages));
    ArticyDatabase.NativeFieldInfoPtr_mLoadedPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mLoadedPackages));
    ArticyDatabase.NativeFieldInfoPtr_mObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mObjects));
    ArticyDatabase.NativeFieldInfoPtr_mRepository = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mRepository));
    ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameRepository = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mTechnicalNameRepository));
    ArticyDatabase.NativeFieldInfoPtr_mLiveObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mLiveObjects));
    ArticyDatabase.NativeFieldInfoPtr_mLiveRepository = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mLiveRepository));
    ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameLiveRepository = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (mTechnicalNameLiveRepository));
    ArticyDatabase.NativeFieldInfoPtr_forceUpdateDictionaries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, nameof (forceUpdateDictionaries));
    ArticyDatabase.NativeMethodInfoPtr_IsDatabaseAvailable_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663318 /*0x06000016*/);
    ArticyDatabase.NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663319 /*0x06000017*/);
    ArticyDatabase.NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663320 /*0x06000018*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackage_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663321 /*0x06000019*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackage_Public_Static_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663322 /*0x0600001A*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663323 /*0x0600001B*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663324 /*0x0600001C*/);
    ArticyDatabase.NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663325 /*0x0600001D*/);
    ArticyDatabase.NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663326 /*0x0600001E*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663327 /*0x0600001F*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663328 /*0x06000020*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663329 /*0x06000021*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663330 /*0x06000022*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663331 /*0x06000023*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663332 /*0x06000024*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663333 /*0x06000025*/);
    ArticyDatabase.NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663334 /*0x06000026*/);
    ArticyDatabase.NativeMethodInfoPtr_GetAllOfType_Public_Static_List_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663335 /*0x06000027*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663336 /*0x06000028*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663337 /*0x06000029*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_TObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663338 /*0x0600002A*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663339 /*0x0600002B*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663340 /*0x0600002C*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_TObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663341 /*0x0600002D*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_UInt64_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663342 /*0x0600002E*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663343 /*0x0600002F*/);
    ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_TObject_String_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663344 /*0x06000030*/);
    ArticyDatabase.NativeMethodInfoPtr_RemoveClone_Public_Static_Void_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663345 /*0x06000031*/);
    ArticyDatabase.NativeMethodInfoPtr_RemoveClone_Public_Static_Void_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663346 /*0x06000032*/);
    ArticyDatabase.NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663347 /*0x06000033*/);
    ArticyDatabase.NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663348 /*0x06000034*/);
    ArticyDatabase.NativeMethodInfoPtr_ShutdownRuntimeDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663349 /*0x06000035*/);
    ArticyDatabase.NativeMethodInfoPtr_ClearDatabase_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663350 /*0x06000036*/);
    ArticyDatabase.NativeMethodInfoPtr_FilterObjects_Public_Static_IList_1_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663351 /*0x06000037*/);
    ArticyDatabase.NativeMethodInfoPtr_FilterObjectsBasedOn_Public_Static_IList_1_ArticyObject_IList_1_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663352 /*0x06000038*/);
    ArticyDatabase.NativeMethodInfoPtr_IsObjectInLoadedPackages_Public_Static_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663353 /*0x06000039*/);
    ArticyDatabase.NativeMethodInfoPtr_get_LoadedPackages_Public_Static_get_IList_1_ArticyPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663354 /*0x0600003A*/);
    ArticyDatabase.NativeMethodInfoPtr_get_LoadedPackagesCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663355 /*0x0600003B*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Objects_Public_Static_get_IList_1_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663356 /*0x0600003C*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ScriptFragments_Public_Static_get_BaseScriptFragments_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663357 /*0x0600003D*/);
    ArticyDatabase.NativeMethodInfoPtr_get_DefaultGlobalVariables_Public_Static_get_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663358 /*0x0600003E*/);
    ArticyDatabase.NativeMethodInfoPtr_get_DefaultMethodProvider_Public_Static_get_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663359 /*0x0600003F*/);
    ArticyDatabase.NativeMethodInfoPtr_set_DefaultMethodProvider_Public_Static_set_Void_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663360 /*0x06000040*/);
    ArticyDatabase.NativeMethodInfoPtr_get_MethodProviderRequired_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663361 /*0x06000041*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Project_Public_Static_get_ArticyProject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663362 /*0x06000042*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Localization_Public_Static_get_ArticyLocalizationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663363 /*0x06000043*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ProjectHierarchy_Public_Static_get_ArticyHierarchyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663364 /*0x06000044*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ObjectNotifications_Public_Static_get_ArticyObjectNotificationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663365 /*0x06000045*/);
    ArticyDatabase.NativeMethodInfoPtr_get_IsUnityPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663366 /*0x06000046*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabaseFolder_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663367 /*0x06000047*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabasePath_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663368 /*0x06000048*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabaseAssetFileName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663369 /*0x06000049*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Packages_Public_Static_get_IList_1_ArticyPackageDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663370 /*0x0600004A*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Instance_Public_Static_get_ArticyDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663371 /*0x0600004B*/);
    ArticyDatabase.NativeMethodInfoPtr_get_InstanceUnsafe_Internal_Static_get_ArticyDatabase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663372 /*0x0600004C*/);
    ArticyDatabase.NativeMethodInfoPtr_get_IsImporting_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663373 /*0x0600004D*/);
    ArticyDatabase.NativeMethodInfoPtr_set_IsImporting_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663374 /*0x0600004E*/);
    ArticyDatabase.NativeMethodInfoPtr_get_RuleSetId_Internal_Static_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663375 /*0x0600004F*/);
    ArticyDatabase.NativeMethodInfoPtr_set_RuleSetId_Internal_Static_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663376 /*0x06000050*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ArticyAssetsUseResourcesFolder_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663377 /*0x06000051*/);
    ArticyDatabase.NativeMethodInfoPtr_set_ArticyAssetsUseResourcesFolder_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663378 /*0x06000052*/);
    ArticyDatabase.NativeMethodInfoPtr_get_InternalHierarchy_Private_get_ArticyHierarchyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663379 /*0x06000053*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalFilterObjects_Private_IList_1_ArticyObject_IList_1_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663380 /*0x06000054*/);
    ArticyDatabase.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663381 /*0x06000055*/);
    ArticyDatabase.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663382 /*0x06000056*/);
    ArticyDatabase.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663383 /*0x06000057*/);
    ArticyDatabase.NativeMethodInfoPtr_InitializeAsync_Public_Static_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663384 /*0x06000058*/);
    ArticyDatabase.NativeMethodInfoPtr_OnBeforeSceneLoad_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663385 /*0x06000059*/);
    ArticyDatabase.NativeMethodInfoPtr_EnsurePackages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663386 /*0x0600005A*/);
    ArticyDatabase.NativeMethodInfoPtr_EnsurePackagesAsync_Private_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663387 /*0x0600005B*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageByName_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663388 /*0x0600005C*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageByNameAsync_Private_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663389 /*0x0600005D*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageById_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663390 /*0x0600005E*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageByIdAsync_Private_Task_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663391 /*0x0600005F*/);
    ArticyDatabase.NativeMethodInfoPtr_UnloadPackageByName_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663392 /*0x06000060*/);
    ArticyDatabase.NativeMethodInfoPtr_UnloadPackageById_Private_Void_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663393 /*0x06000061*/);
    ArticyDatabase.NativeMethodInfoPtr_UnloadPackageByDefinition_Private_Void_ArticyPackageDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663394 /*0x06000062*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageByDefinition_Private_Void_ArticyPackageDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663395 /*0x06000063*/);
    ArticyDatabase.NativeMethodInfoPtr_LoadPackageByDefinitionAsync_Private_Task_ArticyPackageDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663396 /*0x06000064*/);
    ArticyDatabase.NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663397 /*0x06000065*/);
    ArticyDatabase.NativeMethodInfoPtr_ClearRuntimeDatabase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663398 /*0x06000066*/);
    ArticyDatabase.NativeMethodInfoPtr_get_PackagePreloadState_Internal_get_Dictionary_2_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663399 /*0x06000067*/);
    ArticyDatabase.NativeMethodInfoPtr_FlagAllPackagesDirty_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663400 /*0x06000068*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalShutdownRuntimeDatabase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663401 /*0x06000069*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663402 /*0x0600006A*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663403 /*0x0600006B*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663404 /*0x0600006C*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663405 /*0x0600006D*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663406 /*0x0600006E*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663407 /*0x0600006F*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663408 /*0x06000070*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalGetAllOfType_Private_List_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663409 /*0x06000071*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalRemoveAllClones_Private_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663410 /*0x06000072*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalRemoveClone_Private_Void_UInt64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663411 /*0x06000073*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalCloneWithConsecutiveInstanceIdFrom_Private_ArticyObject_UInt64_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663412 /*0x06000074*/);
    ArticyDatabase.NativeMethodInfoPtr_InternalCloneFrom_Private_ArticyObject_UInt64_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663413 /*0x06000075*/);
    ArticyDatabase.NativeMethodInfoPtr_EnsureDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663414 /*0x06000076*/);
    ArticyDatabase.NativeMethodInfoPtr_MirrorObjectListToDictionary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663415 /*0x06000077*/);
    ArticyDatabase.NativeMethodInfoPtr_MirrorObjectListToRuntimeDictionary_Private_Static_Void_Dictionary_2_UInt64_Dictionary_2_UInt32_ArticyObject_Dictionary_2_String_List_1_ArticyObject_List_1_ArticyObject_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663416 /*0x06000078*/);
    ArticyDatabase.NativeMethodInfoPtr_get_InternalProject_Private_get_ArticyProject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663417 /*0x06000079*/);
    ArticyDatabase.NativeMethodInfoPtr_set_InternalProject_Private_set_Void_ArticyProject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663418 /*0x0600007A*/);
    ArticyDatabase.NativeMethodInfoPtr_get_InternalLocalization_Private_get_ArticyLocalizationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663419 /*0x0600007B*/);
    ArticyDatabase.NativeMethodInfoPtr_get_Auxiliary_Private_Static_get_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663420 /*0x0600007C*/);
    ArticyDatabase.NativeMethodInfoPtr_set_Auxiliary_Private_Static_set_Void_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663421 /*0x0600007D*/);
    ArticyDatabase.NativeMethodInfoPtr_get_ImportedAssets_Private_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663422 /*0x0600007E*/);
    ArticyDatabase.NativeMethodInfoPtr_set_ImportedAssets_Private_set_Void_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663423 /*0x0600007F*/);
    ArticyDatabase.NativeMethodInfoPtr_GetAssetsNotImportedAnymore_Private_HashSet_1_String_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663424 /*0x06000080*/);
    ArticyDatabase.NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663425 /*0x06000081*/);
    ArticyDatabase.NativeMethodInfoPtr_AddPackage_Private_Void_UInt64_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663426 /*0x06000082*/);
    ArticyDatabase.NativeMethodInfoPtr_ResetDatabase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663427 /*0x06000083*/);
    ArticyDatabase.NativeMethodInfoPtr_ResetDatabaseAfterImport_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663428 /*0x06000084*/);
    ArticyDatabase.NativeMethodInfoPtr_ResetWithPackageDefinitions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663429 /*0x06000085*/);
    ArticyDatabase.NativeMethodInfoPtr_ClearManagerReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663430 /*0x06000086*/);
    ArticyDatabase.NativeMethodInfoPtr_AssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663431 /*0x06000087*/);
    ArticyDatabase.NativeMethodInfoPtr_ReAssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663432 /*0x06000088*/);
    ArticyDatabase.NativeMethodInfoPtr_AssignLocalizationManager_Private_Void_ArticyLocalizationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663433 /*0x06000089*/);
    ArticyDatabase.NativeMethodInfoPtr_AssignHierarchyManager_Private_Void_ArticyHierarchyManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663434 /*0x0600008A*/);
    ArticyDatabase.NativeMethodInfoPtr_AssignObjectsChildren_Internal_Void_Dictionary_2_UInt64_List_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663435 /*0x0600008B*/);
    ArticyDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663436 /*0x0600008C*/);
    ArticyDatabase.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663437 /*0x0600008D*/);
    ArticyDatabase.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, 100663438 /*0x0600008E*/);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 985038, RefRangeEnd = 985042, XrefRangeStart = 985030, XrefRangeEnd = 985038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsDatabaseAvailable()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_IsDatabaseAvailable_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985042, XrefRangeEnd = 985058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsObjectAvailable(ulong aObjectId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aObjectId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985058, XrefRangeEnd = 985072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsObjectAvailable(string aTechnicalName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_IsObjectAvailable_Public_Static_Boolean_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985072, XrefRangeEnd = 985078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadPackage(string aName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackage_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985078, XrefRangeEnd = 985084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadPackage(ulong aId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackage_Public_Static_Void_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985084, XrefRangeEnd = 985092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task LoadPackageAsync(string aName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985092, XrefRangeEnd = 985100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task LoadPackageAsync(ulong aId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageAsync_Public_Static_Task_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985100, XrefRangeEnd = 985113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadPackage(string aName, bool aUseQuickUnload = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aUseQuickUnload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_String_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985113, XrefRangeEnd = 985119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UnloadPackage(ulong aId, bool aUseQuickUnload = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aUseQuickUnload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_UnloadPackage_Public_Static_Void_UInt64_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 985125, RefRangeEnd = 985130, XrefRangeStart = 985119, XrefRangeEnd = 985125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject GetObject(string aTechnicalName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985130, XrefRangeEnd = 985139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject GetObject<TObject>(string aTechnicalName) where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_GetObject_Public_Static_TObject_String_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 985144, RefRangeEnd = 985146, XrefRangeStart = 985139, XrefRangeEnd = 985144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject GetObject(string aTechnicalName, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985146, XrefRangeEnd = 985155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject GetObject<TObject>(string aTechnicalName, uint aInstanceId) where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_GetObject_Public_Static_TObject_String_UInt32_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 985161, RefRangeEnd = 985184, XrefRangeStart = 985155, XrefRangeEnd = 985161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject GetObject(ulong aObjectId, uint aInstanceId = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_ArticyObject_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 985200, RefRangeEnd = 985204, XrefRangeStart = 985184, XrefRangeEnd = 985200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject GetObject<TObject>(ulong aObjectId, uint aInstanceId = 0) where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_GetObject_Public_Static_TObject_UInt64_UInt32_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985204, XrefRangeEnd = 985240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<ArticyObject> GetObjects(string aTechnicalName, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985240, XrefRangeEnd = 985258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<ArticyObject> GetObjects(string aTechnicalName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetObjects_Public_Static_List_1_ArticyObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 985272, RefRangeEnd = 985273, XrefRangeStart = 985258, XrefRangeEnd = 985272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<TObject> GetAllOfType<TObject>()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_GetAllOfType_Public_Static_List_1_TObject_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<TObject>) null : Il2CppObjectPool.Get<List<TObject>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 985284, RefRangeEnd = 985285, XrefRangeStart = 985273, XrefRangeEnd = 985284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneFrom(ulong aObjectId, uint aDesiredInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aDesiredInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 985303, RefRangeEnd = 985304, XrefRangeStart = 985285, XrefRangeEnd = 985303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneFrom(string aTechnicalName, uint aDesiredInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aDesiredInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_ArticyObject_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985304, XrefRangeEnd = 985311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject CloneFrom<TObject>(string aTechnicalName, uint aDesiredInstanceId) where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aDesiredInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_CloneFrom_Public_Static_TObject_String_UInt32_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 985321, RefRangeEnd = 985324, XrefRangeStart = 985311, XrefRangeEnd = 985321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneOrGetFrom(ulong aObjectId, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 985332, RefRangeEnd = 985334, XrefRangeStart = 985324, XrefRangeEnd = 985332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneOrGetFrom(string aTechnicalName, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_ArticyObject_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985334, XrefRangeEnd = 985341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject CloneOrGetFrom<TObject>(string aTechnicalName, uint aInstanceId) where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_CloneOrGetFrom_Public_Static_TObject_String_UInt32_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 985358, RefRangeEnd = 985360, XrefRangeStart = 985341, XrefRangeEnd = 985358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneWithConsecutiveInstanceIdFrom(
    ulong aObjectId,
    out uint aAssignedInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aAssignedInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_UInt64_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 985368, RefRangeEnd = 985369, XrefRangeStart = 985360, XrefRangeEnd = 985368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyObject CloneWithConsecutiveInstanceIdFrom(
    string aTechnicalName,
    out uint aAssignedInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aAssignedInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_ArticyObject_String_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985369, XrefRangeEnd = 985382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject CloneWithConsecutiveInstanceIdFrom<TObject>(
    string aTechnicalName,
    out uint aAssignedInstanceId)
    where TObject : ArticyObject
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aAssignedInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_CloneWithConsecutiveInstanceIdFrom_Public_Static_TObject_String_byref_UInt32_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 985409, RefRangeEnd = 985410, XrefRangeStart = 985382, XrefRangeEnd = 985409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveClone(ulong aObjectId, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aObjectId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_RemoveClone_Public_Static_Void_UInt64_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985410, XrefRangeEnd = 985418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveClone(string aTechnicalName, uint aInstanceId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_RemoveClone_Public_Static_Void_String_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985418, XrefRangeEnd = 985436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveAllClones(ulong aObjectId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aObjectId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985436, XrefRangeEnd = 985453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RemoveAllClones(string aTechnicalName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_RemoveAllClones_Public_Static_Void_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985453, XrefRangeEnd = 985475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ShutdownRuntimeDatabase()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ShutdownRuntimeDatabase_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985475, XrefRangeEnd = 985483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearDatabase()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ClearDatabase_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985483, XrefRangeEnd = 985489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IList<ArticyObject> FilterObjects(string aFilter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFilter)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_FilterObjects_Public_Static_IList_1_ArticyObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<ArticyObject>) null : Il2CppObjectPool.Get<IList<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985489, XrefRangeEnd = 985495, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IList<ArticyObject> FilterObjectsBasedOn(
    IList<ArticyObject> aLastFiltered,
    string aFilter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLastFiltered);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_FilterObjectsBasedOn_Public_Static_IList_1_ArticyObject_IList_1_ArticyObject_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<ArticyObject>) null : Il2CppObjectPool.Get<IList<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985495, XrefRangeEnd = 985541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsObjectInLoadedPackages(ArticyObject aObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_IsObjectInLoadedPackages_Public_Static_Boolean_ArticyObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe IList<ArticyPackage> LoadedPackages
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 985552, RefRangeEnd = 985554, XrefRangeStart = 985541, XrefRangeEnd = 985552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_LoadedPackages_Public_Static_get_IList_1_ArticyPackage_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<ArticyPackage>) null : Il2CppObjectPool.Get<IList<ArticyPackage>>(num3);
    }
  }

  public static unsafe int LoadedPackagesCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985554, XrefRangeEnd = 985562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_LoadedPackagesCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe IList<ArticyObject> Objects
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 985578, RefRangeEnd = 985580, XrefRangeStart = 985562, XrefRangeEnd = 985578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Objects_Public_Static_get_IList_1_ArticyObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<ArticyObject>) null : Il2CppObjectPool.Get<IList<ArticyObject>>(num3);
    }
  }

  public static unsafe BaseScriptFragments ScriptFragments
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 985621, RefRangeEnd = 985625, XrefRangeStart = 985580, XrefRangeEnd = 985621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ScriptFragments_Public_Static_get_BaseScriptFragments_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (BaseScriptFragments) null : Il2CppObjectPool.Get<BaseScriptFragments>(num3);
    }
  }

  public static unsafe BaseGlobalVariables DefaultGlobalVariables
  {
    [CallerCount(23), CachedScanResults(RefRangeStart = 985646, RefRangeEnd = 985669, XrefRangeStart = 985625, XrefRangeEnd = 985646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_DefaultGlobalVariables_Public_Static_get_BaseGlobalVariables_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num3);
    }
  }

  public static unsafe IBaseScriptMethodProvider DefaultMethodProvider
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 985673, RefRangeEnd = 985675, XrefRangeStart = 985669, XrefRangeEnd = 985673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_DefaultMethodProvider_Public_Static_get_IBaseScriptMethodProvider_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985675, XrefRangeEnd = 985679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_DefaultMethodProvider_Public_Static_set_Void_IBaseScriptMethodProvider_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe bool MethodProviderRequired
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 985708, RefRangeEnd = 985711, XrefRangeStart = 985679, XrefRangeEnd = 985708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_MethodProviderRequired_Internal_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe ArticyProject Project
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 985715, RefRangeEnd = 985716, XrefRangeStart = 985711, XrefRangeEnd = 985715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Project_Public_Static_get_ArticyProject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyProject) null : Il2CppObjectPool.Get<ArticyProject>(num3);
    }
  }

  public static unsafe ArticyLocalizationManager Localization
  {
    [CallerCount(41), CachedScanResults(RefRangeStart = 985721, RefRangeEnd = 985762, XrefRangeStart = 985716, XrefRangeEnd = 985721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Localization_Public_Static_get_ArticyLocalizationManager_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num3);
    }
  }

  public static unsafe ArticyHierarchyManager ProjectHierarchy
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985762, XrefRangeEnd = 985766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ProjectHierarchy_Public_Static_get_ArticyHierarchyManager_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyHierarchyManager) null : Il2CppObjectPool.Get<ArticyHierarchyManager>(num3);
    }
  }

  public static unsafe ArticyObjectNotificationManager ObjectNotifications
  {
    [CallerCount(129), CachedScanResults(RefRangeStart = 985770, RefRangeEnd = 985899, XrefRangeStart = 985766, XrefRangeEnd = 985770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ObjectNotifications_Public_Static_get_ArticyObjectNotificationManager_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObjectNotificationManager) null : Il2CppObjectPool.Get<ArticyObjectNotificationManager>(num3);
    }
  }

  public static unsafe bool IsUnityPlaying
  {
    [CallerCount(41), CachedScanResults(RefRangeStart = 985916, RefRangeEnd = 985957, XrefRangeStart = 985899, XrefRangeEnd = 985916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_IsUnityPlaying_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe string ArticyDatabaseFolder
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985957, XrefRangeEnd = 985962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabaseFolder_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string ArticyDatabasePath
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 985975, RefRangeEnd = 985978, XrefRangeStart = 985962, XrefRangeEnd = 985975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabasePath_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe string ArticyDatabaseAssetFileName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 985984, RefRangeEnd = 985987, XrefRangeStart = 985978, XrefRangeEnd = 985984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ArticyDatabaseAssetFileName_Public_Static_get_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe IList<ArticyPackageDefinition> Packages
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 985995, RefRangeEnd = 986002, XrefRangeStart = 985987, XrefRangeEnd = 985995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Packages_Public_Static_get_IList_1_ArticyPackageDefinition_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<ArticyPackageDefinition>) null : Il2CppObjectPool.Get<IList<ArticyPackageDefinition>>(num3);
    }
  }

  public static unsafe ArticyDatabase Instance
  {
    [CallerCount(86), CachedScanResults(RefRangeStart = 986039, RefRangeEnd = 986125, XrefRangeStart = 986002, XrefRangeEnd = 986039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Instance_Public_Static_get_ArticyDatabase_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num3);
    }
  }

  public static unsafe ArticyDatabase InstanceUnsafe
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986125, XrefRangeEnd = 986129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_InstanceUnsafe_Internal_Static_get_ArticyDatabase_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num3);
    }
  }

  public static unsafe bool IsImporting
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986129, XrefRangeEnd = 986133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_IsImporting_Internal_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986133, XrefRangeEnd = 986137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_IsImporting_Internal_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe ulong RuleSetId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986137, XrefRangeEnd = 986141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_RuleSetId_Internal_Static_get_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986141, XrefRangeEnd = 986145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_RuleSetId_Internal_Static_set_Void_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe bool ArticyAssetsUseResourcesFolder
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 986149, RefRangeEnd = 986152, XrefRangeStart = 986145, XrefRangeEnd = 986149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ArticyAssetsUseResourcesFolder_Internal_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986152, XrefRangeEnd = 986156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_ArticyAssetsUseResourcesFolder_Internal_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyHierarchyManager InternalHierarchy
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_InternalHierarchy_Private_get_ArticyHierarchyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyHierarchyManager) null : Il2CppObjectPool.Get<ArticyHierarchyManager>(num3);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 986236, RefRangeEnd = 986238, XrefRangeStart = 986156, XrefRangeEnd = 986236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IList<ArticyObject> InternalFilterObjects(
    IList<ArticyObject> aUseList,
    string aFilter)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aUseList);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFilter);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalFilterObjects_Private_IList_1_ArticyObject_IList_1_ArticyObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<ArticyObject>) null : Il2CppObjectPool.Get<IList<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986238, XrefRangeEnd = 986253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986253, XrefRangeEnd = 986261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986261, XrefRangeEnd = 986262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986262, XrefRangeEnd = 986270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Task InitializeAsync()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InitializeAsync_Public_Static_Task_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986270, XrefRangeEnd = 986304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnBeforeSceneLoad()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_OnBeforeSceneLoad_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(33)]
  [CachedScanResults(RefRangeStart = 986355, RefRangeEnd = 986388, XrefRangeStart = 986304, XrefRangeEnd = 986355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsurePackages()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_EnsurePackages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986388, XrefRangeEnd = 986396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task EnsurePackagesAsync()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_EnsurePackagesAsync_Private_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986436, RefRangeEnd = 986437, XrefRangeStart = 986396, XrefRangeEnd = 986436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadPackageByName(string aName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageByName_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986437, XrefRangeEnd = 986445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task LoadPackageByNameAsync(string aName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageByNameAsync_Private_Task_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986483, RefRangeEnd = 986484, XrefRangeStart = 986445, XrefRangeEnd = 986483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadPackageById(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageById_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986484, XrefRangeEnd = 986492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task LoadPackageByIdAsync(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageByIdAsync_Private_Task_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986532, RefRangeEnd = 986533, XrefRangeStart = 986492, XrefRangeEnd = 986532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnloadPackageByName(string aName, bool aUseQuickUnload = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aUseQuickUnload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_UnloadPackageByName_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986571, RefRangeEnd = 986572, XrefRangeStart = 986533, XrefRangeEnd = 986571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnloadPackageById(ulong aId, bool aUseQuickUnload = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aUseQuickUnload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_UnloadPackageById_Private_Void_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 986686, RefRangeEnd = 986690, XrefRangeStart = 986572, XrefRangeEnd = 986686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnloadPackageByDefinition(
    ArticyPackageDefinition aDefinition,
    bool aUseQuickUnload)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aDefinition);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aUseQuickUnload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_UnloadPackageByDefinition_Private_Void_ArticyPackageDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 986711, RefRangeEnd = 986716, XrefRangeStart = 986690, XrefRangeEnd = 986711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadPackageByDefinition(ArticyPackageDefinition aDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aDefinition)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageByDefinition_Private_Void_ArticyPackageDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 986724, RefRangeEnd = 986728, XrefRangeStart = 986716, XrefRangeEnd = 986724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task LoadPackageByDefinitionAsync(ArticyPackageDefinition aDefinition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aDefinition)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_LoadPackageByDefinitionAsync_Private_Task_ArticyPackageDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986812, RefRangeEnd = 986813, XrefRangeStart = 986728, XrefRangeEnd = 986812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessDataFromPackage(ArticyPackage aPackage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPackage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 986823, RefRangeEnd = 986825, XrefRangeStart = 986813, XrefRangeEnd = 986823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearRuntimeDatabase()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ClearRuntimeDatabase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<ulong, bool> PackagePreloadState
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986825, XrefRangeEnd = 986853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_PackagePreloadState_Internal_get_Dictionary_2_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<ulong, bool>) null : Il2CppObjectPool.Get<Dictionary<ulong, bool>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986853, XrefRangeEnd = 986889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FlagAllPackagesDirty()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_FlagAllPackagesDirty_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986889, XrefRangeEnd = 986894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalShutdownRuntimeDatabase()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalShutdownRuntimeDatabase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986894, XrefRangeEnd = 986906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InternalIsAvailable(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986906, XrefRangeEnd = 986916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InternalIsAvailable(string aTechnicalName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalIsAvailable_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 986926, RefRangeEnd = 986933, XrefRangeStart = 986916, XrefRangeEnd = 986926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject InternalGetObject(ulong aId, uint aInstanceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 986946, RefRangeEnd = 986955, XrefRangeStart = 986933, XrefRangeEnd = 986946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject InternalGetObject(string aTechnicalName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 986956, RefRangeEnd = 986957, XrefRangeStart = 986955, XrefRangeEnd = 986956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject InternalGetObject(string aTechnicalName, uint aInstanceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalGetObject_Private_ArticyObject_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986957, XrefRangeEnd = 986984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyObject> InternalGetObjects(string aTechnicalName, uint aInstanceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986984, XrefRangeEnd = 986998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<ArticyObject> InternalGetObjects(string aTechnicalName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aTechnicalName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalGetObjects_Private_List_1_ArticyObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 986998, XrefRangeEnd = 987007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<TObject> InternalGetAllOfType<TObject>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.MethodInfoStoreGeneric_InternalGetAllOfType_Private_List_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<TObject>) null : Il2CppObjectPool.Get<List<TObject>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 987047, RefRangeEnd = 987049, XrefRangeStart = 987007, XrefRangeEnd = 987047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalRemoveAllClones(ulong aBaseObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aBaseObject
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalRemoveAllClones_Private_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987049, XrefRangeEnd = 987067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalRemoveClone(ulong aBaseObject, uint aInstanceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aBaseObject;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInstanceId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalRemoveClone_Private_Void_UInt64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 987079, RefRangeEnd = 987080, XrefRangeStart = 987067, XrefRangeEnd = 987079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject InternalCloneWithConsecutiveInstanceIdFrom(
    ulong aID,
    out uint aAssignedInstanceId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref aAssignedInstanceId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalCloneWithConsecutiveInstanceIdFrom_Private_ArticyObject_UInt64_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 987094, RefRangeEnd = 987097, XrefRangeStart = 987080, XrefRangeEnd = 987094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject InternalCloneFrom(
    ulong aId,
    uint aDesiredInstanceId,
    bool aReturnIfExisting)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aDesiredInstanceId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aReturnIfExisting;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_InternalCloneFrom_Private_ArticyObject_UInt64_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 987102, RefRangeEnd = 987104, XrefRangeStart = 987097, XrefRangeEnd = 987102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsureDictionary()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_EnsureDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 987153, RefRangeEnd = 987154, XrefRangeStart = 987104, XrefRangeEnd = 987153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MirrorObjectListToDictionary()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_MirrorObjectListToDictionary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 987216, RefRangeEnd = 987217, XrefRangeStart = 987154, XrefRangeEnd = 987216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void MirrorObjectListToRuntimeDictionary(
    Dictionary<ulong, Dictionary<uint, ArticyObject>> aRepository,
    Dictionary<string, List<ArticyObject>> aTechnicalNameRepository,
    List<ArticyObject> aObjects,
    ref bool aForce)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRepository);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTechnicalNameRepository);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObjects);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref aForce;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_MirrorObjectListToRuntimeDictionary_Private_Static_Void_Dictionary_2_UInt64_Dictionary_2_UInt32_ArticyObject_Dictionary_2_String_List_1_ArticyObject_List_1_ArticyObject_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyProject InternalProject
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_InternalProject_Private_get_ArticyProject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyProject) null : Il2CppObjectPool.Get<ArticyProject>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_InternalProject_Private_set_Void_ArticyProject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyLocalizationManager InternalLocalization
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987217, XrefRangeEnd = 987218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_InternalLocalization_Private_get_ArticyLocalizationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num3);
    }
  }

  public static unsafe ArticyEditorAuxiliary Auxiliary
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987218, XrefRangeEnd = 987222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_Auxiliary_Private_Static_get_ArticyEditorAuxiliary_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987222, XrefRangeEnd = 987226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_Auxiliary_Private_Static_set_Void_ArticyEditorAuxiliary_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe HashSet<string> ImportedAssets
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 987233, RefRangeEnd = 987235, XrefRangeStart = 987226, XrefRangeEnd = 987233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_get_ImportedAssets_Private_get_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987235, XrefRangeEnd = 987238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_set_ImportedAssets_Private_set_Void_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987238, XrefRangeEnd = 987249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HashSet<string> GetAssetsNotImportedAnymore(IEnumerable<string> aNewAssets)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewAssets)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_GetAssetsNotImportedAnymore_Private_HashSet_1_String_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987249, XrefRangeEnd = 987265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddObject(ArticyObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AddObject_Internal_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987265, XrefRangeEnd = 987276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPackage(
    ulong aId,
    string aPackageName,
    string aPackagePath,
    bool aPreload)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPackageName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPackagePath);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aPreload;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AddPackage_Private_Void_UInt64_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 987291, RefRangeEnd = 987293, XrefRangeStart = 987276, XrefRangeEnd = 987291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetDatabase()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ResetDatabase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987293, XrefRangeEnd = 987310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetDatabaseAfterImport()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ResetDatabaseAfterImport_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987310, XrefRangeEnd = 987318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetWithPackageDefinitions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ResetWithPackageDefinitions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearManagerReferences()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ClearManagerReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987318, XrefRangeEnd = 987343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignDefaultGlobalVariables(BaseGlobalVariables aStorage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ReAssignDefaultGlobalVariables(BaseGlobalVariables aStorage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_ReAssignDefaultGlobalVariables_Private_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987343, XrefRangeEnd = 987363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignLocalizationManager(ArticyLocalizationManager aManager)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aManager)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AssignLocalizationManager_Private_Void_ArticyLocalizationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987363, XrefRangeEnd = 987383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignHierarchyManager(ArticyHierarchyManager aManager)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aManager)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AssignHierarchyManager_Private_Void_ArticyHierarchyManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987383, XrefRangeEnd = 987475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignObjectsChildren(Dictionary<ulong, List<ulong>> parentChildrenMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentChildrenMap)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_AssignObjectsChildren_Internal_Void_Dictionary_2_UInt64_List_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987475, XrefRangeEnd = 987526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyDatabase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987526, XrefRangeEnd = 987532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ArticyDatabase sInstance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.NativeFieldInfoPtr_sInstance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool _IsImporting_k__BackingField
  {
    get
    {
      bool importingKBackingField;
      IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.NativeFieldInfoPtr__IsImporting_k__BackingField, (void*) &importingKBackingField);
      return importingKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.NativeFieldInfoPtr__IsImporting_k__BackingField, (void*) &value);
    }
  }

  public unsafe HashSet<ulong> loadedObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_loadedObjects));
      return num == System.IntPtr.Zero ? (HashSet<ulong>) null : Il2CppObjectPool.Get<HashSet<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_loadedObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int lastMirroredCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_lastMirroredCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_lastMirroredCount)) = value;
    }
  }

  public static unsafe ArticyEditorAuxiliary _Auxiliary_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyHierarchyManager mHierarchy
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mHierarchy));
      return num == System.IntPtr.Zero ? (ArticyHierarchyManager) null : Il2CppObjectPool.Get<ArticyHierarchyManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mHierarchy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyLocalizationManager mLocalization
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLocalization));
      return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLocalization), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyObjectNotificationManager mObjectNotifications
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mObjectNotifications));
      return num == System.IntPtr.Zero ? (ArticyObjectNotificationManager) null : Il2CppObjectPool.Get<ArticyObjectNotificationManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mObjectNotifications), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong mRuleSetId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mRuleSetId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mRuleSetId)) = value;
    }
  }

  public unsafe bool mArticyAssetsUseResourcesFolder
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mArticyAssetsUseResourcesFolder));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mArticyAssetsUseResourcesFolder)) = value;
    }
  }

  public unsafe ArticyProject mInternalProject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mInternalProject));
      return num == System.IntPtr.Zero ? (ArticyProject) null : Il2CppObjectPool.Get<ArticyProject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mInternalProject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mImportedAssets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mImportedAssets));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mImportedAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BaseGlobalVariables mDefaultGlobalVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mDefaultGlobalVariables));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mDefaultGlobalVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IBaseScriptMethodProvider mDefaultMethodProvider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mDefaultMethodProvider));
      return num == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mDefaultMethodProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int mMethodProviderMethodsCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mMethodProviderMethodsCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mMethodProviderMethodsCount)) = value;
    }
  }

  public static unsafe BaseScriptFragments sScriptFragments
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.NativeFieldInfoPtr_sScriptFragments, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (BaseScriptFragments) null : Il2CppObjectPool.Get<BaseScriptFragments>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.NativeFieldInfoPtr_sScriptFragments, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyPackageDefinition> mPackages
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mPackages));
      return num == System.IntPtr.Zero ? (List<ArticyPackageDefinition>) null : Il2CppObjectPool.Get<List<ArticyPackageDefinition>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mPackages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ArticyPackage, Il2CppSystem.Object> mLoadedPackages
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLoadedPackages));
      return num == System.IntPtr.Zero ? (Dictionary<ArticyPackage, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<ArticyPackage, Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLoadedPackages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyObject> mObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mObjects));
      return num == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, ArticyObject> mRepository
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mRepository));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, ArticyObject>) null : Il2CppObjectPool.Get<Dictionary<ulong, ArticyObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mRepository), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, List<ArticyObject>> mTechnicalNameRepository
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameRepository));
      return num == System.IntPtr.Zero ? (Dictionary<string, List<ArticyObject>>) null : Il2CppObjectPool.Get<Dictionary<string, List<ArticyObject>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameRepository), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyObject> mLiveObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLiveObjects));
      return num == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLiveObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, Dictionary<uint, ArticyObject>> mLiveRepository
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLiveRepository));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, Dictionary<uint, ArticyObject>>) null : Il2CppObjectPool.Get<Dictionary<ulong, Dictionary<uint, ArticyObject>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mLiveRepository), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, List<ArticyObject>> mTechnicalNameLiveRepository
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameLiveRepository));
      return num == System.IntPtr.Zero ? (Dictionary<string, List<ArticyObject>>) null : Il2CppObjectPool.Get<Dictionary<string, List<ArticyObject>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_mTechnicalNameLiveRepository), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool forceUpdateDictionaries
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_forceUpdateDictionaries));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.NativeFieldInfoPtr_forceUpdateDictionaries)) = value;
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__108_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__108_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_PackagePreloadState_b__108_0_Internal_UInt64_ArticyPackageDefinition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__get_PackagePreloadState_b__108_1_Internal_Boolean_ArticyPackageDefinition_0;

    static __c()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr);
      ArticyDatabase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, "<>9");
      ArticyDatabase.__c.NativeFieldInfoPtr___9__108_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, "<>9__108_0");
      ArticyDatabase.__c.NativeFieldInfoPtr___9__108_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, "<>9__108_1");
      ArticyDatabase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, 100663441 /*0x06000091*/);
      ArticyDatabase.__c.NativeMethodInfoPtr__get_PackagePreloadState_b__108_0_Internal_UInt64_ArticyPackageDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, 100663442 /*0x06000092*/);
      ArticyDatabase.__c.NativeMethodInfoPtr__get_PackagePreloadState_b__108_1_Internal_Boolean_ArticyPackageDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr, 100663443 /*0x06000093*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe ulong _get_PackagePreloadState_b__108_0(ArticyPackageDefinition aPackageDef)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPackageDef)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c.NativeMethodInfoPtr__get_PackagePreloadState_b__108_0_Internal_UInt64_ArticyPackageDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _get_PackagePreloadState_b__108_1(ArticyPackageDefinition aPackageDef)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPackageDef)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c.NativeMethodInfoPtr__get_PackagePreloadState_b__108_1_Internal_Boolean_ArticyPackageDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe ArticyDatabase.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ArticyDatabase.__c) null : Il2CppObjectPool.Get<ArticyDatabase.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ArticyPackageDefinition, ulong> __9__108_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.__c.NativeFieldInfoPtr___9__108_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyPackageDefinition, ulong>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyPackageDefinition, ulong>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.__c.NativeFieldInfoPtr___9__108_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<ArticyPackageDefinition, bool> __9__108_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyDatabase.__c.NativeFieldInfoPtr___9__108_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyPackageDefinition, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyPackageDefinition, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyDatabase.__c.NativeFieldInfoPtr___9__108_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c__DisplayClass101_0")]
  public sealed class __c__DisplayClass101_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aDefinition;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnloadPackageByDefinition_b__0_Internal_Boolean_KeyValuePair_2_ArticyPackage_Object_0;

    static __c__DisplayClass101_0()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c__DisplayClass101_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr);
      ArticyDatabase.__c__DisplayClass101_0.NativeFieldInfoPtr_aDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr, nameof (aDefinition));
      ArticyDatabase.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr, 100663444 /*0x06000094*/);
      ArticyDatabase.__c__DisplayClass101_0.NativeMethodInfoPtr__UnloadPackageByDefinition_b__0_Internal_Boolean_KeyValuePair_2_ArticyPackage_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr, 100663445 /*0x06000095*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass101_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass101_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984598, XrefRangeEnd = 984608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnloadPackageByDefinition_b__0(KeyValuePair<ArticyPackage, Il2CppSystem.Object> e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) e))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass101_0.NativeMethodInfoPtr__UnloadPackageByDefinition_b__0_Internal_Boolean_KeyValuePair_2_ArticyPackage_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ArticyPackageDefinition aDefinition
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass101_0.NativeFieldInfoPtr_aDefinition));
        return num == System.IntPtr.Zero ? (ArticyPackageDefinition) null : Il2CppObjectPool.Get<ArticyPackageDefinition>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass101_0.NativeFieldInfoPtr_aDefinition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c__DisplayClass101_1")]
  public sealed class __c__DisplayClass101_1(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_instanceList;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UnloadPackageByDefinition_b__1_Internal_Boolean_ArticyObject_0;

    static __c__DisplayClass101_1()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c__DisplayClass101_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr);
      ArticyDatabase.__c__DisplayClass101_1.NativeFieldInfoPtr_instanceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr, nameof (instanceList));
      ArticyDatabase.__c__DisplayClass101_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr, 100663446 /*0x06000096*/);
      ArticyDatabase.__c__DisplayClass101_1.NativeMethodInfoPtr__UnloadPackageByDefinition_b__1_Internal_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr, 100663447 /*0x06000097*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass101_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass101_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass101_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984608, XrefRangeEnd = 984615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _UnloadPackageByDefinition_b__1(ArticyObject aObj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass101_1.NativeMethodInfoPtr__UnloadPackageByDefinition_b__1_Internal_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Dictionary<uint, ArticyObject> instanceList
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass101_1.NativeFieldInfoPtr_instanceList));
        return num == System.IntPtr.Zero ? (Dictionary<uint, ArticyObject>) null : Il2CppObjectPool.Get<Dictionary<uint, ArticyObject>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass101_1.NativeFieldInfoPtr_instanceList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c__DisplayClass116_0")]
  public sealed class __c__DisplayClass116_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aInstanceId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__InternalGetObjects_b__0_Internal_Boolean_ArticyObject_0;

    static __c__DisplayClass116_0()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c__DisplayClass116_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr);
      ArticyDatabase.__c__DisplayClass116_0.NativeFieldInfoPtr_aInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr, nameof (aInstanceId));
      ArticyDatabase.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr, 100663448 /*0x06000098*/);
      ArticyDatabase.__c__DisplayClass116_0.NativeMethodInfoPtr__InternalGetObjects_b__0_Internal_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr, 100663449 /*0x06000099*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass116_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass116_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass116_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _InternalGetObjects_b__0(ArticyObject aObj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass116_0.NativeMethodInfoPtr__InternalGetObjects_b__0_Internal_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe uint aInstanceId
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass116_0.NativeFieldInfoPtr_aInstanceId));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass116_0.NativeFieldInfoPtr_aInstanceId)) = value;
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c__DisplayClass150_0")]
  public sealed class __c__DisplayClass150_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_packageDef;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AssignObjectsChildren_b__0_Internal_Boolean_ArticyPackage_0;

    static __c__DisplayClass150_0()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c__DisplayClass150_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr);
      ArticyDatabase.__c__DisplayClass150_0.NativeFieldInfoPtr_packageDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr, nameof (packageDef));
      ArticyDatabase.__c__DisplayClass150_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr, 100663450 /*0x0600009A*/);
      ArticyDatabase.__c__DisplayClass150_0.NativeMethodInfoPtr__AssignObjectsChildren_b__0_Internal_Boolean_ArticyPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr, 100663451 /*0x0600009B*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass150_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass150_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass150_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _AssignObjectsChildren_b__0(ArticyPackage e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass150_0.NativeMethodInfoPtr__AssignObjectsChildren_b__0_Internal_Boolean_ArticyPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ArticyPackageDefinition packageDef
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass150_0.NativeFieldInfoPtr_packageDef));
        return num == System.IntPtr.Zero ? (ArticyPackageDefinition) null : Il2CppObjectPool.Get<ArticyPackageDefinition>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass150_0.NativeFieldInfoPtr_packageDef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<>c__DisplayClass36_0")]
  public sealed class __c__DisplayClass36_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aObject;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsObjectInLoadedPackages_b__0_Internal_Boolean_ArticyPackage_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__IsObjectInLoadedPackages_b__1_Internal_Boolean_ArticyObject_0;

    static __c__DisplayClass36_0()
    {
      Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<>c__DisplayClass36_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr);
      ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr_aObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr, nameof (aObject));
      ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr, "<>9__1");
      ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr, 100663452 /*0x0600009C*/);
      ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__IsObjectInLoadedPackages_b__0_Internal_Boolean_ArticyPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr, 100663453 /*0x0600009D*/);
      ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__IsObjectInLoadedPackages_b__1_Internal_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr, 100663454 /*0x0600009E*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass36_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase.__c__DisplayClass36_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984615, XrefRangeEnd = 984624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _IsObjectInLoadedPackages_b__0(ArticyPackage package)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) package)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__IsObjectInLoadedPackages_b__0_Internal_Boolean_ArticyPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _IsObjectInLoadedPackages_b__1(ArticyObject aMdl)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMdl)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyDatabase.__c__DisplayClass36_0.NativeMethodInfoPtr__IsObjectInLoadedPackages_b__1_Internal_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ArticyObject aObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr_aObject));
        return num == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr_aObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Func<ArticyObject, bool> __9__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr___9__1));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyObject, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyObject, bool>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase.__c__DisplayClass36_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<EnsurePackagesAsync>d__94")]
  public sealed class _EnsurePackagesAsync_d__94 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _EnsurePackagesAsync_d__94()
    {
      Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<EnsurePackagesAsync>d__94");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr);
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, "<>1__state");
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, "<>4__this");
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, "<>u__1");
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, "<>7__wrap1");
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, 100663455 /*0x0600009F*/);
      ArticyDatabase._EnsurePackagesAsync_d__94.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr, 100663456 /*0x060000A0*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984624, XrefRangeEnd = 984719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._EnsurePackagesAsync_d__94.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984719, XrefRangeEnd = 984723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._EnsurePackagesAsync_d__94.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _EnsurePackagesAsync_d__94(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _EnsurePackagesAsync_d__94()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._EnsurePackagesAsync_d__94>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyDatabase __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public List<ArticyPackageDefinition>.Enumerator __7__wrap1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___7__wrap1);
        return new List<ArticyPackageDefinition>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ArticyPackageDefinition>.Enumerator>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._EnsurePackagesAsync_d__94.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ArticyPackageDefinition>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<InitializeAsync>d__91")]
  public sealed class _InitializeAsync_d__91 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _InitializeAsync_d__91()
    {
      Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<InitializeAsync>d__91");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr);
      ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, "<>1__state");
      ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, "<>u__1");
      ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, "<>u__2");
      ArticyDatabase._InitializeAsync_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, 100663457 /*0x060000A1*/);
      ArticyDatabase._InitializeAsync_d__91.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr, 100663458 /*0x060000A2*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984723, XrefRangeEnd = 984779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._InitializeAsync_d__91.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984779, XrefRangeEnd = 984783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._InitializeAsync_d__91.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _InitializeAsync_d__91(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _InitializeAsync_d__91()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._InitializeAsync_d__91>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<ArticyDatabase, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<ArticyDatabase, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyDatabase, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyDatabase, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._InitializeAsync_d__91.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<LoadPackageAsync>d__6")]
  public sealed class _LoadPackageAsync_d__6 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aName;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadPackageAsync_d__6()
    {
      Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<LoadPackageAsync>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr);
      ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, "<>1__state");
      ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr_aName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, nameof (aName));
      ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, "<>u__1");
      ArticyDatabase._LoadPackageAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, 100663459 /*0x060000A3*/);
      ArticyDatabase._LoadPackageAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr, 100663460 /*0x060000A4*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984783, XrefRangeEnd = 984804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageAsync_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984804, XrefRangeEnd = 984808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageAsync_d__6.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadPackageAsync_d__6(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadPackageAsync_d__6()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__6>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string aName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr_aName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr_aName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__6.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<LoadPackageAsync>d__7")]
  public sealed class _LoadPackageAsync_d__7 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadPackageAsync_d__7()
    {
      Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<LoadPackageAsync>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr);
      ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, "<>1__state");
      ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, nameof (aId));
      ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, "<>u__1");
      ArticyDatabase._LoadPackageAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, 100663461 /*0x060000A5*/);
      ArticyDatabase._LoadPackageAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr, 100663462 /*0x060000A6*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984808, XrefRangeEnd = 984829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984829, XrefRangeEnd = 984833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadPackageAsync_d__7(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadPackageAsync_d__7()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._LoadPackageAsync_d__7>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ulong aId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr_aId)) = value;
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<LoadPackageByDefinitionAsync>d__103")]
  public sealed class _LoadPackageByDefinitionAsync_d__103 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aDefinition;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadPackageResult_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadPackageByDefinitionAsync_d__103()
    {
      Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<LoadPackageByDefinitionAsync>d__103");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr);
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<>1__state");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr_aDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, nameof (aDefinition));
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<>4__this");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr__loadPackageResult_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<loadPackageResult>5__2");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<>u__1");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, "<>u__2");
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, 100663463 /*0x060000A7*/);
      ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr, 100663464 /*0x060000A8*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984833, XrefRangeEnd = 984908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984908, XrefRangeEnd = 984912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadPackageByDefinitionAsync_d__103(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadPackageByDefinitionAsync_d__103()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByDefinitionAsync_d__103>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyPackageDefinition aDefinition
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr_aDefinition));
        return num == System.IntPtr.Zero ? (ArticyPackageDefinition) null : Il2CppObjectPool.Get<ArticyPackageDefinition>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr_aDefinition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyDatabase __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object> _loadPackageResult_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr__loadPackageResult_5__2);
        return new Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr__loadPackageResult_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyPackage, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter __u__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__2);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByDefinitionAsync_d__103.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<LoadPackageByIdAsync>d__98")]
  public sealed class _LoadPackageByIdAsync_d__98 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadPackageByIdAsync_d__98()
    {
      Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<LoadPackageByIdAsync>d__98");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr);
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, "<>1__state");
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, nameof (aId));
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, "<>4__this");
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, "<>7__wrap1");
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, "<>u__1");
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, 100663465 /*0x060000A9*/);
      ArticyDatabase._LoadPackageByIdAsync_d__98.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr, 100663466 /*0x060000AA*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984912, XrefRangeEnd = 984966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984966, XrefRangeEnd = 984970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadPackageByIdAsync_d__98(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadPackageByIdAsync_d__98()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByIdAsync_d__98>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ulong aId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr_aId)) = value;
      }
    }

    public unsafe ArticyDatabase __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator<ArticyPackageDefinition> __7__wrap1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___7__wrap1));
        return num == System.IntPtr.Zero ? (IEnumerator<ArticyPackageDefinition>) null : Il2CppObjectPool.Get<IEnumerator<ArticyPackageDefinition>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByIdAsync_d__98.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyDatabase+<LoadPackageByNameAsync>d__96")]
  public sealed class _LoadPackageByNameAsync_d__96 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aName;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadPackageByNameAsync_d__96()
    {
      Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr, "<LoadPackageByNameAsync>d__96");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr);
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, "<>1__state");
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, "<>t__builder");
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr_aName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, nameof (aName));
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, "<>4__this");
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, "<>7__wrap1");
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, "<>u__1");
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, 100663467 /*0x060000AB*/);
      ArticyDatabase._LoadPackageByNameAsync_d__96.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr, 100663468 /*0x060000AC*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984970, XrefRangeEnd = 985026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985026, XrefRangeEnd = 985030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadPackageByNameAsync_d__96(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadPackageByNameAsync_d__96()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDatabase._LoadPackageByNameAsync_d__96>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string aName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr_aName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr_aName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ArticyDatabase __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyDatabase) null : Il2CppObjectPool.Get<ArticyDatabase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IEnumerator<ArticyPackageDefinition> __7__wrap1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___7__wrap1));
        return num == System.IntPtr.Zero ? (IEnumerator<ArticyPackageDefinition>) null : Il2CppObjectPool.Get<IEnumerator<ArticyPackageDefinition>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDatabase._LoadPackageByNameAsync_d__96.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_Static_TObject_String_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_Static_TObject_String_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_String_UInt32_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_Static_TObject_UInt64_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_GetObject_Public_Static_TObject_UInt64_UInt32_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetAllOfType_Public_Static_List_1_TObject_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_GetAllOfType_Public_Static_List_1_TObject_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CloneFrom_Public_Static_TObject_String_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_CloneFrom_Public_Static_TObject_String_UInt32_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CloneOrGetFrom_Public_Static_TObject_String_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_CloneOrGetFrom_Public_Static_TObject_String_UInt32_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_CloneWithConsecutiveInstanceIdFrom_Public_Static_TObject_String_byref_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_CloneWithConsecutiveInstanceIdFrom_Public_Static_TObject_String_byref_UInt32_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InternalGetAllOfType_Private_List_1_TObject_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyDatabase.NativeMethodInfoPtr_InternalGetAllOfType_Private_List_1_TObject_0, Il2CppClassPointerStore<ArticyDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }
}
