// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public static class AsyncReadManagerMetrics
{
  private static readonly AsyncReadManagerMetrics.IsEnabledDelegate IsEnabledDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.IsEnabledDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::IsEnabled");
  private static readonly AsyncReadManagerMetrics.ClearMetrics_InternalDelegate ClearMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.ClearMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::ClearMetrics_Internal");
  private static readonly AsyncReadManagerMetrics.GetMetrics_InternalDelegate GetMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Internal");
  private static readonly AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate GetMetrics_Filtered_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_Filtered_Internal");
  private static readonly AsyncReadManagerMetrics.StartCollectingMetricsDelegate StartCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StartCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StartCollectingMetrics");
  private static readonly AsyncReadManagerMetrics.StopCollectingMetricsDelegate StopCollectingMetricsDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.StopCollectingMetricsDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::StopCollectingMetrics");
  private static readonly AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate GetSummaryMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetrics_Internal");
  private static readonly AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate GetSummaryMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryMetricsWithFilters_Internal");
  private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate GetSummaryOfMetrics_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_Internal");
  private static readonly AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate GetSummaryOfMetrics_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetrics_FromContainer_Internal");
  private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate GetSummaryOfMetricsWithFilters_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_Internal");
  private static readonly AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetSummaryOfMetricsWithFilters_FromContainer_Internal");
  private static readonly AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate GetTotalSizeOfNonASRMReadsBytesDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetTotalSizeOfNonASRMReadsBytes");
  private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal_InjectedDelegate GetMetrics_NoAlloc_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Internal_Injected");
  private static readonly AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegateField = IL2CPP.ResolveICall<AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate>("Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics::GetMetrics_NoAlloc_Filtered_Internal_Injected");

  public static bool IsEnabled() => AsyncReadManagerMetrics.IsEnabledDelegateField();

  public static void ClearMetrics_Internal()
  {
    AsyncReadManagerMetrics.ClearMetrics_InternalDelegateField();
  }

  public static void ClearCompletedMetrics() => AsyncReadManagerMetrics.ClearMetrics_Internal();

  public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Internal(bool clear)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetMetrics_InternalDelegateField(clear);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<AsyncReadManagerRequestMetric>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(num);
  }

  public static void GetMetrics_NoAlloc_Internal(
    List<AsyncReadManagerRequestMetric> metrics,
    bool clear)
  {
    if (metrics == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) metrics, nameof (metrics));
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal_Injected(metrics, clear);
  }

  public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics_Filtered_Internal(
    AsyncReadManagerMetricsFilters filters,
    bool clear)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetMetrics_Filtered_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) filters), clear);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<AsyncReadManagerRequestMetric>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<AsyncReadManagerRequestMetric>>(num);
  }

  public static void GetMetrics_NoAlloc_Filtered_Internal(
    List<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters filters,
    bool clear)
  {
    if (metrics == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) metrics, nameof (metrics));
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal_Injected(metrics, filters, clear);
  }

  public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(
    AsyncReadManagerMetricsFilters filters,
    AsyncReadManagerMetrics.Flags flags)
  {
    bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
    return AsyncReadManagerMetrics.GetMetrics_Filtered_Internal(filters, clear);
  }

  public static void GetMetrics(
    List<AsyncReadManagerRequestMetric> outMetrics,
    AsyncReadManagerMetricsFilters filters,
    AsyncReadManagerMetrics.Flags flags)
  {
    bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal(outMetrics, filters, clear);
  }

  public static Il2CppReferenceArray<AsyncReadManagerRequestMetric> GetMetrics(
    AsyncReadManagerMetrics.Flags flags)
  {
    return AsyncReadManagerMetrics.GetMetrics_Internal((flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead);
  }

  public static void GetMetrics(
    List<AsyncReadManagerRequestMetric> outMetrics,
    AsyncReadManagerMetrics.Flags flags)
  {
    bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal(outMetrics, clear);
  }

  public static void StartCollectingMetrics()
  {
    AsyncReadManagerMetrics.StartCollectingMetricsDelegateField();
  }

  public static void StopCollectingMetrics()
  {
    AsyncReadManagerMetrics.StopCollectingMetricsDelegateField();
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryMetrics_Internal(bool clear)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryMetrics_InternalDelegateField(clear);
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(
    AsyncReadManagerMetrics.Flags flags)
  {
    return AsyncReadManagerMetrics.GetSummaryMetrics_Internal((flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryMetricsWithFilters_Internal(
    AsyncReadManagerMetricsFilters metricsFilters,
    bool clear)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metricsFilters), clear);
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetCurrentSummaryMetrics(
    AsyncReadManagerMetricsFilters metricsFilters,
    AsyncReadManagerMetrics.Flags flags)
  {
    bool clear = (flags & AsyncReadManagerMetrics.Flags.ClearOnRead) == AsyncReadManagerMetrics.Flags.ClearOnRead;
    return AsyncReadManagerMetrics.GetSummaryMetricsWithFilters_Internal(metricsFilters, clear);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_Internal(
    Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryOfMetrics_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics));
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(
    Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics)
  {
    return AsyncReadManagerMetrics.GetSummaryOfMetrics_Internal(metrics);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics_FromContainer_Internal(
    List<AsyncReadManagerRequestMetric> metrics)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics));
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(
    List<AsyncReadManagerRequestMetric> metrics)
  {
    return AsyncReadManagerMetrics.GetSummaryOfMetrics_FromContainer_Internal(metrics);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_Internal(
    Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters metricsFilters)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metricsFilters));
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(
    Il2CppReferenceArray<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters metricsFilters)
  {
    return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_Internal(metrics, metricsFilters);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetricsWithFilters_FromContainer_Internal(
    List<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters metricsFilters)
  {
    System.IntPtr num = AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metricsFilters));
    return num == System.IntPtr.Zero ? (AsyncReadManagerSummaryMetrics) null : Il2CppObjectPool.Get<AsyncReadManagerSummaryMetrics>(num);
  }

  public static AsyncReadManagerSummaryMetrics GetSummaryOfMetrics(
    List<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters metricsFilters)
  {
    return AsyncReadManagerMetrics.GetSummaryOfMetricsWithFilters_FromContainer_Internal(metrics, metricsFilters);
  }

  public static ulong GetTotalSizeOfNonASRMReadsBytes(bool emptyAfterRead)
  {
    return AsyncReadManagerMetrics.GetTotalSizeOfNonASRMReadsBytesDelegateField(emptyAfterRead);
  }

  public static void GetMetrics_NoAlloc_Internal_Injected(
    List<AsyncReadManagerRequestMetric> metrics,
    bool clear)
  {
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics), clear);
  }

  public static void GetMetrics_NoAlloc_Filtered_Internal_Injected(
    List<AsyncReadManagerRequestMetric> metrics,
    AsyncReadManagerMetricsFilters filters,
    bool clear)
  {
    AsyncReadManagerMetrics.GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) metrics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) filters), clear);
  }

  public enum Flags
  {
    None,
    ClearOnRead,
  }

  private delegate bool IsEnabledDelegate();

  private delegate void ClearMetrics_InternalDelegate();

  private delegate System.IntPtr GetMetrics_InternalDelegate(bool clear);

  private delegate System.IntPtr GetMetrics_Filtered_InternalDelegate(System.IntPtr filters, bool clear);

  private delegate void StartCollectingMetricsDelegate();

  private delegate void StopCollectingMetricsDelegate();

  private delegate System.IntPtr GetSummaryMetrics_InternalDelegate(bool clear);

  private delegate System.IntPtr GetSummaryMetricsWithFilters_InternalDelegate(
    System.IntPtr metricsFilters,
    bool clear);

  private delegate System.IntPtr GetSummaryOfMetrics_InternalDelegate(System.IntPtr metrics);

  private delegate System.IntPtr GetSummaryOfMetrics_FromContainer_InternalDelegate(System.IntPtr metrics);

  private delegate System.IntPtr GetSummaryOfMetricsWithFilters_InternalDelegate(
    System.IntPtr metrics,
    System.IntPtr metricsFilters);

  private delegate System.IntPtr GetSummaryOfMetricsWithFilters_FromContainer_InternalDelegate(
    System.IntPtr metrics,
    System.IntPtr metricsFilters);

  private delegate ulong GetTotalSizeOfNonASRMReadsBytesDelegate(bool emptyAfterRead);

  private delegate void GetMetrics_NoAlloc_Internal_InjectedDelegate(System.IntPtr metrics, bool clear);

  private delegate void GetMetrics_NoAlloc_Filtered_Internal_InjectedDelegate(
    System.IntPtr metrics,
    System.IntPtr filters,
    bool clear);
}
