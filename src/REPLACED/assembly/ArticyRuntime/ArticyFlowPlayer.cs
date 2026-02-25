// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyFlowPlayer
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyFlowPlayer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_useDefaultGlobalVariables;
  private static readonly System.IntPtr NativeFieldInfoPtr_globalVariables;
  private static readonly System.IntPtr NativeFieldInfoPtr_overwriteMethodProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_overwrittenMethodProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_startOn;
  private static readonly System.IntPtr NativeFieldInfoPtr_pauseOn;
  private static readonly System.IntPtr NativeFieldInfoPtr_ignoreInvalidBranches;
  private static readonly System.IntPtr NativeFieldInfoPtr_continuouslyRecalculateBranches;
  private static readonly System.IntPtr NativeFieldInfoPtr_continouslyRecalculateInterval;
  private static readonly System.IntPtr NativeFieldInfoPtr_onFlowPlayerPaused;
  private static readonly System.IntPtr NativeFieldInfoPtr_onBranchesUpdated;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentObject_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SuppressCallbacks_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastWasFinished;
  private static readonly System.IntPtr NativeFieldInfoPtr_continuouslyRecalculatingCoroutine;
  private static readonly System.IntPtr NativeFieldInfoPtr_continuouslyRecalculating;
  private static readonly System.IntPtr NativeFieldInfoPtr_mEngine;
  private static readonly System.IntPtr NativeFieldInfoPtr_delayedStartOn;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCallBacks;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BranchSorting_Public_get_IComparer_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BranchSorting_Public_set_Void_IComparer_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GlobalVariables_Public_get_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_GlobalVariables_Public_set_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PausedOn_Public_get_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentObject_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentObject_Private_set_Void_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartOn_Public_get_IArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartOn_Public_set_Void_IArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SuppressCallbacks_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SuppressCallbacks_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_PausableObjectTypes_IBaseScriptMethodProvider_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_ArticyFlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayRandom_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FinishCurrentPausedObject_Public_List_1_IFlowObject_Int32_Int32_FlowPlayerFinishFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateCallbacks_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethodProvider_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnContinuouslyRecalculateBranches_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyFlowPlayer()
  {
    Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyFlowPlayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr);
    ArticyFlowPlayer.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (Logger));
    ArticyFlowPlayer.NativeFieldInfoPtr_useDefaultGlobalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (useDefaultGlobalVariables));
    ArticyFlowPlayer.NativeFieldInfoPtr_globalVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (globalVariables));
    ArticyFlowPlayer.NativeFieldInfoPtr_overwriteMethodProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (overwriteMethodProvider));
    ArticyFlowPlayer.NativeFieldInfoPtr_overwrittenMethodProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (overwrittenMethodProvider));
    ArticyFlowPlayer.NativeFieldInfoPtr_startOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (startOn));
    ArticyFlowPlayer.NativeFieldInfoPtr_pauseOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (pauseOn));
    ArticyFlowPlayer.NativeFieldInfoPtr_ignoreInvalidBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (ignoreInvalidBranches));
    ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculateBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (continuouslyRecalculateBranches));
    ArticyFlowPlayer.NativeFieldInfoPtr_continouslyRecalculateInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (continouslyRecalculateInterval));
    ArticyFlowPlayer.NativeFieldInfoPtr_onFlowPlayerPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (onFlowPlayerPaused));
    ArticyFlowPlayer.NativeFieldInfoPtr_onBranchesUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (onBranchesUpdated));
    ArticyFlowPlayer.NativeFieldInfoPtr__CurrentObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, "<CurrentObject>k__BackingField");
    ArticyFlowPlayer.NativeFieldInfoPtr__SuppressCallbacks_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, "<SuppressCallbacks>k__BackingField");
    ArticyFlowPlayer.NativeFieldInfoPtr_lastWasFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (lastWasFinished));
    ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculatingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (continuouslyRecalculatingCoroutine));
    ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (continuouslyRecalculating));
    ArticyFlowPlayer.NativeFieldInfoPtr_mEngine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (mEngine));
    ArticyFlowPlayer.NativeFieldInfoPtr_delayedStartOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (delayedStartOn));
    ArticyFlowPlayer.NativeFieldInfoPtr_mCallBacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, nameof (mCallBacks));
    ArticyFlowPlayer.NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663766);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663767);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_BranchSorting_Public_get_IComparer_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663768);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_BranchSorting_Public_set_Void_IComparer_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663769);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663770);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663771);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663772);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_GlobalVariables_Public_get_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663773);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_GlobalVariables_Public_set_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663774);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_PausedOn_Public_get_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663775);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_CurrentObject_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663776 /*0x060001E0*/);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_CurrentObject_Private_set_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663777);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_StartOn_Public_get_IArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663778);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_StartOn_Public_set_Void_IArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663779);
    ArticyFlowPlayer.NativeMethodInfoPtr_get_SuppressCallbacks_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663780);
    ArticyFlowPlayer.NativeMethodInfoPtr_set_SuppressCallbacks_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663781);
    ArticyFlowPlayer.NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_PausableObjectTypes_IBaseScriptMethodProvider_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663782);
    ArticyFlowPlayer.NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_ArticyFlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663783);
    ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663784);
    ArticyFlowPlayer.NativeMethodInfoPtr_PlayRandom_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663785);
    ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663786);
    ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663787);
    ArticyFlowPlayer.NativeMethodInfoPtr_FinishCurrentPausedObject_Public_List_1_IFlowObject_Int32_Int32_FlowPlayerFinishFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663788);
    ArticyFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663789);
    ArticyFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663790);
    ArticyFlowPlayer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663791);
    ArticyFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663792 /*0x060001F0*/);
    ArticyFlowPlayer.NativeMethodInfoPtr_RecalculateCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663793);
    ArticyFlowPlayer.NativeMethodInfoPtr_FindMethodProvider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663794);
    ArticyFlowPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663795);
    ArticyFlowPlayer.NativeMethodInfoPtr_OnContinuouslyRecalculateBranches_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663796);
    ArticyFlowPlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663797);
    ArticyFlowPlayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663798);
    ArticyFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, 100663799);
  }

  public unsafe IBaseScriptMethodProvider MethodProvider
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 990375, RefRangeEnd = 990377, XrefRangeStart = 990375, XrefRangeEnd = 990375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IComparer<Branch> BranchSorting
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_BranchSorting_Public_get_IComparer_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IComparer<Branch>) null : Il2CppObjectPool.Get<IComparer<Branch>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_BranchSorting_Public_set_Void_IComparer_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseOldInputPinResolving
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IList<Branch> AvailableBranches
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 990379, RefRangeEnd = 990381, XrefRangeStart = 990377, XrefRangeEnd = 990379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num3);
    }
  }

  public unsafe BaseGlobalVariables GlobalVariables
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_GlobalVariables_Public_get_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990381, XrefRangeEnd = 990382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_GlobalVariables_Public_set_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IFlowObject PausedOn
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 990382, RefRangeEnd = 990384, XrefRangeStart = 990382, XrefRangeEnd = 990382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_PausedOn_Public_get_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num3);
    }
  }

  public unsafe ArticyRef CurrentObject
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_CurrentObject_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_CurrentObject_Private_set_Void_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IArticyObject StartOn
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 990388, RefRangeEnd = 990389, XrefRangeStart = 990384, XrefRangeEnd = 990388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_StartOn_Public_get_IArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IArticyObject) null : Il2CppObjectPool.Get<IArticyObject>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 990405, RefRangeEnd = 990408, XrefRangeStart = 990389, XrefRangeEnd = 990405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_StartOn_Public_set_Void_IArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool SuppressCallbacks
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_get_SuppressCallbacks_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_set_SuppressCallbacks_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990408, XrefRangeEnd = 990435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IList<Branch> GetBranchesOfNode(
    IArticyObject aStartNode,
    PausableObjectTypes aPauseOn = PausableObjectTypes.FlowFragments | PausableObjectTypes.Dialogues | PausableObjectTypes.DialogueFragments,
    IBaseScriptMethodProvider aMethodProvider = null,
    BaseGlobalVariables aGlobalVariables = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStartNode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aPauseOn;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_PausableObjectTypes_IBaseScriptMethodProvider_BaseGlobalVariables_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 990465, RefRangeEnd = 990466, XrefRangeStart = 990435, XrefRangeEnd = 990465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IList<Branch> GetBranchesOfNode(
    IArticyObject aStartNode,
    ArticyFlowPlayer aFlowPlayer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStartNode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFlowPlayer);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_GetBranchesOfNode_Public_Static_IList_1_Branch_IArticyObject_ArticyFlowPlayer_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 990468, RefRangeEnd = 990471, XrefRangeStart = 990466, XrefRangeEnd = 990468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play(Branch aBranch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 990481, RefRangeEnd = 990483, XrefRangeStart = 990471, XrefRangeEnd = 990481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int PlayRandom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_PlayRandom_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 990492, RefRangeEnd = 990499, XrefRangeStart = 990483, XrefRangeEnd = 990492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990499, XrefRangeEnd = 990539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play(int aBranchIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aBranchIndex
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Play_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990539, XrefRangeEnd = 990793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<IFlowObject> FinishCurrentPausedObject(
    int aStartPinIndex = 0,
    int aMaxParentLevel = 0,
    FlowPlayerFinishFlags aFlags = FlowPlayerFinishFlags.BreakOnStopNodes | FlowPlayerFinishFlags.EvaluateOnBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aStartPinIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aMaxParentLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aFlags;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_FinishCurrentPausedObject_Public_List_1_IFlowObject_Int32_Int32_FlowPlayerFinishFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IFlowObject>) null : Il2CppObjectPool.Get<List<IFlowObject>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990793, XrefRangeEnd = 990842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnFlowPlayerPaused(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990842, XrefRangeEnd = 990878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBranchesUpdated(IList<Branch> aBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranches)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990878, XrefRangeEnd = 990930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990930, XrefRangeEnd = 990932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990932, XrefRangeEnd = 990945, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RecalculateCallbacks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_RecalculateCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990945, XrefRangeEnd = 990960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FindMethodProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_FindMethodProvider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990960, XrefRangeEnd = 990976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 990980, RefRangeEnd = 990981, XrefRangeStart = 990976, XrefRangeEnd = 990980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator OnContinuouslyRecalculateBranches()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_OnContinuouslyRecalculateBranches_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990981, XrefRangeEnd = 990983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990983, XrefRangeEnd = 990984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990984, XrefRangeEnd = 990991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyFlowPlayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyFlowPlayer.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyFlowPlayer.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool useDefaultGlobalVariables
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_useDefaultGlobalVariables));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_useDefaultGlobalVariables)) = value;
    }
  }

  public unsafe BaseGlobalVariables globalVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_globalVariables));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_globalVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool overwriteMethodProvider
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_overwriteMethodProvider));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_overwriteMethodProvider)) = value;
    }
  }

  public unsafe GameObject overwrittenMethodProvider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_overwrittenMethodProvider));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_overwrittenMethodProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef startOn
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_startOn));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_startOn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PausableObjectTypes pauseOn
  {
    get
    {
      return *(PausableObjectTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_pauseOn));
    }
    [param: In] set
    {
      *(PausableObjectTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_pauseOn)) = value;
    }
  }

  public unsafe bool ignoreInvalidBranches
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_ignoreInvalidBranches));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_ignoreInvalidBranches)) = value;
    }
  }

  public unsafe bool continuouslyRecalculateBranches
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculateBranches));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculateBranches)) = value;
    }
  }

  public unsafe float continouslyRecalculateInterval
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continouslyRecalculateInterval));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continouslyRecalculateInterval)) = value;
    }
  }

  public unsafe OnFlowPlayerPausedCallback onFlowPlayerPaused
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_onFlowPlayerPaused));
      return num == System.IntPtr.Zero ? (OnFlowPlayerPausedCallback) null : Il2CppObjectPool.Get<OnFlowPlayerPausedCallback>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_onFlowPlayerPaused), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe OnBranchesUpdatedCallback onBranchesUpdated
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_onBranchesUpdated));
      return num == System.IntPtr.Zero ? (OnBranchesUpdatedCallback) null : Il2CppObjectPool.Get<OnBranchesUpdatedCallback>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_onBranchesUpdated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef _CurrentObject_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr__CurrentObject_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr__CurrentObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _SuppressCallbacks_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr__SuppressCallbacks_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr__SuppressCallbacks_k__BackingField)) = value;
    }
  }

  public unsafe bool lastWasFinished
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_lastWasFinished));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_lastWasFinished)) = value;
    }
  }

  public unsafe IEnumerator continuouslyRecalculatingCoroutine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculatingCoroutine));
      return num == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculatingCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool continuouslyRecalculating
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculating));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_continuouslyRecalculating)) = value;
    }
  }

  public unsafe ExecutionEngine mEngine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_mEngine));
      return num == System.IntPtr.Zero ? (ExecutionEngine) null : Il2CppObjectPool.Get<ExecutionEngine>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_mEngine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool delayedStartOn
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_delayedStartOn));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_delayedStartOn)) = value;
    }
  }

  public unsafe HashSet<IArticyFlowPlayerCallbacks> mCallBacks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_mCallBacks));
      return num == System.IntPtr.Zero ? (HashSet<IArticyFlowPlayerCallbacks>) null : Il2CppObjectPool.Get<HashSet<IArticyFlowPlayerCallbacks>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer.NativeFieldInfoPtr_mCallBacks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyFlowPlayer+<OnContinuouslyRecalculateBranches>d__53")]
  public sealed class _OnContinuouslyRecalculateBranches_d__53(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

    static _OnContinuouslyRecalculateBranches_d__53()
    {
      Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyFlowPlayer>.NativeClassPtr, "<OnContinuouslyRecalculateBranches>d__53");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, "<>1__state");
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, "<>2__current");
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, "<>4__this");
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663801);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663802);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663803);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663804);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663805);
      ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr, 100663806);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _OnContinuouslyRecalculateBranches_d__53(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990357, XrefRangeEnd = 990370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990370, XrefRangeEnd = 990375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyFlowPlayer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyFlowPlayer) null : Il2CppObjectPool.Get<ArticyFlowPlayer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyFlowPlayer._OnContinuouslyRecalculateBranches_d__53.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
