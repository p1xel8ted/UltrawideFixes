// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.JobHandle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace Unity.Jobs;

[StructLayout(LayoutKind.Explicit)]
public struct JobHandle
{
  private static readonly System.IntPtr NativeFieldInfoPtr_jobGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_version;
  private static readonly System.IntPtr NativeMethodInfoPtr_Complete_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0;
  [FieldOffset(0)]
  public ulong jobGroup;
  [FieldOffset(8)]
  public int version;
  private static readonly JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate ScheduleBatchedJobsAndCompleteAllDelegateField;
  private static readonly JobHandle.CombineDependenciesInternal2_InjectedDelegate CombineDependenciesInternal2_InjectedDelegateField;
  private static readonly JobHandle.CombineDependenciesInternal3_InjectedDelegate CombineDependenciesInternal3_InjectedDelegateField;
  private static readonly JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField;

  static JobHandle()
  {
    Il2CppClassPointerStore<JobHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", nameof (JobHandle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobHandle>.NativeClassPtr);
    JobHandle.NativeFieldInfoPtr_jobGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, nameof (jobGroup));
    JobHandle.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, nameof (version));
    JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663320 /*0x06000018*/);
    JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663321 /*0x06000019*/);
    JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663322 /*0x0600001A*/);
    JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663323 /*0x0600001B*/);
    JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663324 /*0x0600001C*/);
    JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663325 /*0x0600001D*/);
    JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663326 /*0x0600001E*/);
    JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663327 /*0x0600001F*/);
    JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663328 /*0x06000020*/);
    JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, 100663329 /*0x06000021*/);
    JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField = IL2CPP.ResolveICall<JobHandle.ScheduleBatchedJobsAndCompleteAllDelegate>("Unity.Jobs.JobHandle::ScheduleBatchedJobsAndCompleteAll");
    JobHandle.CombineDependenciesInternal2_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal2_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal2_Injected");
    JobHandle.CombineDependenciesInternal3_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CombineDependenciesInternal3_InjectedDelegate>("Unity.Jobs.JobHandle::CombineDependenciesInternal3_Injected");
    JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField = IL2CPP.ResolveICall<JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate>("Unity.Jobs.JobHandle::CheckFenceIsDependencyOrDidSyncFence_Injected");
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 413472, RefRangeEnd = 413499, XrefRangeStart = 413470, XrefRangeEnd = 413472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Complete()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Complete_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool IsCompleted
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 413501, RefRangeEnd = 413503, XrefRangeStart = 413499, XrefRangeEnd = 413501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 413505, RefRangeEnd = 413509, XrefRangeStart = 413503, XrefRangeEnd = 413505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScheduleBatchedJobs()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobs_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413509, XrefRangeEnd = 413511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScheduleBatchedJobsAndComplete(ref JobHandle job)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref job
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndComplete_Private_Static_Void_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 413501, RefRangeEnd = 413503, XrefRangeStart = 413501, XrefRangeEnd = 413503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ScheduleBatchedJobsAndIsCompleted(ref JobHandle job)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref job
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_ScheduleBatchedJobsAndIsCompleted_Private_Static_Boolean_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 413516, RefRangeEnd = 413522, XrefRangeStart = 413511, XrefRangeEnd = 413516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle CombineDependencies(NativeArray<JobHandle> jobs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) jobs))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeArray_1_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 413530, RefRangeEnd = 413536, XrefRangeStart = 413522, XrefRangeEnd = 413530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle CombineDependencies(NativeSlice<JobHandle> jobs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) jobs))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependencies_Public_Static_JobHandle_NativeSlice_1_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413536, XrefRangeEnd = 413538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle CombineDependenciesInternalPtr(void* jobs, int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) jobs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Internal_Static_JobHandle_ptr_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(JobHandle other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_JobHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413538, XrefRangeEnd = 413540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CombineDependenciesInternalPtr_Injected(
    void* jobs,
    int count,
    out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) jobs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobHandle.NativeMethodInfoPtr_CombineDependenciesInternalPtr_Injected_Private_Static_Void_ptr_Void_Int32_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobHandle>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe void CompleteAll(ref JobHandle job0, ref JobHandle job1)
  {
    JobHandle* jobs = stackalloc JobHandle[2]
    {
      job0,
      job1
    };
    JobHandle.ScheduleBatchedJobsAndCompleteAll((void*) jobs, 2);
    job0 = new JobHandle();
    job1 = new JobHandle();
  }

  public static unsafe void CompleteAll(ref JobHandle job0, ref JobHandle job1, ref JobHandle job2)
  {
    JobHandle* jobs = stackalloc JobHandle[3]
    {
      job0,
      job1,
      job2
    };
    JobHandle.ScheduleBatchedJobsAndCompleteAll((void*) jobs, 3);
    job0 = new JobHandle();
    job1 = new JobHandle();
    job2 = new JobHandle();
  }

  public static unsafe void CompleteAll(NativeArray<JobHandle> jobs)
  {
    JobHandle.ScheduleBatchedJobsAndCompleteAll(jobs.GetUnsafeReadOnlyPtr<JobHandle>(), ((NativeArray<JobHandle>) ref jobs).Length);
  }

  public static unsafe void ScheduleBatchedJobsAndCompleteAll(void* jobs, int count)
  {
    JobHandle.ScheduleBatchedJobsAndCompleteAllDelegateField((System.IntPtr) jobs, count);
  }

  public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1)
  {
    return JobHandle.CombineDependenciesInternal2(ref job0, ref job1);
  }

  public static JobHandle CombineDependencies(JobHandle job0, JobHandle job1, JobHandle job2)
  {
    return JobHandle.CombineDependenciesInternal3(ref job0, ref job1, ref job2);
  }

  public static JobHandle CombineDependenciesInternal2(ref JobHandle job0, ref JobHandle job1)
  {
    JobHandle ret;
    JobHandle.CombineDependenciesInternal2_Injected(ref job0, ref job1, out ret);
    return ret;
  }

  public static JobHandle CombineDependenciesInternal3(
    ref JobHandle job0,
    ref JobHandle job1,
    ref JobHandle job2)
  {
    JobHandle ret;
    JobHandle.CombineDependenciesInternal3_Injected(ref job0, ref job1, ref job2, out ret);
    return ret;
  }

  public static bool CheckFenceIsDependencyOrDidSyncFence(JobHandle jobHandle, JobHandle dependsOn)
  {
    return JobHandle.CheckFenceIsDependencyOrDidSyncFence_Injected(ref jobHandle, ref dependsOn);
  }

  public static void CombineDependenciesInternal2_Injected(
    ref JobHandle job0,
    ref JobHandle job1,
    out JobHandle ret)
  {
    JobHandle.CombineDependenciesInternal2_InjectedDelegateField((System.IntPtr) ref job0, (System.IntPtr) ref job1, (System.IntPtr) ref ret);
  }

  public static void CombineDependenciesInternal3_Injected(
    ref JobHandle job0,
    ref JobHandle job1,
    ref JobHandle job2,
    out JobHandle ret)
  {
    JobHandle.CombineDependenciesInternal3_InjectedDelegateField((System.IntPtr) ref job0, (System.IntPtr) ref job1, (System.IntPtr) ref job2, (System.IntPtr) ref ret);
  }

  public static bool CheckFenceIsDependencyOrDidSyncFence_Injected(
    [In] ref JobHandle jobHandle,
    [In] ref JobHandle dependsOn)
  {
    return JobHandle.CheckFenceIsDependencyOrDidSyncFence_InjectedDelegateField((System.IntPtr) ref jobHandle, (System.IntPtr) ref dependsOn);
  }

  private delegate void ScheduleBatchedJobsAndCompleteAllDelegate(System.IntPtr jobs, int count);

  private delegate void CombineDependenciesInternal2_InjectedDelegate(
    System.IntPtr job0,
    System.IntPtr job1,
    [Out] System.IntPtr ret);

  private delegate void CombineDependenciesInternal3_InjectedDelegate(
    System.IntPtr job0,
    System.IntPtr job1,
    System.IntPtr job2,
    [Out] System.IntPtr ret);

  private delegate bool CheckFenceIsDependencyOrDidSyncFence_InjectedDelegate(
    [In] System.IntPtr jobHandle,
    [In] System.IntPtr dependsOn);
}
