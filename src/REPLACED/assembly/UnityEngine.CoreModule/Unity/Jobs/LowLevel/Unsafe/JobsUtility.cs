// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.LowLevel.Unsafe.JobsUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Jobs.LowLevel.Unsafe;

public static class JobsUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_PanicFunction;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0;
  public const int MaxJobThreadCount = 128 /*0x80*/;
  public const int CacheLineSize = 64 /*0x40*/;
  private static readonly JobsUtility.PatchBufferMinMaxRangesDelegate PatchBufferMinMaxRangesDelegateField;
  private static readonly JobsUtility.get_JobDebuggerEnabledDelegate get_JobDebuggerEnabledDelegateField;
  private static readonly JobsUtility.set_JobDebuggerEnabledDelegate set_JobDebuggerEnabledDelegateField;
  private static readonly JobsUtility.get_JobCompilerEnabledDelegate get_JobCompilerEnabledDelegateField;
  private static readonly JobsUtility.GetJobQueueWorkerThreadCountDelegate GetJobQueueWorkerThreadCountDelegateField;
  private static readonly JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate SetJobQueueMaximumActiveThreadCountDelegateField;
  private static readonly JobsUtility.get_JobWorkerMaximumCountDelegate get_JobWorkerMaximumCountDelegateField;
  private static readonly JobsUtility.ResetJobWorkerCountDelegate ResetJobWorkerCountDelegateField;
  private static readonly JobsUtility.GetJobBatchingEnabledDelegate GetJobBatchingEnabledDelegateField;
  private static readonly JobsUtility.GetSystemIdCellPtrDelegate GetSystemIdCellPtrDelegateField;
  private static readonly JobsUtility.ClearSystemIdsDelegate ClearSystemIdsDelegateField;
  private static readonly JobsUtility.GetSystemIdMappingsDelegate GetSystemIdMappingsDelegateField;
  private static readonly JobsUtility.Schedule_InjectedDelegate Schedule_InjectedDelegateField;
  private static readonly JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate ScheduleParallelForDeferArraySize_InjectedDelegateField;
  private static readonly JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate ScheduleParallelForTransformReadOnly_InjectedDelegateField;

  static JobsUtility()
  {
    Il2CppClassPointerStore<JobsUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", nameof (JobsUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr);
    JobsUtility.NativeFieldInfoPtr_PanicFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, nameof (PanicFunction));
    JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663331 /*0x06000023*/);
    JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663332 /*0x06000024*/);
    JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663333 /*0x06000025*/);
    JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663334 /*0x06000026*/);
    JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663335 /*0x06000027*/);
    JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663336 /*0x06000028*/);
    JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663337 /*0x06000029*/);
    JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663338 /*0x0600002A*/);
    JobsUtility.NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663339 /*0x0600002B*/);
    JobsUtility.NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663340 /*0x0600002C*/);
    JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663341 /*0x0600002D*/);
    JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663342 /*0x0600002E*/);
    JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, 100663343 /*0x0600002F*/);
    JobsUtility.PatchBufferMinMaxRangesDelegateField = IL2CPP.ResolveICall<JobsUtility.PatchBufferMinMaxRangesDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::PatchBufferMinMaxRanges");
    JobsUtility.get_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobDebuggerEnabled");
    JobsUtility.set_JobDebuggerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.set_JobDebuggerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::set_JobDebuggerEnabled");
    JobsUtility.get_JobCompilerEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobCompilerEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobCompilerEnabled");
    JobsUtility.GetJobQueueWorkerThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobQueueWorkerThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobQueueWorkerThreadCount");
    JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField = IL2CPP.ResolveICall<JobsUtility.SetJobQueueMaximumActiveThreadCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::SetJobQueueMaximumActiveThreadCount");
    JobsUtility.get_JobWorkerMaximumCountDelegateField = IL2CPP.ResolveICall<JobsUtility.get_JobWorkerMaximumCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::get_JobWorkerMaximumCount");
    JobsUtility.ResetJobWorkerCountDelegateField = IL2CPP.ResolveICall<JobsUtility.ResetJobWorkerCountDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ResetJobWorkerCount");
    JobsUtility.GetJobBatchingEnabledDelegateField = IL2CPP.ResolveICall<JobsUtility.GetJobBatchingEnabledDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetJobBatchingEnabled");
    JobsUtility.GetSystemIdCellPtrDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdCellPtrDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdCellPtr");
    JobsUtility.ClearSystemIdsDelegateField = IL2CPP.ResolveICall<JobsUtility.ClearSystemIdsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ClearSystemIds");
    JobsUtility.GetSystemIdMappingsDelegateField = IL2CPP.ResolveICall<JobsUtility.GetSystemIdMappingsDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::GetSystemIdMappings");
    JobsUtility.Schedule_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.Schedule_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::Schedule_Injected");
    JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForDeferArraySize_Injected");
    JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField = IL2CPP.ResolveICall<JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegate>("Unity.Jobs.LowLevel.Unsafe.JobsUtility::ScheduleParallelForTransformReadOnly_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 413544, RefRangeEnd = 413545, XrefRangeStart = 413543, XrefRangeEnd = 413544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetJobRange(
    ref JobRanges ranges,
    int jobIndex,
    out int beginIndex,
    out int endIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ranges;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref beginIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref endIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetJobRange_Public_Static_Void_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 413547, RefRangeEnd = 413551, XrefRangeStart = 413545, XrefRangeEnd = 413547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetWorkStealingRange(
    ref JobRanges ranges,
    int jobIndex,
    out int beginIndex,
    out int endIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ranges;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref beginIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref endIndex;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_GetWorkStealingRange_Public_Static_Boolean_byref_JobRanges_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 413553, RefRangeEnd = 413554, XrefRangeStart = 413551, XrefRangeEnd = 413553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle ScheduleParallelFor(
    ref JobsUtility.JobScheduleParameters parameters,
    int arrayLength,
    int innerloopBatchCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &innerloopBatchCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Public_Static_JobHandle_byref_JobScheduleParameters_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 413556, RefRangeEnd = 413557, XrefRangeStart = 413554, XrefRangeEnd = 413556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle ScheduleParallelForTransform(
    ref JobsUtility.JobScheduleParameters parameters,
    System.IntPtr transfromAccesssArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transfromAccesssArray;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Public_Static_JobHandle_byref_JobScheduleParameters_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413557, XrefRangeEnd = 413559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateJobReflectionData(
    Il2CppSystem.Type wrapperJobType,
    Il2CppSystem.Type userJobType,
    Il2CppSystem.Object managedJobFunction0,
    Il2CppSystem.Object managedJobFunction1,
    Il2CppSystem.Object managedJobFunction2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wrapperJobType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) userJobType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction0);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Private_Static_IntPtr_Type_Type_Object_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 413561, RefRangeEnd = 413564, XrefRangeStart = 413559, XrefRangeEnd = 413561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateJobReflectionData(
    Il2CppSystem.Type type,
    Il2CppSystem.Object managedJobFunction0,
    Il2CppSystem.Object managedJobFunction1 = null,
    Il2CppSystem.Object managedJobFunction2 = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction0);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) managedJobFunction2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_IntPtr_Type_Object_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe bool IsExecutingJob
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 413566, RefRangeEnd = 413572, XrefRangeStart = 413564, XrefRangeEnd = 413566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_get_IsExecutingJob_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool JobCompilerEnabled
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 413574, RefRangeEnd = 413576, XrefRangeStart = 413572, XrefRangeEnd = 413574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_set_JobCompilerEnabled_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => JobsUtility.get_JobCompilerEnabledDelegateField();
  }

  public static unsafe int ThreadIndex
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 413578, RefRangeEnd = 413583, XrefRangeStart = 413576, XrefRangeEnd = 413578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_get_ThreadIndex_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe int ThreadIndexCount
  {
    [CallerCount(16 /*0x10*/), CachedScanResults(RefRangeStart = 413585, RefRangeEnd = 413601, XrefRangeStart = 413583, XrefRangeEnd = 413585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_get_ThreadIndexCount_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413601, XrefRangeEnd = 413603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokePanicFunction()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_InvokePanicFunction_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413603, XrefRangeEnd = 413605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScheduleParallelFor_Injected(
    ref JobsUtility.JobScheduleParameters parameters,
    int arrayLength,
    int innerloopBatchCount,
    out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arrayLength;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &innerloopBatchCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelFor_Injected_Private_Static_Void_byref_JobScheduleParameters_Int32_Int32_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413605, XrefRangeEnd = 413607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScheduleParallelForTransform_Injected(
    ref JobsUtility.JobScheduleParameters parameters,
    System.IntPtr transfromAccesssArray,
    out JobHandle ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref parameters;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transfromAccesssArray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobsUtility.NativeMethodInfoPtr_ScheduleParallelForTransform_Injected_Private_Static_Void_byref_JobScheduleParameters_IntPtr_byref_JobHandle_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public JobsUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe JobsUtility.PanicFunction_ PanicFunction
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (JobsUtility.PanicFunction_) null : Il2CppObjectPool.Get<JobsUtility.PanicFunction_>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JobsUtility.NativeFieldInfoPtr_PanicFunction, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static JobHandle Schedule(ref JobsUtility.JobScheduleParameters parameters)
  {
    JobHandle ret;
    JobsUtility.Schedule_Injected(ref parameters, out ret);
    return ret;
  }

  public static unsafe JobHandle ScheduleParallelForDeferArraySize(
    ref JobsUtility.JobScheduleParameters parameters,
    int innerloopBatchCount,
    void* listData,
    void* listDataAtomicSafetyHandle)
  {
    JobHandle ret;
    JobsUtility.ScheduleParallelForDeferArraySize_Injected(ref parameters, innerloopBatchCount, listData, listDataAtomicSafetyHandle, out ret);
    return ret;
  }

  public static JobHandle ScheduleParallelForTransformReadOnly(
    ref JobsUtility.JobScheduleParameters parameters,
    System.IntPtr transfromAccesssArray,
    int innerloopBatchCount)
  {
    JobHandle ret;
    JobsUtility.ScheduleParallelForTransformReadOnly_Injected(ref parameters, transfromAccesssArray, innerloopBatchCount, out ret);
    return ret;
  }

  public static unsafe void PatchBufferMinMaxRanges(
    System.IntPtr bufferRangePatchData,
    void* jobdata,
    int startIndex,
    int rangeSize)
  {
    JobsUtility.PatchBufferMinMaxRangesDelegateField(bufferRangePatchData, (System.IntPtr) jobdata, startIndex, rangeSize);
  }

  public static System.IntPtr CreateJobReflectionData(
    Il2CppSystem.Type type,
    JobType jobType,
    Il2CppSystem.Object managedJobFunction0,
    Il2CppSystem.Object managedJobFunction1 = null,
    Il2CppSystem.Object managedJobFunction2 = null)
  {
    return JobsUtility.CreateJobReflectionData(type, type, managedJobFunction0, managedJobFunction1, managedJobFunction2);
  }

  public static System.IntPtr CreateJobReflectionData(
    Il2CppSystem.Type wrapperJobType,
    Il2CppSystem.Type userJobType,
    JobType jobType,
    Il2CppSystem.Object managedJobFunction0)
  {
    return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, (Il2CppSystem.Object) null, (Il2CppSystem.Object) null);
  }

  public static System.IntPtr CreateJobReflectionData(
    Il2CppSystem.Type wrapperJobType,
    Il2CppSystem.Type userJobType,
    Il2CppSystem.Object managedJobFunction0)
  {
    return JobsUtility.CreateJobReflectionData(wrapperJobType, userJobType, managedJobFunction0, (Il2CppSystem.Object) null, (Il2CppSystem.Object) null);
  }

  public static bool JobDebuggerEnabled
  {
    get => JobsUtility.get_JobDebuggerEnabledDelegateField();
    set => JobsUtility.set_JobDebuggerEnabledDelegateField(value);
  }

  public static int GetJobQueueWorkerThreadCount()
  {
    return JobsUtility.GetJobQueueWorkerThreadCountDelegateField();
  }

  public static void SetJobQueueMaximumActiveThreadCount(int count)
  {
    JobsUtility.SetJobQueueMaximumActiveThreadCountDelegateField(count);
  }

  public static int JobWorkerMaximumCount => JobsUtility.get_JobWorkerMaximumCountDelegateField();

  public static void ResetJobWorkerCount() => JobsUtility.ResetJobWorkerCountDelegateField();

  public static int JobWorkerCount
  {
    get => JobsUtility.GetJobQueueWorkerThreadCount();
    set
    {
      if (value < 0 || value > JobsUtility.JobWorkerMaximumCount)
        throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (JobWorkerCount), Il2CppSystem.String.Format("Invalid JobWorkerCount {0} must be in the range 0 -> {1}", (Il2CppSystem.Object) (System.ValueType) value, (Il2CppSystem.Object) (System.ValueType) JobsUtility.JobWorkerMaximumCount));
      JobsUtility.SetJobQueueMaximumActiveThreadCount(value);
    }
  }

  public static bool GetJobBatchingEnabled() => JobsUtility.GetJobBatchingEnabledDelegateField();

  public static bool JobBatchingEnabled => JobsUtility.GetJobBatchingEnabled();

  public static System.IntPtr GetSystemIdCellPtr() => JobsUtility.GetSystemIdCellPtrDelegateField();

  public static void ClearSystemIds() => JobsUtility.ClearSystemIdsDelegateField();

  public static unsafe int GetSystemIdMappings(JobHandle* handles, int* systemIds, int maxCount)
  {
    return JobsUtility.GetSystemIdMappingsDelegateField((System.IntPtr) handles, (System.IntPtr) systemIds, maxCount);
  }

  public static void Schedule_Injected(
    ref JobsUtility.JobScheduleParameters parameters,
    out JobHandle ret)
  {
    JobsUtility.Schedule_InjectedDelegateField((System.IntPtr) ref parameters, (System.IntPtr) ref ret);
  }

  public static unsafe void ScheduleParallelForDeferArraySize_Injected(
    ref JobsUtility.JobScheduleParameters parameters,
    int innerloopBatchCount,
    void* listData,
    void* listDataAtomicSafetyHandle,
    out JobHandle ret)
  {
    JobsUtility.ScheduleParallelForDeferArraySize_InjectedDelegateField((System.IntPtr) ref parameters, innerloopBatchCount, (System.IntPtr) listData, (System.IntPtr) listDataAtomicSafetyHandle, (System.IntPtr) ref ret);
  }

  public static void ScheduleParallelForTransformReadOnly_Injected(
    ref JobsUtility.JobScheduleParameters parameters,
    System.IntPtr transfromAccesssArray,
    int innerloopBatchCount,
    out JobHandle ret)
  {
    JobsUtility.ScheduleParallelForTransformReadOnly_InjectedDelegateField((System.IntPtr) ref parameters, transfromAccesssArray, innerloopBatchCount, (System.IntPtr) ref ret);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct JobScheduleParameters
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Dependency;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScheduleMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReflectionData;
    private static readonly System.IntPtr NativeFieldInfoPtr_JobDataPtr;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0;
    [FieldOffset(0)]
    public JobHandle Dependency;
    [FieldOffset(16 /*0x10*/)]
    public int ScheduleMode;
    [FieldOffset(24)]
    public System.IntPtr ReflectionData;
    [FieldOffset(32 /*0x20*/)]
    public System.IntPtr JobDataPtr;

    static JobScheduleParameters()
    {
      Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, nameof (JobScheduleParameters));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr);
      JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_Dependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, nameof (Dependency));
      JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ScheduleMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, nameof (ScheduleMode));
      JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_ReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, nameof (ReflectionData));
      JobsUtility.JobScheduleParameters.NativeFieldInfoPtr_JobDataPtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, nameof (JobDataPtr));
      JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, 100663344 /*0x06000030*/);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 413541, RefRangeEnd = 413543, XrefRangeStart = 413540, XrefRangeEnd = 413541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JobScheduleParameters(
      void* i_jobData,
      System.IntPtr i_reflectionData,
      JobHandle i_dependency,
      ScheduleMode i_scheduleMode)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) i_jobData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &i_reflectionData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &i_dependency;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &i_scheduleMode;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JobsUtility.JobScheduleParameters.NativeMethodInfoPtr__ctor_Public_Void_ptr_Void_IntPtr_JobHandle_ScheduleMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<JobsUtility.JobScheduleParameters>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class PanicFunction_(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

    static PanicFunction_()
    {
      Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JobsUtility>.NativeClassPtr, nameof (PanicFunction_));
      JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663345 /*0x06000031*/);
      JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr, 100663346 /*0x06000032*/);
    }

    [CallerCount(483)]
    [CachedScanResults(RefRangeStart = 231718, RefRangeEnd = 232201, XrefRangeStart = 231718, XrefRangeEnd = 232201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PanicFunction_(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobsUtility.PanicFunction_>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JobsUtility.PanicFunction_.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator JobsUtility.PanicFunction_([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<JobsUtility.PanicFunction_>((System.Delegate) obj0);
    }

    public static JobsUtility.PanicFunction_ operator +(
      [In] JobsUtility.PanicFunction_ obj0,
      [In] JobsUtility.PanicFunction_ obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<JobsUtility.PanicFunction_>();
    }

    public static JobsUtility.PanicFunction_ operator -(
      [In] JobsUtility.PanicFunction_ obj0,
      [In] JobsUtility.PanicFunction_ obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (JobsUtility.PanicFunction_) @delegate : @delegate.Cast<JobsUtility.PanicFunction_>();
    }
  }

  private delegate void PatchBufferMinMaxRangesDelegate(
    System.IntPtr bufferRangePatchData,
    System.IntPtr jobdata,
    int startIndex,
    int rangeSize);

  private delegate bool get_JobDebuggerEnabledDelegate();

  private delegate void set_JobDebuggerEnabledDelegate(bool value);

  private delegate bool get_JobCompilerEnabledDelegate();

  private delegate int GetJobQueueWorkerThreadCountDelegate();

  private delegate void SetJobQueueMaximumActiveThreadCountDelegate(int count);

  private delegate int get_JobWorkerMaximumCountDelegate();

  private delegate void ResetJobWorkerCountDelegate();

  private delegate bool GetJobBatchingEnabledDelegate();

  private delegate System.IntPtr GetSystemIdCellPtrDelegate();

  private delegate void ClearSystemIdsDelegate();

  private delegate int GetSystemIdMappingsDelegate(System.IntPtr handles, System.IntPtr systemIds, int maxCount);

  private delegate void Schedule_InjectedDelegate(System.IntPtr parameters, [Out] System.IntPtr ret);

  private delegate void ScheduleParallelForDeferArraySize_InjectedDelegate(
    System.IntPtr parameters,
    int innerloopBatchCount,
    System.IntPtr listData,
    System.IntPtr listDataAtomicSafetyHandle,
    [Out] System.IntPtr ret);

  private delegate void ScheduleParallelForTransformReadOnly_InjectedDelegate(
    System.IntPtr parameters,
    System.IntPtr transfromAccesssArray,
    int innerloopBatchCount,
    [Out] System.IntPtr ret);
}
