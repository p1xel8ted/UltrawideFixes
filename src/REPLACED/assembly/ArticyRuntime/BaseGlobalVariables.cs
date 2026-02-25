// Decompiled with JetBrains decompiler
// Type: Articy.Unity.BaseGlobalVariables
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
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class BaseGlobalVariables(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_variableNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_variableCacheModified;
  private static readonly System.IntPtr NativeFieldInfoPtr__FallbackUsed_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBranch_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ActualFallbackValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBoolVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIntVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStringVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLiveBoolVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLiveIntVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLiveStringVariableCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsInitialized;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsLiveInitialized;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsTearedDown;
  private static readonly System.IntPtr NativeFieldInfoPtr_mShadowState;
  private static readonly System.IntPtr NativeFieldInfoPtr_mNotificationManager;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentSelfObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentSpeakerObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_mGeneralObjectShadowCopies;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSeenNodes;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_TObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureShadowStateClone_Internal_IPropertyProvider_IPropertyProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AccessShadowStateCache_Private_IPropertyProvider_Stack_1_IPropertyProvider_IPropertyProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedObjectShadowCopies_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SelfObject_Public_get_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SelfObject_Internal_set_Void_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpeakerObject_Public_get_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SpeakerObject_Internal_set_Void_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Unseen_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SeenCounter_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SeenCounter_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SeenCounters_Public_Virtual_Final_New_get_Dictionary_2_UInt64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SeenCounters_Public_Virtual_Final_New_set_Void_Dictionary_2_UInt64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FallbackUsed_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FallbackUsed_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCheckForBranching_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentBranch_Private_get_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentBranch_Private_set_Void_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActualFallbackValue_Private_get_Nullable_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ActualFallbackValue_Private_set_Void_Nullable_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Variables_Public_get_Dictionary_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Variables_Public_set_Void_Dictionary_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalVariables_Private_get_Dictionary_2_String_IStoredVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NamespaceVariableMap_Public_get_Dictionary_2_String_List_1_IStoredVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVariableOfTypeBoolean_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVariableOfTypeInteger_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsVariableOfTypeString_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVariableByString_Public_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVariableByString_Public_TValue_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetVariableValueBoolean_Public_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetVariableValueBoolean_Public_Void_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetVariableValueInt32_Public_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetVariableValueInt32_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_GetVariableValueString_Public_String_Int32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_SetVariableValueString_Public_Void_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsInShadowState_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Notifications_Public_get_ArticyNotificationManager_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetVariables_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetVariable_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSeenCounter_Public_Virtual_Final_New_Int32_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSeenCounter_Public_Virtual_Final_New_Void_UInt64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetAllSeenCounters_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fallback_Internal_Boolean_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IncrementSeen_Internal_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginShadowState_Internal_ShadowState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginCheckForBranchingContext_Internal_Void_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndCheckForBranchingContext_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginUseActualFallContext_Internal_Void_Boolean_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndUseActualFallContext_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Teardown_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterVariable_Public_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AppendVariables_Private_Void_Dictionary_2_String_List_1_IStoredVariable_IEnumerable_1_TType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVariables_Private_Dictionary_2_String_List_1_IStoredVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentlyUsedBoolCache_Private_get_List_1_StoredBoolVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentlyUsedIntCache_Private_get_List_1_StoredIntVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentlyUsedStringCache_Private_get_List_1_StoredStringVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VariableNames_Public_Static_get_HashSet_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushState_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopState_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlayingForVariables_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static BaseGlobalVariables()
  {
    Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (BaseGlobalVariables));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr);
    BaseGlobalVariables.NativeFieldInfoPtr_variableNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (variableNames));
    BaseGlobalVariables.NativeFieldInfoPtr_variableCacheModified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (variableCacheModified));
    BaseGlobalVariables.NativeFieldInfoPtr__FallbackUsed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, "<FallbackUsed>k__BackingField");
    BaseGlobalVariables.NativeFieldInfoPtr__CurrentBranch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, "<CurrentBranch>k__BackingField");
    BaseGlobalVariables.NativeFieldInfoPtr__ActualFallbackValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, "<ActualFallbackValue>k__BackingField");
    BaseGlobalVariables.NativeFieldInfoPtr_mBoolVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mBoolVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mIntVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mIntVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mStringVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mStringVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mLiveBoolVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mLiveBoolVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mLiveIntVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mLiveIntVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mLiveStringVariableCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mLiveStringVariableCache));
    BaseGlobalVariables.NativeFieldInfoPtr_mIsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mIsInitialized));
    BaseGlobalVariables.NativeFieldInfoPtr_mIsLiveInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mIsLiveInitialized));
    BaseGlobalVariables.NativeFieldInfoPtr_mIsTearedDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mIsTearedDown));
    BaseGlobalVariables.NativeFieldInfoPtr_mShadowState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mShadowState));
    BaseGlobalVariables.NativeFieldInfoPtr_mNotificationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mNotificationManager));
    BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSelfObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mCurrentSelfObject));
    BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSpeakerObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mCurrentSpeakerObject));
    BaseGlobalVariables.NativeFieldInfoPtr_mGeneralObjectShadowCopies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mGeneralObjectShadowCopies));
    BaseGlobalVariables.NativeFieldInfoPtr_mSeenNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, nameof (mSeenNodes));
    BaseGlobalVariables.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664092);
    BaseGlobalVariables.NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664093);
    BaseGlobalVariables.NativeMethodInfoPtr_EnsureShadowStateClone_Internal_IPropertyProvider_IPropertyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664094);
    BaseGlobalVariables.NativeMethodInfoPtr_AccessShadowStateCache_Private_IPropertyProvider_Stack_1_IPropertyProvider_IPropertyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664095);
    BaseGlobalVariables.NativeMethodInfoPtr_RemoveUnusedObjectShadowCopies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664096 /*0x06000320*/);
    BaseGlobalVariables.NativeMethodInfoPtr_get_SelfObject_Public_get_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664097);
    BaseGlobalVariables.NativeMethodInfoPtr_set_SelfObject_Internal_set_Void_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664098);
    BaseGlobalVariables.NativeMethodInfoPtr_get_SpeakerObject_Public_get_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664099);
    BaseGlobalVariables.NativeMethodInfoPtr_set_SpeakerObject_Internal_set_Void_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664100);
    BaseGlobalVariables.NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664101);
    BaseGlobalVariables.NativeMethodInfoPtr_get_Unseen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664102);
    BaseGlobalVariables.NativeMethodInfoPtr_get_SeenCounter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664103);
    BaseGlobalVariables.NativeMethodInfoPtr_set_SeenCounter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664104);
    BaseGlobalVariables.NativeMethodInfoPtr_get_SeenCounters_Public_Virtual_Final_New_get_Dictionary_2_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664105);
    BaseGlobalVariables.NativeMethodInfoPtr_set_SeenCounters_Public_Virtual_Final_New_set_Void_Dictionary_2_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664106);
    BaseGlobalVariables.NativeMethodInfoPtr_get_FallbackUsed_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664107);
    BaseGlobalVariables.NativeMethodInfoPtr_set_FallbackUsed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664108);
    BaseGlobalVariables.NativeMethodInfoPtr_get_IsCheckForBranching_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664109);
    BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentBranch_Private_get_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664110);
    BaseGlobalVariables.NativeMethodInfoPtr_set_CurrentBranch_Private_set_Void_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664111);
    BaseGlobalVariables.NativeMethodInfoPtr_get_ActualFallbackValue_Private_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664112 /*0x06000330*/);
    BaseGlobalVariables.NativeMethodInfoPtr_set_ActualFallbackValue_Private_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664113);
    BaseGlobalVariables.NativeMethodInfoPtr_get_Variables_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664114);
    BaseGlobalVariables.NativeMethodInfoPtr_set_Variables_Public_set_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664115);
    BaseGlobalVariables.NativeMethodInfoPtr_get_InternalVariables_Private_get_Dictionary_2_String_IStoredVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664116);
    BaseGlobalVariables.NativeMethodInfoPtr_get_NamespaceVariableMap_Public_get_Dictionary_2_String_List_1_IStoredVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664117);
    BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeBoolean_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664118);
    BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeInteger_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664119);
    BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeString_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664120);
    BaseGlobalVariables.NativeMethodInfoPtr_SetVariableByString_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664121);
    BaseGlobalVariables.NativeMethodInfoPtr_GetVariableByString_Public_TValue_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664122);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueBoolean_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664123);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueBoolean_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664124);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueInt32_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664125);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueInt32_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664126);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueString_Public_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664127);
    BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueString_Public_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664128 /*0x06000340*/);
    BaseGlobalVariables.NativeMethodInfoPtr_get_IsInShadowState_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664129);
    BaseGlobalVariables.NativeMethodInfoPtr_get_Notifications_Public_get_ArticyNotificationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664130);
    BaseGlobalVariables.NativeMethodInfoPtr_ResetVariables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664131);
    BaseGlobalVariables.NativeMethodInfoPtr_ResetVariable_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664132);
    BaseGlobalVariables.NativeMethodInfoPtr_GetSeenCounter_Public_Virtual_Final_New_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664133);
    BaseGlobalVariables.NativeMethodInfoPtr_SetSeenCounter_Public_Virtual_Final_New_Void_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664134);
    BaseGlobalVariables.NativeMethodInfoPtr_ResetAllSeenCounters_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664135);
    BaseGlobalVariables.NativeMethodInfoPtr_Fallback_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664136);
    BaseGlobalVariables.NativeMethodInfoPtr_Fallback_Internal_Boolean_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664137);
    BaseGlobalVariables.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664138);
    BaseGlobalVariables.NativeMethodInfoPtr_Setup_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664139);
    BaseGlobalVariables.NativeMethodInfoPtr_IncrementSeen_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664140);
    BaseGlobalVariables.NativeMethodInfoPtr_BeginShadowState_Internal_ShadowState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664141);
    BaseGlobalVariables.NativeMethodInfoPtr_BeginCheckForBranchingContext_Internal_Void_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664142);
    BaseGlobalVariables.NativeMethodInfoPtr_EndCheckForBranchingContext_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664143);
    BaseGlobalVariables.NativeMethodInfoPtr_BeginUseActualFallContext_Internal_Void_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664144 /*0x06000350*/);
    BaseGlobalVariables.NativeMethodInfoPtr_EndUseActualFallContext_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664145);
    BaseGlobalVariables.NativeMethodInfoPtr_Teardown_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664146);
    BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664147);
    BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664148);
    BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664149);
    BaseGlobalVariables.NativeMethodInfoPtr_AppendVariables_Private_Void_Dictionary_2_String_List_1_IStoredVariable_IEnumerable_1_TType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664150);
    BaseGlobalVariables.NativeMethodInfoPtr_GetVariables_Private_Dictionary_2_String_List_1_IStoredVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664151);
    BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedBoolCache_Private_get_List_1_StoredBoolVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664152);
    BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedIntCache_Private_get_List_1_StoredIntVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664153);
    BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedStringCache_Private_get_List_1_StoredStringVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664154);
    BaseGlobalVariables.NativeMethodInfoPtr_get_VariableNames_Public_Static_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664155);
    BaseGlobalVariables.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664156);
    BaseGlobalVariables.NativeMethodInfoPtr_PushState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664157);
    BaseGlobalVariables.NativeMethodInfoPtr_PopState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664158);
    BaseGlobalVariables.NativeMethodInfoPtr_get_IsPlayingForVariables_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664159);
    BaseGlobalVariables.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, 100664160 /*0x06000360*/);
  }

  public unsafe bool IsInitialized
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994747, XrefRangeEnd = 994751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_IsInitialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 994754, RefRangeEnd = 994755, XrefRangeStart = 994751, XrefRangeEnd = 994754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TObject CreateGlobalVariablesClone<TObject>() where TObject : BaseGlobalVariables
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.MethodInfoStoreGeneric_CreateGlobalVariablesClone_Public_Static_TObject_0<TObject>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 994767, RefRangeEnd = 994775, XrefRangeStart = 994755, XrefRangeEnd = 994767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPropertyProvider EnsureShadowStateClone(IPropertyProvider aCandidate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCandidate)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_EnsureShadowStateClone_Internal_IPropertyProvider_IPropertyProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 994793, RefRangeEnd = 994794, XrefRangeStart = 994775, XrefRangeEnd = 994793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPropertyProvider AccessShadowStateCache(
    Stack<IPropertyProvider> aShadowCopyStack,
    IPropertyProvider aBaseObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aShadowCopyStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBaseObject);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_AccessShadowStateCache_Private_IPropertyProvider_Stack_1_IPropertyProvider_IPropertyProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 994828, RefRangeEnd = 994829, XrefRangeStart = 994794, XrefRangeEnd = 994828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveUnusedObjectShadowCopies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_RemoveUnusedObjectShadowCopies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ScriptObjectProxy SelfObject
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994829, XrefRangeEnd = 994834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_SelfObject_Public_get_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptObjectProxy) null : Il2CppObjectPool.Get<ScriptObjectProxy>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994834, XrefRangeEnd = 994835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_SelfObject_Internal_set_Void_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ScriptObjectProxy SpeakerObject
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994835, XrefRangeEnd = 994840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_SpeakerObject_Public_get_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptObjectProxy) null : Il2CppObjectPool.Get<ScriptObjectProxy>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994840, XrefRangeEnd = 994841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_SpeakerObject_Internal_set_Void_ScriptObjectProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool Seen
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994841, XrefRangeEnd = 994853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_Seen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Unseen
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994853, XrefRangeEnd = 994865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_Unseen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int SeenCounter
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994865, XrefRangeEnd = 994877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_SeenCounter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994877, XrefRangeEnd = 994890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_SeenCounter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Dictionary<ulong, int> SeenCounters
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994890, XrefRangeEnd = 994894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_SeenCounters_Public_Virtual_Final_New_get_Dictionary_2_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<ulong, int>) null : Il2CppObjectPool.Get<Dictionary<ulong, int>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994894, XrefRangeEnd = 994909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_SeenCounters_Public_Virtual_Final_New_set_Void_Dictionary_2_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool FallbackUsed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_FallbackUsed_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_FallbackUsed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsCheckForBranching
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994909, XrefRangeEnd = 994910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_IsCheckForBranching_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Branch CurrentBranch
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentBranch_Private_get_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Branch) null : Il2CppObjectPool.Get<Branch>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_CurrentBranch_Private_set_Void_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<bool> ActualFallbackValue
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_ActualFallbackValue_Private_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<bool>(pointer);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_ActualFallbackValue_Private_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> Variables
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 994978, RefRangeEnd = 994979, XrefRangeStart = 994910, XrefRangeEnd = 994978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_Variables_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994979, XrefRangeEnd = 994996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_set_Variables_Public_set_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Dictionary<string, IStoredVariable> InternalVariables
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 995054, RefRangeEnd = 995061, XrefRangeStart = 994996, XrefRangeEnd = 995054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_InternalVariables_Private_get_Dictionary_2_String_IStoredVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, IStoredVariable>) null : Il2CppObjectPool.Get<Dictionary<string, IStoredVariable>>(num3);
    }
  }

  public unsafe Dictionary<string, List<IStoredVariable>> NamespaceVariableMap
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 995062, RefRangeEnd = 995064, XrefRangeStart = 995061, XrefRangeEnd = 995062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_NamespaceVariableMap_Public_get_Dictionary_2_String_List_1_IStoredVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, List<IStoredVariable>>) null : Il2CppObjectPool.Get<Dictionary<string, List<IStoredVariable>>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 995069, RefRangeEnd = 995070, XrefRangeStart = 995064, XrefRangeEnd = 995069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsVariableOfTypeBoolean(string aVariableName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aVariableName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeBoolean_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 995075, RefRangeEnd = 995076, XrefRangeStart = 995070, XrefRangeEnd = 995075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsVariableOfTypeInteger(string aVariableName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aVariableName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeInteger_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995076, XrefRangeEnd = 995081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsVariableOfTypeString(string aVariableName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aVariableName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_IsVariableOfTypeString_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 995101, RefRangeEnd = 995107, XrefRangeStart = 995081, XrefRangeEnd = 995101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVariableByString(string aVariableName, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariableName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_SetVariableByString_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 995163, RefRangeEnd = 995164, XrefRangeStart = 995107, XrefRangeEnd = 995163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TValue GetVariableByString<TValue>(
    string aVariableName,
    bool aResolveStringVariable = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariableName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aResolveStringVariable;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.MethodInfoStoreGeneric_GetVariableByString_Public_TValue_String_Boolean_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TValue>(num2, false, true);
  }

  [CallerCount(104)]
  [CachedScanResults(RefRangeStart = 995171, RefRangeEnd = 995275, XrefRangeStart = 995164, XrefRangeEnd = 995171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Internal_GetVariableValueBoolean(int aVariable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aVariable
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueBoolean_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(104)]
  [CachedScanResults(RefRangeStart = 995284, RefRangeEnd = 995388, XrefRangeStart = 995275, XrefRangeEnd = 995284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Internal_SetVariableValueBoolean(int aVariable, bool aNewValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aVariable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aNewValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueBoolean_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 995395, RefRangeEnd = 995420, XrefRangeStart = 995388, XrefRangeEnd = 995395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Internal_GetVariableValueInt32(int aVariable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aVariable
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueInt32_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 995429, RefRangeEnd = 995454, XrefRangeStart = 995420, XrefRangeEnd = 995429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Internal_SetVariableValueInt32(int aVariable, int aNewValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aVariable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aNewValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueInt32_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995454, XrefRangeEnd = 995470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string Internal_GetVariableValueString(int aVariable, bool aResolveText = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aVariable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aResolveText;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_GetVariableValueString_Public_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995470, XrefRangeEnd = 995481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Internal_SetVariableValueString(int aVariable, string aNewValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aVariable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aNewValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Internal_SetVariableValueString_Public_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool IsInShadowState
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 995481, RefRangeEnd = 995482, XrefRangeStart = 995481, XrefRangeEnd = 995481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_IsInShadowState_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ArticyNotificationManager Notifications
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_Notifications_Public_get_ArticyNotificationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyNotificationManager) null : Il2CppObjectPool.Get<ArticyNotificationManager>(num3);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 995560, RefRangeEnd = 995563, XrefRangeStart = 995482, XrefRangeEnd = 995560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetVariables()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_ResetVariables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995563, XrefRangeEnd = 995626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetVariable(string aVariable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aVariable)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_ResetVariable_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995626, XrefRangeEnd = 995632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int GetSeenCounter(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_GetSeenCounter_Public_Virtual_Final_New_Int32_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995632, XrefRangeEnd = 995639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetSeenCounter(ulong aId, int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_SetSeenCounter_Public_Virtual_Final_New_Void_UInt64_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995639, XrefRangeEnd = 995646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ResetAllSeenCounters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_ResetAllSeenCounters_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 995648, RefRangeEnd = 995649, XrefRangeStart = 995646, XrefRangeEnd = 995648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Fallback()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Fallback_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 995661, RefRangeEnd = 995664, XrefRangeStart = 995649, XrefRangeEnd = 995661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Fallback(ArticyObject aOriginNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOriginNode)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Fallback_Internal_Boolean_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995664, XrefRangeEnd = 995673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 995688, RefRangeEnd = 995694, XrefRangeStart = 995673, XrefRangeEnd = 995688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup(bool aForceRebuildCache = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aForceRebuildCache
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Setup_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 995703, RefRangeEnd = 995707, XrefRangeStart = 995694, XrefRangeEnd = 995703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void IncrementSeen(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_IncrementSeen_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 995712, RefRangeEnd = 995714, XrefRangeStart = 995707, XrefRangeEnd = 995712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowState BeginShadowState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_BeginShadowState_Internal_ShadowState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ShadowState) null : Il2CppObjectPool.Get<ShadowState>(num3);
  }

  [CallerCount(0)]
  public unsafe void BeginCheckForBranchingContext(Branch aBranch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_BeginCheckForBranchingContext_Internal_Void_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void EndCheckForBranchingContext()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_EndCheckForBranchingContext_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995714, XrefRangeEnd = 995717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginUseActualFallContext(bool aValue, Branch aBranch = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_BeginUseActualFallContext_Internal_Void_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void EndUseActualFallContext()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_EndUseActualFallContext_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 995724, RefRangeEnd = 995725, XrefRangeStart = 995717, XrefRangeEnd = 995724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Teardown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_Teardown_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 995737, RefRangeEnd = 995762, XrefRangeStart = 995725, XrefRangeEnd = 995737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterVariable(string aVariableName, int aInitialValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariableName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInitialValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(104)]
  [CachedScanResults(RefRangeStart = 995774, RefRangeEnd = 995878, XrefRangeStart = 995762, XrefRangeEnd = 995774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterVariable(string aVariableName, bool aInitialValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariableName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aInitialValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995878, XrefRangeEnd = 995890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterVariable(string aVariableName, string aInitialValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariableName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aInitialValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_RegisterVariable_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 995927, RefRangeEnd = 995930, XrefRangeStart = 995890, XrefRangeEnd = 995927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AppendVariables<TType>(
    Dictionary<string, List<IStoredVariable>> aTargetMap,
    IEnumerable<TType> aVariables)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVariables);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.MethodInfoStoreGeneric_AppendVariables_Private_Void_Dictionary_2_String_List_1_IStoredVariable_IEnumerable_1_TType_0<TType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 995966, RefRangeEnd = 995968, XrefRangeStart = 995930, XrefRangeEnd = 995966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Dictionary<string, List<IStoredVariable>> GetVariables()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_GetVariables_Private_Dictionary_2_String_List_1_IStoredVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Dictionary<string, List<IStoredVariable>>) null : Il2CppObjectPool.Get<Dictionary<string, List<IStoredVariable>>>(num3);
  }

  public unsafe List<StoredBoolVariable> CurrentlyUsedBoolCache
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995968, XrefRangeEnd = 995969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedBoolCache_Private_get_List_1_StoredBoolVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<StoredBoolVariable>) null : Il2CppObjectPool.Get<List<StoredBoolVariable>>(num3);
    }
  }

  public unsafe List<StoredIntVariable> CurrentlyUsedIntCache
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995969, XrefRangeEnd = 995970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedIntCache_Private_get_List_1_StoredIntVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<StoredIntVariable>) null : Il2CppObjectPool.Get<List<StoredIntVariable>>(num3);
    }
  }

  public unsafe List<StoredStringVariable> CurrentlyUsedStringCache
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995970, XrefRangeEnd = 995971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_CurrentlyUsedStringCache_Private_get_List_1_StoredStringVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<StoredStringVariable>) null : Il2CppObjectPool.Get<List<StoredStringVariable>>(num3);
    }
  }

  public static unsafe HashSet<string> VariableNames
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995971, XrefRangeEnd = 995975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_VariableNames_Public_Static_get_HashSet_1_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num3);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseGlobalVariables.NativeMethodInfoPtr_Init_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 996046, RefRangeEnd = 996055, XrefRangeStart = 995975, XrefRangeEnd = 996046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PushState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_PushState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 996110, RefRangeEnd = 996111, XrefRangeStart = 996055, XrefRangeEnd = 996110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_PopState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsPlayingForVariables
  {
    [CallerCount(25), CachedScanResults(RefRangeStart = 996116, RefRangeEnd = 996141, XrefRangeStart = 996111, XrefRangeEnd = 996116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr_get_IsPlayingForVariables_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 996184, RefRangeEnd = 996185, XrefRangeStart = 996141, XrefRangeEnd = 996184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseGlobalVariables()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe HashSet<string> variableNames
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(BaseGlobalVariables.NativeFieldInfoPtr_variableNames, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (HashSet<string>) null : Il2CppObjectPool.Get<HashSet<string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BaseGlobalVariables.NativeFieldInfoPtr_variableNames, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action variableCacheModified
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_variableCacheModified));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_variableCacheModified), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _FallbackUsed_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__FallbackUsed_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__FallbackUsed_k__BackingField)) = value;
    }
  }

  public unsafe Branch _CurrentBranch_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__CurrentBranch_k__BackingField));
      return num == System.IntPtr.Zero ? (Branch) null : Il2CppObjectPool.Get<Branch>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__CurrentBranch_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<bool> _ActualFallbackValue_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__ActualFallbackValue_k__BackingField);
      return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr__ActualFallbackValue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe List<StoredBoolVariable> mBoolVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mBoolVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredBoolVariable>) null : Il2CppObjectPool.Get<List<StoredBoolVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mBoolVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StoredIntVariable> mIntVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIntVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredIntVariable>) null : Il2CppObjectPool.Get<List<StoredIntVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIntVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StoredStringVariable> mStringVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mStringVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredStringVariable>) null : Il2CppObjectPool.Get<List<StoredStringVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mStringVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StoredBoolVariable> mLiveBoolVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveBoolVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredBoolVariable>) null : Il2CppObjectPool.Get<List<StoredBoolVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveBoolVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StoredIntVariable> mLiveIntVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveIntVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredIntVariable>) null : Il2CppObjectPool.Get<List<StoredIntVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveIntVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<StoredStringVariable> mLiveStringVariableCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveStringVariableCache));
      return num == System.IntPtr.Zero ? (List<StoredStringVariable>) null : Il2CppObjectPool.Get<List<StoredStringVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mLiveStringVariableCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mIsInitialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsInitialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsInitialized)) = value;
    }
  }

  public unsafe bool mIsLiveInitialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsLiveInitialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsLiveInitialized)) = value;
    }
  }

  public unsafe bool mIsTearedDown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsTearedDown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mIsTearedDown)) = value;
    }
  }

  public unsafe int mShadowState
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mShadowState));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mShadowState)) = value;
    }
  }

  public unsafe ArticyNotificationManager mNotificationManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mNotificationManager));
      return num == System.IntPtr.Zero ? (ArticyNotificationManager) null : Il2CppObjectPool.Get<ArticyNotificationManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mNotificationManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPropertyProvider mCurrentSelfObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSelfObject));
      return num == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSelfObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPropertyProvider mCurrentSpeakerObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSpeakerObject));
      return num == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mCurrentSpeakerObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, Dictionary<uint, Stack<IPropertyProvider>>> mGeneralObjectShadowCopies
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mGeneralObjectShadowCopies));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, Dictionary<uint, Stack<IPropertyProvider>>>) null : Il2CppObjectPool.Get<Dictionary<ulong, Dictionary<uint, Stack<IPropertyProvider>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mGeneralObjectShadowCopies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Stack<Dictionary<ulong, int>> mSeenNodes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mSeenNodes));
      return num == System.IntPtr.Zero ? (Stack<Dictionary<ulong, int>>) null : Il2CppObjectPool.Get<Stack<Dictionary<ulong, int>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.NativeFieldInfoPtr_mSeenNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.BaseGlobalVariables+<>c__DisplayClass61_0")]
  public sealed class __c__DisplayClass61_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aVariable;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ResetVariable_b__0_Internal_Boolean_StoredBoolVariable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ResetVariable_b__1_Internal_Boolean_StoredIntVariable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ResetVariable_b__2_Internal_Boolean_StoredStringVariable_0;

    static __c__DisplayClass61_0()
    {
      Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, "<>c__DisplayClass61_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr);
      BaseGlobalVariables.__c__DisplayClass61_0.NativeFieldInfoPtr_aVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr, nameof (aVariable));
      BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr, 100664162);
      BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__0_Internal_Boolean_StoredBoolVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr, 100664163);
      BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__1_Internal_Boolean_StoredIntVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr, 100664164);
      BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__2_Internal_Boolean_StoredStringVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr, 100664165);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass61_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass61_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ResetVariable_b__0(StoredBoolVariable v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__0_Internal_Boolean_StoredBoolVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ResetVariable_b__1(StoredIntVariable v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__1_Internal_Boolean_StoredIntVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _ResetVariable_b__2(StoredStringVariable v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass61_0.NativeMethodInfoPtr__ResetVariable_b__2_Internal_Boolean_StoredStringVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe string aVariable
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.__c__DisplayClass61_0.NativeFieldInfoPtr_aVariable)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.__c__DisplayClass61_0.NativeFieldInfoPtr_aVariable), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.BaseGlobalVariables+<>c__DisplayClass66_0")]
  public sealed class __c__DisplayClass66_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aOriginNode;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Fallback_b__0_Internal_Boolean_IFlowObject_0;

    static __c__DisplayClass66_0()
    {
      Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr, "<>c__DisplayClass66_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr);
      BaseGlobalVariables.__c__DisplayClass66_0.NativeFieldInfoPtr_aOriginNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr, nameof (aOriginNode));
      BaseGlobalVariables.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr, 100664166);
      BaseGlobalVariables.__c__DisplayClass66_0.NativeMethodInfoPtr__Fallback_b__0_Internal_Boolean_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr, 100664167);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass66_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseGlobalVariables.__c__DisplayClass66_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass66_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994745, XrefRangeEnd = 994747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _Fallback_b__0(IFlowObject node)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseGlobalVariables.__c__DisplayClass66_0.NativeMethodInfoPtr__Fallback_b__0_Internal_Boolean_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ArticyObject aOriginNode
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.__c__DisplayClass66_0.NativeFieldInfoPtr_aOriginNode));
        return num == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseGlobalVariables.__c__DisplayClass66_0.NativeFieldInfoPtr_aOriginNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_CreateGlobalVariablesClone_Public_Static_TObject_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseGlobalVariables.NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_TObject_0, Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetVariableByString_Public_TValue_String_Boolean_0<TValue>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseGlobalVariables.NativeMethodInfoPtr_GetVariableByString_Public_TValue_String_Boolean_0, Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AppendVariables_Private_Void_Dictionary_2_String_List_1_IStoredVariable_IEnumerable_1_TType_0<TType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseGlobalVariables.NativeMethodInfoPtr_AppendVariables_Private_Void_Dictionary_2_String_List_1_IStoredVariable_IEnumerable_1_TType_0, Il2CppClassPointerStore<BaseGlobalVariables>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TType>.NativeClassPtr))
    }))));
  }
}
