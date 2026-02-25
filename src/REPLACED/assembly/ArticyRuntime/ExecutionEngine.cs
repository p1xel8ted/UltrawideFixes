// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ExecutionEngine
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public sealed class ExecutionEngine(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultStopOn;
  private static readonly System.IntPtr NativeFieldInfoPtr__IgnoreInvalidBranches_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__VariableStorage_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MethodProvider_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UseOldInputPinResolving_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentNode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_BranchSorting;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRecursion;
  private static readonly System.IntPtr NativeFieldInfoPtr_mNextBranchId;
  private static readonly System.IntPtr NativeFieldInfoPtr_infiniteLoopCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCurrentBranches;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStopsOn;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFirstTraversal;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsVeryFirstNextCall;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSkipNextIncreaseSeenForNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStartNode;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOriginPinId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStopsOnCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IArticyFlowPlayerCallbacks_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IgnoreInvalidBranches_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IgnoreInvalidBranches_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VariableStorage_Public_get_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VariableStorage_Public_set_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StopsOn_Public_get_PausableObjectTypes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StopsOn_Public_set_Void_PausableObjectTypes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentNode_Public_get_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentNode_Private_set_Void_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StartNode_Public_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StartNode_Public_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CachedAvailableBranches_Internal_get_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateBranches_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecalculateBranches_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureValidStop_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Void_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsCurrentNodeAStop_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNodeAStop_Internal_Boolean_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TraverseFlow_Private_Void_IFlowObject_Branch_Branch_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Private_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Indent_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Outdent_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RebuildStopsOnCache_Private_Void_0;

  static ExecutionEngine()
  {
    Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ExecutionEngine));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr);
    ExecutionEngine.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (Logger));
    ExecutionEngine.NativeFieldInfoPtr_DefaultStopOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (DefaultStopOn));
    ExecutionEngine.NativeFieldInfoPtr__IgnoreInvalidBranches_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<IgnoreInvalidBranches>k__BackingField");
    ExecutionEngine.NativeFieldInfoPtr__VariableStorage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<VariableStorage>k__BackingField");
    ExecutionEngine.NativeFieldInfoPtr__MethodProvider_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<MethodProvider>k__BackingField");
    ExecutionEngine.NativeFieldInfoPtr__UseOldInputPinResolving_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<UseOldInputPinResolving>k__BackingField");
    ExecutionEngine.NativeFieldInfoPtr__CurrentNode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<CurrentNode>k__BackingField");
    ExecutionEngine.NativeFieldInfoPtr_BranchSorting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (BranchSorting));
    ExecutionEngine.NativeFieldInfoPtr_mRecursion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mRecursion));
    ExecutionEngine.NativeFieldInfoPtr_mNextBranchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mNextBranchId));
    ExecutionEngine.NativeFieldInfoPtr_infiniteLoopCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (infiniteLoopCounter));
    ExecutionEngine.NativeFieldInfoPtr_mCurrentBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mCurrentBranches));
    ExecutionEngine.NativeFieldInfoPtr_mStopsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mStopsOn));
    ExecutionEngine.NativeFieldInfoPtr_mFirstTraversal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mFirstTraversal));
    ExecutionEngine.NativeFieldInfoPtr_mIsVeryFirstNextCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mIsVeryFirstNextCall));
    ExecutionEngine.NativeFieldInfoPtr_mSkipNextIncreaseSeenForNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mSkipNextIncreaseSeenForNode));
    ExecutionEngine.NativeFieldInfoPtr_mStartNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mStartNode));
    ExecutionEngine.NativeFieldInfoPtr_mOriginPinId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mOriginPinId));
    ExecutionEngine.NativeFieldInfoPtr_mStopsOnCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mStopsOnCache));
    ExecutionEngine.NativeFieldInfoPtr_mCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, nameof (mCallback));
    ExecutionEngine.NativeMethodInfoPtr__ctor_Public_Void_IArticyFlowPlayerCallbacks_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664184);
    ExecutionEngine.NativeMethodInfoPtr_get_IgnoreInvalidBranches_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664185);
    ExecutionEngine.NativeMethodInfoPtr_set_IgnoreInvalidBranches_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664186);
    ExecutionEngine.NativeMethodInfoPtr_get_VariableStorage_Public_get_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664187);
    ExecutionEngine.NativeMethodInfoPtr_set_VariableStorage_Public_set_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664188);
    ExecutionEngine.NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664189);
    ExecutionEngine.NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664190);
    ExecutionEngine.NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664191);
    ExecutionEngine.NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664192 /*0x06000380*/);
    ExecutionEngine.NativeMethodInfoPtr_get_StopsOn_Public_get_PausableObjectTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664193);
    ExecutionEngine.NativeMethodInfoPtr_set_StopsOn_Public_set_Void_PausableObjectTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664194);
    ExecutionEngine.NativeMethodInfoPtr_get_CurrentNode_Public_get_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664195);
    ExecutionEngine.NativeMethodInfoPtr_set_CurrentNode_Private_set_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664196);
    ExecutionEngine.NativeMethodInfoPtr_get_StartNode_Public_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664197);
    ExecutionEngine.NativeMethodInfoPtr_set_StartNode_Public_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664198);
    ExecutionEngine.NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664199);
    ExecutionEngine.NativeMethodInfoPtr_get_CachedAvailableBranches_Internal_get_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664200);
    ExecutionEngine.NativeMethodInfoPtr_UpdateBranches_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664201);
    ExecutionEngine.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664202);
    ExecutionEngine.NativeMethodInfoPtr_RecalculateBranches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664203);
    ExecutionEngine.NativeMethodInfoPtr_EnsureValidStop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664204);
    ExecutionEngine.NativeMethodInfoPtr_Next_Public_Void_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664205);
    ExecutionEngine.NativeMethodInfoPtr_IsCurrentNodeAStop_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664206);
    ExecutionEngine.NativeMethodInfoPtr_IsNodeAStop_Internal_Boolean_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664207);
    ExecutionEngine.NativeMethodInfoPtr_TraverseFlow_Private_Void_IFlowObject_Branch_Branch_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664208 /*0x06000390*/);
    ExecutionEngine.NativeMethodInfoPtr_Log_Private_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664209);
    ExecutionEngine.NativeMethodInfoPtr_Indent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664210);
    ExecutionEngine.NativeMethodInfoPtr_Outdent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664211);
    ExecutionEngine.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664212);
    ExecutionEngine.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664213);
    ExecutionEngine.NativeMethodInfoPtr_RebuildStopsOnCache_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, 100664214);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 996222, RefRangeEnd = 996223, XrefRangeStart = 996213, XrefRangeEnd = 996222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExecutionEngine(IArticyFlowPlayerCallbacks aCallback)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCallback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr__ctor_Public_Void_IArticyFlowPlayerCallbacks_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IgnoreInvalidBranches
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_IgnoreInvalidBranches_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_IgnoreInvalidBranches_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe BaseGlobalVariables VariableStorage
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_VariableStorage_Public_get_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_VariableStorage_Public_set_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IBaseScriptMethodProvider MethodProvider
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_MethodProvider_Public_get_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_MethodProvider_Public_set_Void_IBaseScriptMethodProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_UseOldInputPinResolving_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_UseOldInputPinResolving_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PausableObjectTypes StopsOn
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_StopsOn_Public_get_PausableObjectTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PausableObjectTypes*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 996224, RefRangeEnd = 996232, XrefRangeStart = 996223, XrefRangeEnd = 996224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_StopsOn_Public_set_Void_PausableObjectTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IFlowObject CurrentNode
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_CurrentNode_Public_get_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_CurrentNode_Private_set_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyObject StartNode
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_StartNode_Public_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 996233, RefRangeEnd = 996236, XrefRangeStart = 996232, XrefRangeEnd = 996233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_set_StartNode_Public_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IList<Branch> AvailableBranches
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 996263, RefRangeEnd = 996270, XrefRangeStart = 996236, XrefRangeEnd = 996263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_AvailableBranches_Public_get_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num3);
    }
  }

  public unsafe IList<Branch> CachedAvailableBranches
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 996310, RefRangeEnd = 996312, XrefRangeStart = 996270, XrefRangeEnd = 996310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_get_CachedAvailableBranches_Internal_get_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996312, XrefRangeEnd = 996326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateBranches()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_UpdateBranches_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 996326, RefRangeEnd = 996329, XrefRangeStart = 996326, XrefRangeEnd = 996326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 996461, RefRangeEnd = 996465, XrefRangeStart = 996329, XrefRangeEnd = 996461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RecalculateBranches()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_RecalculateBranches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 996526, RefRangeEnd = 996528, XrefRangeStart = 996465, XrefRangeEnd = 996526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnsureValidStop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_EnsureValidStop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 996645, RefRangeEnd = 996648, XrefRangeStart = 996528, XrefRangeEnd = 996645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Next(Branch aBranch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_Next_Public_Void_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996648, XrefRangeEnd = 996649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsCurrentNodeAStop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_IsCurrentNodeAStop_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 996660, RefRangeEnd = 996666, XrefRangeStart = 996649, XrefRangeEnd = 996660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsNodeAStop(IFlowObject aNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNode)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_IsNodeAStop_Internal_Boolean_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 997318, RefRangeEnd = 997336, XrefRangeStart = 996666, XrefRangeEnd = 997318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TraverseFlow(
    IFlowObject aCurrentNode,
    Branch aBranch = null,
    Branch aPreviouslyBranch = null,
    bool aSkipNextPause = false,
    bool aInvalidateLocallyNewBranch = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aCurrentNode);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPreviouslyBranch);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aSkipNextPause;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aInvalidateLocallyNewBranch;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_TraverseFlow_Private_Void_IFlowObject_Branch_Branch_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Log(string aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_Log_Private_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Indent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_Indent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Outdent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_Outdent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 997336, XrefRangeEnd = 997337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 997417, RefRangeEnd = 997421, XrefRangeStart = 997337, XrefRangeEnd = 997417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RebuildStopsOnCache()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.NativeMethodInfoPtr_RebuildStopsOnCache_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public void Log(string aMessage, params Il2CppSystem.Object[] aParams)
  {
    this.Log(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe PausableObjectTypes DefaultStopOn
  {
    get
    {
      PausableObjectTypes defaultStopOn;
      IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.NativeFieldInfoPtr_DefaultStopOn, (void*) &defaultStopOn);
      return defaultStopOn;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.NativeFieldInfoPtr_DefaultStopOn, (void*) &value);
    }
  }

  public unsafe bool _IgnoreInvalidBranches_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__IgnoreInvalidBranches_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__IgnoreInvalidBranches_k__BackingField)) = value;
    }
  }

  public unsafe BaseGlobalVariables _VariableStorage_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__VariableStorage_k__BackingField));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__VariableStorage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IBaseScriptMethodProvider _MethodProvider_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__MethodProvider_k__BackingField));
      return num == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__MethodProvider_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _UseOldInputPinResolving_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__UseOldInputPinResolving_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__UseOldInputPinResolving_k__BackingField)) = value;
    }
  }

  public unsafe IFlowObject _CurrentNode_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__CurrentNode_k__BackingField));
      return num == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr__CurrentNode_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IComparer<Branch> BranchSorting
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_BranchSorting));
      return num == System.IntPtr.Zero ? (IComparer<Branch>) null : Il2CppObjectPool.Get<IComparer<Branch>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_BranchSorting), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int mRecursion
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mRecursion));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mRecursion)) = value;
    }
  }

  public unsafe int mNextBranchId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mNextBranchId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mNextBranchId)) = value;
    }
  }

  public unsafe int infiniteLoopCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_infiniteLoopCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_infiniteLoopCounter)) = value;
    }
  }

  public unsafe List<Branch> mCurrentBranches
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mCurrentBranches));
      return num == System.IntPtr.Zero ? (List<Branch>) null : Il2CppObjectPool.Get<List<Branch>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mCurrentBranches), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PausableObjectTypes mStopsOn
  {
    get
    {
      return *(PausableObjectTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStopsOn));
    }
    [param: In] set
    {
      *(PausableObjectTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStopsOn)) = value;
    }
  }

  public unsafe bool mFirstTraversal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mFirstTraversal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mFirstTraversal)) = value;
    }
  }

  public unsafe bool mIsVeryFirstNextCall
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mIsVeryFirstNextCall));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mIsVeryFirstNextCall)) = value;
    }
  }

  public unsafe IFlowObject mSkipNextIncreaseSeenForNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mSkipNextIncreaseSeenForNode));
      return num == System.IntPtr.Zero ? (IFlowObject) null : Il2CppObjectPool.Get<IFlowObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mSkipNextIncreaseSeenForNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyObject mStartNode
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStartNode));
      return num == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStartNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<ulong> mOriginPinId
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mOriginPinId);
      return new Il2CppSystem.Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mOriginPinId), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe HashSet<Il2CppSystem.Type> mStopsOnCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStopsOnCache));
      return num == System.IntPtr.Zero ? (HashSet<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<HashSet<Il2CppSystem.Type>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mStopsOnCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IArticyFlowPlayerCallbacks mCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mCallback));
      return num == System.IntPtr.Zero ? (IArticyFlowPlayerCallbacks) null : Il2CppObjectPool.Get<IArticyFlowPlayerCallbacks>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExecutionEngine.NativeFieldInfoPtr_mCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.ExecutionEngine+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__38_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__38_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__38_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__38_3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateBranches_b__38_0_Internal_Boolean_Branch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateBranches_b__38_1_Internal_Boolean_Branch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateBranches_b__38_2_Internal_Boolean_Branch_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RecalculateBranches_b__38_3_Internal_Boolean_Branch_0;

    static __c()
    {
      Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExecutionEngine>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr);
      ExecutionEngine.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, "<>9");
      ExecutionEngine.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, "<>9__38_0");
      ExecutionEngine.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, "<>9__38_1");
      ExecutionEngine.__c.NativeFieldInfoPtr___9__38_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, "<>9__38_2");
      ExecutionEngine.__c.NativeFieldInfoPtr___9__38_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, "<>9__38_3");
      ExecutionEngine.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, 100664217);
      ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_0_Internal_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, 100664218);
      ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_1_Internal_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, 100664219);
      ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_2_Internal_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, 100664220);
      ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_3_Internal_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr, 100664221);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExecutionEngine.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _RecalculateBranches_b__38_0(Branch b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_0_Internal_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _RecalculateBranches_b__38_1(Branch b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_1_Internal_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _RecalculateBranches_b__38_2(Branch b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_2_Internal_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool _RecalculateBranches_b__38_3(Branch b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExecutionEngine.__c.NativeMethodInfoPtr__RecalculateBranches_b__38_3_Internal_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe ExecutionEngine.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ExecutionEngine.__c) null : Il2CppObjectPool.Get<ExecutionEngine.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Branch, bool> __9__38_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Branch, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Branch, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Branch, bool> __9__38_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Branch, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Branch, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Branch, bool> __9__38_2
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_2, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Branch, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Branch, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Branch, bool> __9__38_3
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_3, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Branch, bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Branch, bool>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ExecutionEngine.__c.NativeFieldInfoPtr___9__38_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
