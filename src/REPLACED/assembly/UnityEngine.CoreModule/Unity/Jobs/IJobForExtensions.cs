// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.IJobForExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using System;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs.LowLevel.Unsafe;

#nullable disable
namespace Unity.Jobs;

public static class IJobForExtensions
{
  public static void EarlyJobInit<T>() where T : struct
  {
    throw new NotSupportedException("Method unstripping failed");
  }

  public static IntPtr GetReflectionData<T>() where T : struct
  {
    throw new NotSupportedException("Method unstripping failed");
  }

  public static unsafe JobHandle Schedule<T>(T jobData, int arrayLength, JobHandle dependency) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, ScheduleMode.Single);
    return JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, arrayLength);
  }

  public static unsafe JobHandle ScheduleParallel<T>(
    T jobData,
    int arrayLength,
    int innerloopBatchCount,
    JobHandle dependency)
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, ScheduleMode.Batched);
    return JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, innerloopBatchCount);
  }

  public static unsafe void Run<T>(T jobData, int arrayLength) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, arrayLength);
  }

  public static unsafe JobHandle ScheduleByRef<T>(
    ref T jobData,
    int arrayLength,
    JobHandle dependency)
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, ScheduleMode.Single);
    return JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, arrayLength);
  }

  public static unsafe JobHandle ScheduleParallelByRef<T>(
    ref T jobData,
    int arrayLength,
    int innerloopBatchCount,
    JobHandle dependency)
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), dependency, ScheduleMode.Batched);
    return JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, innerloopBatchCount);
  }

  public static unsafe void RunByRef<T>(ref T jobData, int arrayLength) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobForExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.ScheduleParallelFor(ref parameters, arrayLength, arrayLength);
  }
}
