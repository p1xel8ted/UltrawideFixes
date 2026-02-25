// Decompiled with JetBrains decompiler
// Type: UnityEngine.Awaitable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Pool;

#nullable disable
namespace UnityEngine;

public class Awaitable(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__spinLock;
  private static readonly System.IntPtr NativeFieldInfoPtr__pool;
  private static readonly System.IntPtr NativeFieldInfoPtr__handle;
  private static readonly System.IntPtr NativeFieldInfoPtr__exceptionToRethrow;
  private static readonly System.IntPtr NativeFieldInfoPtr__managedAwaitableDone;
  private static readonly System.IntPtr NativeFieldInfoPtr__completionThreadAffinity;
  private static readonly System.IntPtr NativeFieldInfoPtr__continuation;
  private static readonly System.IntPtr NativeFieldInfoPtr__cancelTokenRegistration;
  private static readonly System.IntPtr NativeFieldInfoPtr__managedCompletionQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp;
  private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration;
  private static readonly System.IntPtr NativeFieldInfoPtr__nextFrameAwaitables;
  private static readonly System.IntPtr NativeFieldInfoPtr__endOfFrameAwaitables;
  private static readonly System.IntPtr NativeFieldInfoPtr__synchronizationContext;
  private static readonly System.IntPtr NativeFieldInfoPtr__mainThreadId;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncOperation_Public_Static_Awaitable_AsyncOperation_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromAsyncOperationInternal_Private_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunContinuation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AttachManagedGCHandleToNativeAwaitable_Private_Static_Void_IntPtr_UIntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CancelNativeAwaitable_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NewManagedAwaitable_Internal_Static_Awaitable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromNativeAwaitableHandle_Private_Static_Awaitable_IntPtr_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WireupCancellation_Private_Static_Void_Awaitable_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_Exception_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsLogicallyCompletedNoLock_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetContinuation_Internal_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowIfNotMainThread_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndOfFrameAsync_Public_Static_Awaitable_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureDelayedCallWiredUp_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WireupNextFrameAndEndOfFrameCallbacks_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0;
  private static readonly Awaitable.NextFrameInternalDelegate NextFrameInternalDelegateField;
  private static readonly Awaitable.WaitForScondsInternalDelegate WaitForScondsInternalDelegateField;
  private static readonly Awaitable.FixedUpdateInternalDelegate FixedUpdateInternalDelegateField;
  private static readonly Awaitable.EndOfFrameInternalDelegate EndOfFrameInternalDelegateField;

  static Awaitable()
  {
    Il2CppClassPointerStore<Awaitable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Awaitable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable>.NativeClassPtr);
    Awaitable.NativeFieldInfoPtr__spinLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_spinLock));
    Awaitable.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_pool));
    Awaitable.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_handle));
    Awaitable.NativeFieldInfoPtr__exceptionToRethrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_exceptionToRethrow));
    Awaitable.NativeFieldInfoPtr__managedAwaitableDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_managedAwaitableDone));
    Awaitable.NativeFieldInfoPtr__completionThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_completionThreadAffinity));
    Awaitable.NativeFieldInfoPtr__continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_continuation));
    Awaitable.NativeFieldInfoPtr__cancelTokenRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_cancelTokenRegistration));
    Awaitable.NativeFieldInfoPtr__managedCompletionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_managedCompletionQueue));
    Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_nextFrameAndEndOfFrameWiredUp));
    Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_nextFrameAndEndOfFrameWiredUpCTRegistration));
    Awaitable.NativeFieldInfoPtr__nextFrameAwaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_nextFrameAwaitables));
    Awaitable.NativeFieldInfoPtr__endOfFrameAwaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_endOfFrameAwaitables));
    Awaitable.NativeFieldInfoPtr__synchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_synchronizationContext));
    Awaitable.NativeFieldInfoPtr__mainThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (_mainThreadId));
    Awaitable.NativeMethodInfoPtr_FromAsyncOperation_Public_Static_Awaitable_AsyncOperation_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667873);
    Awaitable.NativeMethodInfoPtr_FromAsyncOperationInternal_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667874);
    Awaitable.NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667875);
    Awaitable.NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667876);
    Awaitable.NativeMethodInfoPtr_RunContinuation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667877);
    Awaitable.NativeMethodInfoPtr_AttachManagedGCHandleToNativeAwaitable_Private_Static_Void_IntPtr_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667878);
    Awaitable.NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667879);
    Awaitable.NativeMethodInfoPtr_CancelNativeAwaitable_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667880);
    Awaitable.NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667881);
    Awaitable.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667882);
    Awaitable.NativeMethodInfoPtr_NewManagedAwaitable_Internal_Static_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667883);
    Awaitable.NativeMethodInfoPtr_FromNativeAwaitableHandle_Private_Static_Awaitable_IntPtr_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667884);
    Awaitable.NativeMethodInfoPtr_WireupCancellation_Private_Static_Void_Awaitable_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667885);
    Awaitable.NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667886);
    Awaitable.NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667887);
    Awaitable.NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667888);
    Awaitable.NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667889);
    Awaitable.NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667890);
    Awaitable.NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667891);
    Awaitable.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667892);
    Awaitable.NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667893);
    Awaitable.NativeMethodInfoPtr_get_IsLogicallyCompletedNoLock_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667894);
    Awaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667895);
    Awaitable.NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667896);
    Awaitable.NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667897);
    Awaitable.NativeMethodInfoPtr_SetContinuation_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667898);
    Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667899);
    Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667900);
    Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667901);
    Awaitable.NativeMethodInfoPtr_ThrowIfNotMainThread_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667902);
    Awaitable.NativeMethodInfoPtr_EndOfFrameAsync_Public_Static_Awaitable_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667903);
    Awaitable.NativeMethodInfoPtr_EnsureDelayedCallWiredUp_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667904 /*0x06001200*/);
    Awaitable.NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667905);
    Awaitable.NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667906);
    Awaitable.NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667907);
    Awaitable.NativeMethodInfoPtr_WireupNextFrameAndEndOfFrameCallbacks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667908);
    Awaitable.NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, 100667909);
    Awaitable.NextFrameInternalDelegateField = IL2CPP.ResolveICall<Awaitable.NextFrameInternalDelegate>("UnityEngine.Awaitable::NextFrameInternal");
    Awaitable.WaitForScondsInternalDelegateField = IL2CPP.ResolveICall<Awaitable.WaitForScondsInternalDelegate>("UnityEngine.Awaitable::WaitForScondsInternal");
    Awaitable.FixedUpdateInternalDelegateField = IL2CPP.ResolveICall<Awaitable.FixedUpdateInternalDelegate>("UnityEngine.Awaitable::FixedUpdateInternal");
    Awaitable.EndOfFrameInternalDelegateField = IL2CPP.ResolveICall<Awaitable.EndOfFrameInternalDelegate>("UnityEngine.Awaitable::EndOfFrameInternal");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442919, XrefRangeEnd = 442929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Awaitable FromAsyncOperation(
    AsyncOperation op,
    CancellationToken cancellationToken = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_FromAsyncOperation_Public_Static_Awaitable_AsyncOperation_CancellationToken_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 442931, RefRangeEnd = 442934, XrefRangeStart = 442929, XrefRangeEnd = 442931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr FromAsyncOperationInternal(System.IntPtr asyncOperation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &asyncOperation
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_FromAsyncOperationInternal_Private_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1564)]
  [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Awaitable.Awaiter GetAwaiter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_GetAwaiter_Public_Awaiter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Awaitable.Awaiter(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442934, XrefRangeEnd = 442942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetExceptionFromNative(Il2CppSystem.Exception ex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ex)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_SetExceptionFromNative_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442942, XrefRangeEnd = 442949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunContinuation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_RunContinuation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442949, XrefRangeEnd = 442951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AttachManagedGCHandleToNativeAwaitable(
    System.IntPtr nativeAwaitable,
    System.UIntPtr gcHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nativeAwaitable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gcHandle;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_AttachManagedGCHandleToNativeAwaitable_Private_Static_Void_IntPtr_UIntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442951, XrefRangeEnd = 442953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReleaseNativeAwaitable(System.IntPtr nativeAwaitable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nativeAwaitable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_ReleaseNativeAwaitable_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442953, XrefRangeEnd = 442955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CancelNativeAwaitable(System.IntPtr nativeAwaitable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nativeAwaitable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_CancelNativeAwaitable_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442955, XrefRangeEnd = 442957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int IsNativeAwaitableCompleted(System.IntPtr nativeAwaitable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nativeAwaitable
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_IsNativeAwaitableCompleted_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442957, XrefRangeEnd = 442958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Awaitable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442972, RefRangeEnd = 442973, XrefRangeStart = 442958, XrefRangeEnd = 442972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Awaitable NewManagedAwaitable()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_NewManagedAwaitable_Internal_Static_Awaitable_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442973, XrefRangeEnd = 442999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Awaitable FromNativeAwaitableHandle(
    System.IntPtr nativeHandle,
    CancellationToken cancellationToken)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nativeHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_FromNativeAwaitableHandle_Private_Static_Awaitable_IntPtr_CancellationToken_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442999, XrefRangeEnd = 443033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WireupCancellation(
    Awaitable awaitable,
    CancellationToken cancellationToken)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) awaitable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_WireupCancellation_Private_Static_Void_Awaitable_CancellationToken_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443033, XrefRangeEnd = 443039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool MatchCompletionThreadAffinity(
    Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &awaiterCompletionThreadAffinity
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_MatchCompletionThreadAffinity_Private_Static_Boolean_AwaiterCompletionThreadAffinity_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443039, XrefRangeEnd = 443048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RaiseManagedCompletion(Il2CppSystem.Exception exception)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 443058, RefRangeEnd = 443061, XrefRangeStart = 443048, XrefRangeEnd = 443058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RunOrScheduleContinuation(
    Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity,
    Il2CppSystem.Action continuation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &awaiterCompletionThreadAffinity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_RunOrScheduleContinuation_Private_Void_AwaiterCompletionThreadAffinity_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443061, XrefRangeEnd = 443063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DoRunContinuationOnSynchonizationContext(Il2CppSystem.Object continuation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_DoRunContinuationOnSynchonizationContext_Private_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443063, XrefRangeEnd = 443071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RaiseManagedCompletion()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_RaiseManagedCompletion_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 443114, RefRangeEnd = 443123, XrefRangeStart = 443071, XrefRangeEnd = 443114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PropagateExceptionAndRelease()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_PropagateExceptionAndRelease_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 443156, RefRangeEnd = 443157, XrefRangeStart = 443123, XrefRangeEnd = 443156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cancel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsCompletedNoLock
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443157, XrefRangeEnd = 443172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_get_IsCompletedNoLock_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsLogicallyCompletedNoLock
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443172, XrefRangeEnd = 443187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_get_IsLogicallyCompletedNoLock_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsCompleted
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 443214, RefRangeEnd = 443217, XrefRangeStart = 443187, XrefRangeEnd = 443214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsDettachedOrCompleted
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 443245, RefRangeEnd = 443246, XrefRangeStart = 443217, XrefRangeEnd = 443245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_get_IsDettachedOrCompleted_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443246, XrefRangeEnd = 443249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Awaitable.AwaitableHandle CheckPointerValidity()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_CheckPointerValidity_Private_AwaitableHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Awaitable.AwaitableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 443274, RefRangeEnd = 443277, XrefRangeStart = 443249, XrefRangeEnd = 443274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetContinuation(Il2CppSystem.Action continuation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_SetContinuation_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443277, XrefRangeEnd = 443278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool System_Collections_IEnumerator_MoveNext()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void System_Collections_IEnumerator_Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443278, XrefRangeEnd = 443284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ThrowIfNotMainThread()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_ThrowIfNotMainThread_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443284, XrefRangeEnd = 443345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Awaitable EndOfFrameAsync(CancellationToken cancellationToken = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_EndOfFrameAsync_Public_Static_Awaitable_CancellationToken_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 443368, RefRangeEnd = 443369, XrefRangeStart = 443345, XrefRangeEnd = 443368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EnsureDelayedCallWiredUp()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_EnsureDelayedCallWiredUp_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443369, XrefRangeEnd = 443379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDelayedCallManagerCleared()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_OnDelayedCallManagerCleared_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443379, XrefRangeEnd = 443385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_OnUpdate_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443385, XrefRangeEnd = 443391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnEndOfFrame()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_OnEndOfFrame_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443391, XrefRangeEnd = 443432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WireupNextFrameAndEndOfFrameCallbacks()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_WireupNextFrameAndEndOfFrameCallbacks_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 443432, XrefRangeEnd = 443437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSynchronizationContext(
    UnitySynchronizationContext synchronizationContext)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) synchronizationContext)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Awaitable.NativeMethodInfoPtr_SetSynchronizationContext_Internal_Static_Void_UnitySynchronizationContext_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpinLock _spinLock
  {
    get
    {
      return *(SpinLock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__spinLock));
    }
    [param: In] set
    {
      *(SpinLock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__spinLock)) = value;
    }
  }

  public static unsafe ThreadLocal<ObjectPool<Awaitable>> _pool
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__pool, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ThreadLocal<ObjectPool<Awaitable>>) null : Il2CppObjectPool.Get<ThreadLocal<ObjectPool<Awaitable>>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__pool, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Awaitable.AwaitableHandle _handle
  {
    get
    {
      return *(Awaitable.AwaitableHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__handle));
    }
    [param: In] set
    {
      *(Awaitable.AwaitableHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__handle)) = value;
    }
  }

  public unsafe ExceptionDispatchInfo _exceptionToRethrow
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__exceptionToRethrow));
      return num == System.IntPtr.Zero ? (ExceptionDispatchInfo) null : Il2CppObjectPool.Get<ExceptionDispatchInfo>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__exceptionToRethrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _managedAwaitableDone
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__managedAwaitableDone));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__managedAwaitableDone)) = value;
    }
  }

  public unsafe Awaitable.AwaiterCompletionThreadAffinity _completionThreadAffinity
  {
    get
    {
      return *(Awaitable.AwaiterCompletionThreadAffinity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__completionThreadAffinity));
    }
    [param: In] set
    {
      *(Awaitable.AwaiterCompletionThreadAffinity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__completionThreadAffinity)) = value;
    }
  }

  public unsafe Il2CppSystem.Action _continuation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__continuation));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__continuation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Nullable<CancellationTokenRegistration> _cancelTokenRegistration
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__cancelTokenRegistration);
      return new Il2CppSystem.Nullable<CancellationTokenRegistration>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<CancellationTokenRegistration>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__cancelTokenRegistration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<CancellationTokenRegistration>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Awaitable.DoubleBufferedAwaitableList _managedCompletionQueue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__managedCompletionQueue));
      return num == System.IntPtr.Zero ? (Awaitable.DoubleBufferedAwaitableList) null : Il2CppObjectPool.Get<Awaitable.DoubleBufferedAwaitableList>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.NativeFieldInfoPtr__managedCompletionQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool _nextFrameAndEndOfFrameWiredUp
  {
    get
    {
      bool endOfFrameWiredUp;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp, (void*) &endOfFrameWiredUp);
      return endOfFrameWiredUp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUp, (void*) &value);
    }
  }

  public static unsafe CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration, (void*) num);
      return new CancellationTokenRegistration(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationTokenRegistration>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__nextFrameAndEndOfFrameWiredUpCTRegistration, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }

  public static unsafe Awaitable.DoubleBufferedAwaitableList _nextFrameAwaitables
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__nextFrameAwaitables, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Awaitable.DoubleBufferedAwaitableList) null : Il2CppObjectPool.Get<Awaitable.DoubleBufferedAwaitableList>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__nextFrameAwaitables, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Awaitable.DoubleBufferedAwaitableList _endOfFrameAwaitables
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__endOfFrameAwaitables, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Awaitable.DoubleBufferedAwaitableList) null : Il2CppObjectPool.Get<Awaitable.DoubleBufferedAwaitableList>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__endOfFrameAwaitables, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe SynchronizationContext _synchronizationContext
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__synchronizationContext, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (SynchronizationContext) null : Il2CppObjectPool.Get<SynchronizationContext>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__synchronizationContext, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int _mainThreadId
  {
    get
    {
      int mainThreadId;
      IL2CPP.il2cpp_field_static_get_value(Awaitable.NativeFieldInfoPtr__mainThreadId, (void*) &mainThreadId);
      return mainThreadId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Awaitable.NativeFieldInfoPtr__mainThreadId, (void*) &value);
    }
  }

  public static Awaitable NextFrameAsync(CancellationToken cancellationToken = null)
  {
    Awaitable.ThrowIfNotMainThread();
    ((CancellationToken) ref cancellationToken).ThrowIfCancellationRequested();
    Awaitable.EnsureDelayedCallWiredUp();
    Awaitable awaitable = Awaitable.NewManagedAwaitable();
    Awaitable._nextFrameAwaitables.Add(awaitable, Time.frameCount + 1);
    awaitable._managedCompletionQueue = Awaitable._nextFrameAwaitables;
    if (((CancellationToken) ref cancellationToken).CanBeCanceled)
      Awaitable.WireupCancellation(awaitable, cancellationToken);
    return awaitable;
  }

  public static Awaitable WaitForSecondsAsync(float seconds, CancellationToken cancellationToken = null)
  {
    Awaitable.ThrowIfNotMainThread();
    ((CancellationToken) ref cancellationToken).ThrowIfCancellationRequested();
    return Awaitable.FromNativeAwaitableHandle(Awaitable.WaitForScondsInternal(seconds), cancellationToken);
  }

  public static Awaitable FixedUpdateAsync(CancellationToken cancellationToken = null)
  {
    Awaitable.ThrowIfNotMainThread();
    ((CancellationToken) ref cancellationToken).ThrowIfCancellationRequested();
    return Awaitable.FromNativeAwaitableHandle(Awaitable.FixedUpdateInternal(), cancellationToken);
  }

  public static System.IntPtr NextFrameInternal() => Awaitable.NextFrameInternalDelegateField();

  public static System.IntPtr WaitForScondsInternal(float seconds)
  {
    return Awaitable.WaitForScondsInternalDelegateField(seconds);
  }

  public static System.IntPtr FixedUpdateInternal() => Awaitable.FixedUpdateInternalDelegateField();

  public static System.IntPtr EndOfFrameInternal() => Awaitable.EndOfFrameInternalDelegateField();

  public Awaitable.AwaiterCompletionThreadAffinity CompletionThreadAffinity
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public enum AwaiterCompletionThreadAffinity
  {
    None,
    MainThread,
    BackgroundThread,
  }

  public sealed class AwaitableAsyncMethodBuilder : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__stateMachineBox;
    private static readonly System.IntPtr NativeFieldInfoPtr__resultingCoroutine;

    static AwaitableAsyncMethodBuilder()
    {
      Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (AwaitableAsyncMethodBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr);
      Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__stateMachineBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr, nameof (_stateMachineBox));
      Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__resultingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr, nameof (_resultingCoroutine));
    }

    public AwaitableAsyncMethodBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AwaitableAsyncMethodBuilder()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr))
    {
    }

    public unsafe Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox _stateMachineBox
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__stateMachineBox));
        return num == System.IntPtr.Zero ? (Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox) null : Il2CppObjectPool.Get<Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__stateMachineBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Awaitable _resultingCoroutine
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__resultingCoroutine));
        return num == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder.NativeFieldInfoPtr__resultingCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class IStateMachineBox(System.IntPtr pointer) : Il2CppObjectBase(pointer)
    {
      static IStateMachineBox()
      {
        Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder>.NativeClassPtr, nameof (IStateMachineBox));
      }
    }
  }

  public sealed class AwaitableAsyncMethodBuilder<T> : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__stateMachineBox;
    private static readonly System.IntPtr NativeFieldInfoPtr__resultingCoroutine;

    static AwaitableAsyncMethodBuilder()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "AwaitableAsyncMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr);
      Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__stateMachineBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr, nameof (_stateMachineBox));
      Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__resultingCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr, nameof (_resultingCoroutine));
    }

    public AwaitableAsyncMethodBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AwaitableAsyncMethodBuilder()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr))
    {
    }

    public unsafe Awaitable.AwaitableAsyncMethodBuilder<T>.IStateMachineBox _stateMachineBox
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__stateMachineBox));
        return num == System.IntPtr.Zero ? (Awaitable.AwaitableAsyncMethodBuilder<T>.IStateMachineBox) null : Il2CppObjectPool.Get<Awaitable.AwaitableAsyncMethodBuilder<T>.IStateMachineBox>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__stateMachineBox), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Awaitable<T> _resultingCoroutine
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__resultingCoroutine));
        return num == System.IntPtr.Zero ? (Awaitable<T>) null : Il2CppObjectPool.Get<Awaitable<T>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAsyncMethodBuilder<T>.NativeFieldInfoPtr__resultingCoroutine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class IStateMachineBox(System.IntPtr pointer) : Il2CppObjectBase(pointer)
    {
      static IStateMachineBox()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>.IStateMachineBox>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable.AwaitableAsyncMethodBuilder<T>>.NativeClassPtr, nameof (IStateMachineBox<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
      }
    }
  }

  public sealed class Awaiter : Il2CppSystem.ValueType, INotifyCompletion
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__awaited;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Awaitable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

    static Awaiter()
    {
      Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (Awaiter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr);
      Awaitable.Awaiter.NativeFieldInfoPtr__awaited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, nameof (_awaited));
      Awaitable.Awaiter.NativeMethodInfoPtr__ctor_Internal_Void_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, 100667911);
      Awaitable.Awaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, 100667912);
      Awaitable.Awaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, 100667913);
      Awaitable.Awaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr, 100667914);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Awaiter(Awaitable awaited)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) awaited)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.Awaiter.NativeMethodInfoPtr__ctor_Internal_Void_Awaitable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442756, XrefRangeEnd = 442758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void OnCompleted(Il2CppSystem.Action continuation)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) continuation)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.Awaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool IsCompleted
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 442760, RefRangeEnd = 442767, XrefRangeStart = 442758, XrefRangeEnd = 442760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.Awaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442767, XrefRangeEnd = 442769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetResult()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.Awaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Awaiter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Awaiter()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.Awaiter>.NativeClassPtr))
    {
    }

    public unsafe Awaitable _awaited
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.Awaiter.NativeFieldInfoPtr__awaited));
        return num == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.Awaiter.NativeFieldInfoPtr__awaited), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public void OnCompleted(System.Action continuation) => this.OnCompleted((Il2CppSystem.Action) continuation);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct AwaitableHandle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__handle;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManagedHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NullHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AwaitableHandle_IntPtr_0;
    [FieldOffset(0)]
    public readonly System.IntPtr _handle;

    static AwaitableHandle()
    {
      Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (AwaitableHandle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr);
      Awaitable.AwaitableHandle.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, nameof (_handle));
      Awaitable.AwaitableHandle.NativeFieldInfoPtr_ManagedHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, nameof (ManagedHandle));
      Awaitable.AwaitableHandle.NativeFieldInfoPtr_NullHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, nameof (NullHandle));
      Awaitable.AwaitableHandle.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, 100667915);
      Awaitable.AwaitableHandle.NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, 100667916);
      Awaitable.AwaitableHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, 100667918);
      Awaitable.AwaitableHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_AwaitableHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, 100667919);
    }

    public unsafe bool IsNull
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 442769, RefRangeEnd = 442777, XrefRangeStart = 442769, XrefRangeEnd = 442769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableHandle.NativeMethodInfoPtr_get_IsNull_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe bool IsManaged
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442777, XrefRangeEnd = 442781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableHandle.NativeMethodInfoPtr_get_IsManaged_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1564)]
    [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator System.IntPtr(Awaitable.AwaitableHandle handle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &handle
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_AwaitableHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1564)]
    [CachedScanResults(RefRangeStart = 106995, RefRangeEnd = 108559, XrefRangeStart = 106995, XrefRangeEnd = 108559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Awaitable.AwaitableHandle(System.IntPtr handle)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &handle
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableHandle.NativeMethodInfoPtr_op_Implicit_Public_Static_AwaitableHandle_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Awaitable.AwaitableHandle*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Awaitable.AwaitableHandle>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe Awaitable.AwaitableHandle ManagedHandle
    {
      get
      {
        Awaitable.AwaitableHandle managedHandle;
        IL2CPP.il2cpp_field_static_get_value(Awaitable.AwaitableHandle.NativeFieldInfoPtr_ManagedHandle, (void*) &managedHandle);
        return managedHandle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable.AwaitableHandle.NativeFieldInfoPtr_ManagedHandle, (void*) &value);
      }
    }

    public static unsafe Awaitable.AwaitableHandle NullHandle
    {
      get
      {
        Awaitable.AwaitableHandle nullHandle;
        IL2CPP.il2cpp_field_static_get_value(Awaitable.AwaitableHandle.NativeFieldInfoPtr_NullHandle, (void*) &nullHandle);
        return nullHandle;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable.AwaitableHandle.NativeFieldInfoPtr_NullHandle, (void*) &value);
      }
    }
  }

  public sealed class AwaitableAndFrameIndex : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Awaitable_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__FrameIndex_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Awaitable_Int32_0;

    static AwaitableAndFrameIndex()
    {
      Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (AwaitableAndFrameIndex));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr);
      Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__Awaitable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr, "<Awaitable>k__BackingField");
      Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__FrameIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr, "<FrameIndex>k__BackingField");
      Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr, 100667921);
      Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr, 100667922);
      Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr__ctor_Public_Void_Awaitable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr, 100667923);
    }

    public unsafe Awaitable Awaitable
    {
      [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr_get_Awaitable_Public_get_Awaitable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
      }
    }

    public unsafe int FrameIndex
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr_get_FrameIndex_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(529)]
    [CachedScanResults(RefRangeStart = 232843, RefRangeEnd = 233372, XrefRangeStart = 232843, XrefRangeEnd = 233372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AwaitableAndFrameIndex(Awaitable awaitable, int frameIndex)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) awaitable);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &frameIndex;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.AwaitableAndFrameIndex.NativeMethodInfoPtr__ctor_Public_Void_Awaitable_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public AwaitableAndFrameIndex(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public AwaitableAndFrameIndex()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.AwaitableAndFrameIndex>.NativeClassPtr))
    {
    }

    public unsafe Awaitable _Awaitable_k__BackingField
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__Awaitable_k__BackingField));
        return num == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__Awaitable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _FrameIndex_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__FrameIndex_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.AwaitableAndFrameIndex.NativeFieldInfoPtr__FrameIndex_k__BackingField)) = value;
      }
    }
  }

  public class DoubleBufferedAwaitableList(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__awaitables;
    private static readonly System.IntPtr NativeFieldInfoPtr__scratch;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwapAndComplete_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Awaitable_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Void_Awaitable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DoubleBufferedAwaitableList()
    {
      Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, nameof (DoubleBufferedAwaitableList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr);
      Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__awaitables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, nameof (_awaitables));
      Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__scratch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, nameof (_scratch));
      Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_SwapAndComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, 100667924);
      Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Add_Public_Void_Awaitable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, 100667925);
      Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Remove_Public_Void_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, 100667926);
      Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, 100667927);
      Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, 100667928);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 442809, RefRangeEnd = 442811, XrefRangeStart = 442781, XrefRangeEnd = 442809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwapAndComplete()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_SwapAndComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 442814, RefRangeEnd = 442815, XrefRangeStart = 442811, XrefRangeEnd = 442814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Add(Awaitable item, int frameIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &frameIndex;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Add_Public_Void_Awaitable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442815, XrefRangeEnd = 442829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Remove(Awaitable item)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) item)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Remove_Public_Void_Awaitable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442829, XrefRangeEnd = 442831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 442890, RefRangeEnd = 442891, XrefRangeStart = 442831, XrefRangeEnd = 442890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DoubleBufferedAwaitableList()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe List<Awaitable.AwaitableAndFrameIndex> _awaitables
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__awaitables));
        return num == System.IntPtr.Zero ? (List<Awaitable.AwaitableAndFrameIndex>) null : Il2CppObjectPool.Get<List<Awaitable.AwaitableAndFrameIndex>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__awaitables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Awaitable.AwaitableAndFrameIndex> _scratch
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__scratch));
        return num == System.IntPtr.Zero ? (List<Awaitable.AwaitableAndFrameIndex>) null : Il2CppObjectPool.Get<List<Awaitable.AwaitableAndFrameIndex>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.NativeFieldInfoPtr__scratch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("UnityEngine.Awaitable+DoubleBufferedAwaitableList+<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_item;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_AwaitableAndFrameIndex_0;

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr);
        Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr, nameof (item));
        Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr, 100667929);
        Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_AwaitableAndFrameIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr, 100667930);
      }

      [CallerCount(3004)]
      [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      public unsafe bool _Remove_b__0(Awaitable.AwaitableAndFrameIndex x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x))
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeMethodInfoPtr__Remove_b__0_Internal_Boolean_AwaitableAndFrameIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public unsafe Awaitable item
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeFieldInfoPtr_item));
          return num == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Awaitable.DoubleBufferedAwaitableList.__c__DisplayClass4_0.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public sealed class \u003C\u003Ec__DisplayClass4_0
    {
    }
  }

  [ObfuscatedName("UnityEngine.Awaitable+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__26_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__76_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__WireupCancellation_b__26_0_Internal_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0;

    static __c()
    {
      Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Awaitable>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr);
      Awaitable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, "<>9");
      Awaitable.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, "<>9__26_0");
      Awaitable.__c.NativeFieldInfoPtr___9__76_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, "<>9__76_1");
      Awaitable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, 100667932);
      Awaitable.__c.NativeMethodInfoPtr__WireupCancellation_b__26_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, 100667933);
      Awaitable.__c.NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, 100667934);
      Awaitable.__c.NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr, 100667935);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Awaitable.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442891, XrefRangeEnd = 442896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _WireupCancellation_b__26_0(Il2CppSystem.Object coroutine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) coroutine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Awaitable.__c.NativeMethodInfoPtr__WireupCancellation_b__26_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442896, XrefRangeEnd = 442915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectPool<Awaitable> __cctor_b__76_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.__c.NativeMethodInfoPtr___cctor_b__76_0_Internal_ObjectPool_1_Awaitable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ObjectPool<Awaitable>) null : Il2CppObjectPool.Get<ObjectPool<Awaitable>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442915, XrefRangeEnd = 442919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Awaitable __cctor_b__76_1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Awaitable.__c.NativeMethodInfoPtr___cctor_b__76_1_Internal_Awaitable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Awaitable) null : Il2CppObjectPool.Get<Awaitable>(num3);
    }

    public static unsafe Awaitable.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Awaitable.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Awaitable.__c) null : Il2CppObjectPool.Get<Awaitable.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<Il2CppSystem.Object> __9__26_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Awaitable.__c.NativeFieldInfoPtr___9__26_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<Il2CppSystem.Object>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable.__c.NativeFieldInfoPtr___9__26_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Awaitable> __9__76_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(Awaitable.__c.NativeFieldInfoPtr___9__76_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Awaitable>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Awaitable>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Awaitable.__c.NativeFieldInfoPtr___9__76_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }

  private delegate System.IntPtr NextFrameInternalDelegate();

  private delegate System.IntPtr WaitForScondsInternalDelegate(float seconds);

  private delegate System.IntPtr FixedUpdateInternalDelegate();

  private delegate System.IntPtr EndOfFrameInternalDelegate();
}
