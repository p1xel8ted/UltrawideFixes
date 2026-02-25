// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnitySynchronizationContext
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class UnitySynchronizationContext(System.IntPtr pointer) : SynchronizationContext(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AsyncWorkQueue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentFrameWork;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MainThreadID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TrackedCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainThreadId_Internal_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Exec_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0;
  public const int kAwqInitialCapacity = 20;

  static UnitySynchronizationContext()
  {
    Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (UnitySynchronizationContext));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr);
    UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, nameof (m_AsyncWorkQueue));
    UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, nameof (m_CurrentFrameWork));
    UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, nameof (m_MainThreadID));
    UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, nameof (m_TrackedCount));
    UnitySynchronizationContext.NativeMethodInfoPtr_get_MainThreadId_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668425);
    UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668426);
    UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668427);
    UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668428);
    UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668429);
    UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668430);
    UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668431);
    UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668432);
    UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668433);
    UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668434);
    UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668435);
    UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668436);
    UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100668437);
  }

  public unsafe int MainThreadId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_get_MainThreadId_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464308, XrefRangeEnd = 464319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnitySynchronizationContext(int mainThreadID)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mainThreadID
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464319, XrefRangeEnd = 464326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnitySynchronizationContext(
    List<UnitySynchronizationContext.WorkRequest> queue,
    int mainThreadID)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) queue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mainThreadID;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464326, XrefRangeEnd = 464345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Send(SendOrPostCallback callback, Il2CppSystem.Object state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464345, XrefRangeEnd = 464346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OperationStarted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464346, XrefRangeEnd = 464347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OperationCompleted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464347, XrefRangeEnd = 464355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Post(SendOrPostCallback callback, Il2CppSystem.Object state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464355, XrefRangeEnd = 464365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe SynchronizationContext CreateCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SynchronizationContext) null : Il2CppObjectPool.Get<SynchronizationContext>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 464383, RefRangeEnd = 464385, XrefRangeStart = 464365, XrefRangeEnd = 464383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Exec()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464385, XrefRangeEnd = 464386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasPendingTasks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464386, XrefRangeEnd = 464411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeSynchronizationContext()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464411, XrefRangeEnd = 464415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ExecuteTasks()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464415, XrefRangeEnd = 464430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ExecutePendingTasks(long millisecondsTimeout)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &millisecondsTimeout
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue));
      return num == System.IntPtr.Zero ? (List<UnitySynchronizationContext.WorkRequest>) null : Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork));
      return num == System.IntPtr.Zero ? (List<UnitySynchronizationContext.WorkRequest>) null : Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_MainThreadID
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID)) = value;
    }
  }

  public unsafe int m_TrackedCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount)) = value;
    }
  }

  public sealed class WorkRequest : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DelagateCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DelagateState;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_WaitHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

    static WorkRequest()
    {
      Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, nameof (WorkRequest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr);
      UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, nameof (m_DelagateCallback));
      UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, nameof (m_DelagateState));
      UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, nameof (m_WaitHandle));
      UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100668438);
      UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100668439);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 104847, RefRangeEnd = 104851, XrefRangeStart = 104847, XrefRangeEnd = 104851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorkRequest(
      SendOrPostCallback callback,
      Il2CppSystem.Object state,
      ManualResetEvent waitHandle = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) waitHandle);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 464307, RefRangeEnd = 464308, XrefRangeStart = 464303, XrefRangeEnd = 464307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public WorkRequest(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public WorkRequest()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
    {
    }

    public unsafe SendOrPostCallback m_DelagateCallback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback));
        return num == System.IntPtr.Zero ? (SendOrPostCallback) null : Il2CppObjectPool.Get<SendOrPostCallback>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Object m_DelagateState
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ManualResetEvent m_WaitHandle
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle));
        return num == System.IntPtr.Zero ? (ManualResetEvent) null : Il2CppObjectPool.Get<ManualResetEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
