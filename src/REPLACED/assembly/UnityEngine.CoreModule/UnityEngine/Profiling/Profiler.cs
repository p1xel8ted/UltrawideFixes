// Decompiled with JetBrains decompiler
// Type: UnityEngine.Profiling.Profiler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Profiling;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Profiling;

public sealed class Profiler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0;
  public const uint invalidProfilerArea = 4294967295 /*0xFFFFFFFF*/;
  private static readonly Profiler.get_supportedDelegate get_supportedDelegateField;
  private static readonly Profiler.get_enableBinaryLogDelegate get_enableBinaryLogDelegateField;
  private static readonly Profiler.set_enableBinaryLogDelegate set_enableBinaryLogDelegateField;
  private static readonly Profiler.get_maxUsedMemoryDelegate get_maxUsedMemoryDelegateField;
  private static readonly Profiler.set_maxUsedMemoryDelegate set_maxUsedMemoryDelegateField;
  private static readonly Profiler.set_enabledDelegate set_enabledDelegateField;
  private static readonly Profiler.get_enableAllocationCallstacksDelegate get_enableAllocationCallstacksDelegateField;
  private static readonly Profiler.set_enableAllocationCallstacksDelegate set_enableAllocationCallstacksDelegateField;
  private static readonly Profiler.SetAreaEnabledDelegate SetAreaEnabledDelegateField;
  private static readonly Profiler.GetAreaEnabledDelegate GetAreaEnabledDelegateField;
  private static readonly Profiler.EndSampleDelegate EndSampleDelegateField;
  private static readonly Profiler.get_usedHeapSizeLongDelegate get_usedHeapSizeLongDelegateField;
  private static readonly Profiler.GetMonoHeapSizeLongDelegate GetMonoHeapSizeLongDelegateField;
  private static readonly Profiler.SetTempAllocatorRequestedSizeDelegate SetTempAllocatorRequestedSizeDelegateField;
  private static readonly Profiler.GetTempAllocatorSizeDelegate GetTempAllocatorSizeDelegateField;
  private static readonly Profiler.GetTotalUnusedReservedMemoryLongDelegate GetTotalUnusedReservedMemoryLongDelegateField;
  private static readonly Profiler.InternalGetTotalFragmentationInfoDelegate InternalGetTotalFragmentationInfoDelegateField;
  private static readonly Profiler.GetAllocatedMemoryForGraphicsDriverDelegate GetAllocatedMemoryForGraphicsDriverDelegateField;
  private static readonly Profiler.Internal_EmitGlobalMetaData_ArrayDelegate Internal_EmitGlobalMetaData_ArrayDelegateField;
  private static readonly Profiler.Internal_EmitGlobalMetaData_NativeDelegate Internal_EmitGlobalMetaData_NativeDelegateField;
  private static readonly Profiler.GetCategoriesCountDelegate GetCategoriesCountDelegateField;
  private static readonly Profiler.Internal_SetCategoryEnabledDelegate Internal_SetCategoryEnabledDelegateField;
  private static readonly Profiler.Internal_IsCategoryEnabledDelegate Internal_IsCategoryEnabledDelegateField;
  private static readonly Profiler.get_logFile_InjectedDelegate get_logFile_InjectedDelegateField;
  private static readonly Profiler.set_logFile_InjectedDelegate set_logFile_InjectedDelegateField;
  private static readonly Profiler.AddFramesFromFile_Internal_InjectedDelegate AddFramesFromFile_Internal_InjectedDelegateField;
  private static readonly Profiler.BeginThreadProfilingInternal_InjectedDelegate BeginThreadProfilingInternal_InjectedDelegateField;
  private static readonly Profiler.BeginSampleImpl_InjectedDelegate BeginSampleImpl_InjectedDelegateField;

  static Profiler()
  {
    Il2CppClassPointerStore<Profiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Profiling", nameof (Profiler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Profiler>.NativeClassPtr);
    Profiler.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668897);
    Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668898);
    Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668899);
    Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668900);
    Profiler.NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668901);
    Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Profiler>.NativeClassPtr, 100668902);
    Profiler.get_supportedDelegateField = IL2CPP.ResolveICall<Profiler.get_supportedDelegate>("UnityEngine.Profiling.Profiler::get_supported");
    Profiler.get_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.get_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::get_enableBinaryLog");
    Profiler.set_enableBinaryLogDelegateField = IL2CPP.ResolveICall<Profiler.set_enableBinaryLogDelegate>("UnityEngine.Profiling.Profiler::set_enableBinaryLog");
    Profiler.get_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.get_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::get_maxUsedMemory");
    Profiler.set_maxUsedMemoryDelegateField = IL2CPP.ResolveICall<Profiler.set_maxUsedMemoryDelegate>("UnityEngine.Profiling.Profiler::set_maxUsedMemory");
    Profiler.set_enabledDelegateField = IL2CPP.ResolveICall<Profiler.set_enabledDelegate>("UnityEngine.Profiling.Profiler::set_enabled");
    Profiler.get_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.get_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::get_enableAllocationCallstacks");
    Profiler.set_enableAllocationCallstacksDelegateField = IL2CPP.ResolveICall<Profiler.set_enableAllocationCallstacksDelegate>("UnityEngine.Profiling.Profiler::set_enableAllocationCallstacks");
    Profiler.SetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.SetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::SetAreaEnabled");
    Profiler.GetAreaEnabledDelegateField = IL2CPP.ResolveICall<Profiler.GetAreaEnabledDelegate>("UnityEngine.Profiling.Profiler::GetAreaEnabled");
    Profiler.EndSampleDelegateField = IL2CPP.ResolveICall<Profiler.EndSampleDelegate>("UnityEngine.Profiling.Profiler::EndSample");
    Profiler.get_usedHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.get_usedHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::get_usedHeapSizeLong");
    Profiler.GetMonoHeapSizeLongDelegateField = IL2CPP.ResolveICall<Profiler.GetMonoHeapSizeLongDelegate>("UnityEngine.Profiling.Profiler::GetMonoHeapSizeLong");
    Profiler.SetTempAllocatorRequestedSizeDelegateField = IL2CPP.ResolveICall<Profiler.SetTempAllocatorRequestedSizeDelegate>("UnityEngine.Profiling.Profiler::SetTempAllocatorRequestedSize");
    Profiler.GetTempAllocatorSizeDelegateField = IL2CPP.ResolveICall<Profiler.GetTempAllocatorSizeDelegate>("UnityEngine.Profiling.Profiler::GetTempAllocatorSize");
    Profiler.GetTotalUnusedReservedMemoryLongDelegateField = IL2CPP.ResolveICall<Profiler.GetTotalUnusedReservedMemoryLongDelegate>("UnityEngine.Profiling.Profiler::GetTotalUnusedReservedMemoryLong");
    Profiler.InternalGetTotalFragmentationInfoDelegateField = IL2CPP.ResolveICall<Profiler.InternalGetTotalFragmentationInfoDelegate>("UnityEngine.Profiling.Profiler::InternalGetTotalFragmentationInfo");
    Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField = IL2CPP.ResolveICall<Profiler.GetAllocatedMemoryForGraphicsDriverDelegate>("UnityEngine.Profiling.Profiler::GetAllocatedMemoryForGraphicsDriver");
    Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_ArrayDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Array");
    Profiler.Internal_EmitGlobalMetaData_NativeDelegateField = IL2CPP.ResolveICall<Profiler.Internal_EmitGlobalMetaData_NativeDelegate>("UnityEngine.Profiling.Profiler::Internal_EmitGlobalMetaData_Native");
    Profiler.GetCategoriesCountDelegateField = IL2CPP.ResolveICall<Profiler.GetCategoriesCountDelegate>("UnityEngine.Profiling.Profiler::GetCategoriesCount");
    Profiler.Internal_SetCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_SetCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_SetCategoryEnabled");
    Profiler.Internal_IsCategoryEnabledDelegateField = IL2CPP.ResolveICall<Profiler.Internal_IsCategoryEnabledDelegate>("UnityEngine.Profiling.Profiler::Internal_IsCategoryEnabled");
    Profiler.get_logFile_InjectedDelegateField = IL2CPP.ResolveICall<Profiler.get_logFile_InjectedDelegate>("UnityEngine.Profiling.Profiler::get_logFile_Injected");
    Profiler.set_logFile_InjectedDelegateField = IL2CPP.ResolveICall<Profiler.set_logFile_InjectedDelegate>("UnityEngine.Profiling.Profiler::set_logFile_Injected");
    Profiler.AddFramesFromFile_Internal_InjectedDelegateField = IL2CPP.ResolveICall<Profiler.AddFramesFromFile_Internal_InjectedDelegate>("UnityEngine.Profiling.Profiler::AddFramesFromFile_Internal_Injected");
    Profiler.BeginThreadProfilingInternal_InjectedDelegateField = IL2CPP.ResolveICall<Profiler.BeginThreadProfilingInternal_InjectedDelegate>("UnityEngine.Profiling.Profiler::BeginThreadProfilingInternal_Injected");
    Profiler.BeginSampleImpl_InjectedDelegateField = IL2CPP.ResolveICall<Profiler.BeginSampleImpl_InjectedDelegate>("UnityEngine.Profiling.Profiler::BeginSampleImpl_Injected");
  }

  public static unsafe bool enabled
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 472309, RefRangeEnd = 472313, XrefRangeStart = 472307, XrefRangeEnd = 472309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => Profiler.set_enabledDelegateField(value);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472321, RefRangeEnd = 472322, XrefRangeStart = 472313, XrefRangeEnd = 472321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetRuntimeMemorySizeLong(UnityEngine.Object o)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Public_Static_Int64_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472324, RefRangeEnd = 472325, XrefRangeStart = 472322, XrefRangeEnd = 472324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetMonoUsedSizeLong()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetMonoUsedSizeLong_Public_Static_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472327, RefRangeEnd = 472328, XrefRangeStart = 472325, XrefRangeEnd = 472327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetTotalAllocatedMemoryLong()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalAllocatedMemoryLong_Public_Static_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472330, RefRangeEnd = 472331, XrefRangeStart = 472328, XrefRangeEnd = 472330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetTotalReservedMemoryLong()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetTotalReservedMemoryLong_Public_Static_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472331, XrefRangeEnd = 472333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetRuntimeMemorySizeLong_Injected(System.IntPtr o)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &o
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Profiler.NativeMethodInfoPtr_GetRuntimeMemorySizeLong_Injected_Private_Static_Int64_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static bool supported => Profiler.get_supportedDelegateField();

  public static unsafe string logFile
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        Profiler.get_logFile_Injected(out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
    set
    {
      try
      {
        ManagedSpanWrapper managedSpanWrapper;
        if (!StringMarshaller.TryMarshalEmptyOrNullString(value, ref managedSpanWrapper))
        {
          Il2CppSystem.ReadOnlySpan<char> readOnlySpan = value.AsSpan();
          fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
            managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
        }
        Profiler.set_logFile_Injected(ref managedSpanWrapper);
      }
      finally
      {
        __unpin(begin);
      }
    }
  }

  public static bool enableBinaryLog
  {
    get => Profiler.get_enableBinaryLogDelegateField();
    set => Profiler.set_enableBinaryLogDelegateField(value);
  }

  public static int maxUsedMemory
  {
    get => Profiler.get_maxUsedMemoryDelegateField();
    set => Profiler.set_maxUsedMemoryDelegateField(value);
  }

  public static bool enableAllocationCallstacks
  {
    get => Profiler.get_enableAllocationCallstacksDelegateField();
    set => Profiler.set_enableAllocationCallstacksDelegateField(value);
  }

  public static void SetAreaEnabled(ProfilerArea area, bool enabled)
  {
    Profiler.SetAreaEnabledDelegateField(area, enabled);
  }

  public static int areaCount
  {
    get
    {
      return ((Il2CppArrayBase) Il2CppSystem.Enum.GetNames(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ProfilerArea>()))).Length;
    }
  }

  public static bool GetAreaEnabled(ProfilerArea area)
  {
    return Profiler.GetAreaEnabledDelegateField(area);
  }

  public static void AddFramesFromFile(string file)
  {
    if (Il2CppSystem.String.IsNullOrEmpty(file))
      Debug.LogError((Il2CppSystem.Object) "AddFramesFromFile: Invalid or empty path");
    else
      Profiler.AddFramesFromFile_Internal(file, true);
  }

  public static unsafe void AddFramesFromFile_Internal(string file, bool keepExistingFrames)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(file, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = file.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Profiler.AddFramesFromFile_Internal_Injected(ref managedSpanWrapper, keepExistingFrames);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void BeginThreadProfiling(string threadGroupName, string threadName)
  {
    if (Il2CppSystem.String.IsNullOrEmpty(threadGroupName))
      throw new Il2CppSystem.ArgumentException("Argument should be a valid string", nameof (threadGroupName));
    if (Il2CppSystem.String.IsNullOrEmpty(threadName))
      throw new Il2CppSystem.ArgumentException("Argument should be a valid string", nameof (threadName));
    Profiler.BeginThreadProfilingInternal(threadGroupName, threadName);
  }

  public static unsafe void BeginThreadProfilingInternal(string threadGroupName, string threadName)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(threadGroupName, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = threadGroupName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(threadName, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = threadName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      Profiler.BeginThreadProfilingInternal_Injected(ref local1, ref local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void EndThreadProfiling()
  {
  }

  public static void BeginSample(string name)
  {
    Profiler.ValidateArguments(name);
    Profiler.BeginSampleImpl(name, (UnityEngine.Object) null);
  }

  public static void BeginSample(string name, UnityEngine.Object targetObject)
  {
    Profiler.ValidateArguments(name);
    Profiler.BeginSampleImpl(name, targetObject);
  }

  public static void ValidateArguments(string name)
  {
    if (Il2CppSystem.String.IsNullOrEmpty(name))
      throw new Il2CppSystem.ArgumentException("Argument should be a valid string.", nameof (name));
  }

  public static unsafe void BeginSampleImpl(string name, UnityEngine.Object targetObject)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      Profiler.BeginSampleImpl_Injected(ref managedSpanWrapper, UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(targetObject));
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void EndSample() => Profiler.EndSampleDelegateField();

  public static int maxNumberOfSamplesPerFrame
  {
    get => 0;
    set
    {
    }
  }

  public static uint usedHeapSize => (uint) Profiler.usedHeapSizeLong;

  public static long usedHeapSizeLong => Profiler.get_usedHeapSizeLongDelegateField();

  public static int GetRuntimeMemorySize(UnityEngine.Object o)
  {
    return (int) Profiler.GetRuntimeMemorySizeLong(o);
  }

  public static uint GetMonoHeapSize() => (uint) Profiler.GetMonoHeapSizeLong();

  public static long GetMonoHeapSizeLong() => Profiler.GetMonoHeapSizeLongDelegateField();

  public static uint GetMonoUsedSize() => (uint) Profiler.GetMonoUsedSizeLong();

  public static bool SetTempAllocatorRequestedSize(uint size)
  {
    return Profiler.SetTempAllocatorRequestedSizeDelegateField(size);
  }

  public static uint GetTempAllocatorSize() => Profiler.GetTempAllocatorSizeDelegateField();

  public static uint GetTotalAllocatedMemory() => (uint) Profiler.GetTotalAllocatedMemoryLong();

  public static uint GetTotalUnusedReservedMemory()
  {
    return (uint) Profiler.GetTotalUnusedReservedMemoryLong();
  }

  public static long GetTotalUnusedReservedMemoryLong()
  {
    return Profiler.GetTotalUnusedReservedMemoryLongDelegateField();
  }

  public static uint GetTotalReservedMemory() => (uint) Profiler.GetTotalReservedMemoryLong();

  public static unsafe long GetTotalFragmentationInfo(NativeArray<int> stats)
  {
    return Profiler.InternalGetTotalFragmentationInfo((System.IntPtr) stats.GetUnsafePtr<int>(), ((NativeArray<int>) ref stats).Length);
  }

  public static long InternalGetTotalFragmentationInfo(System.IntPtr pStats, int count)
  {
    return Profiler.InternalGetTotalFragmentationInfoDelegateField(pStats, count);
  }

  public static long GetAllocatedMemoryForGraphicsDriver()
  {
    return Profiler.GetAllocatedMemoryForGraphicsDriverDelegateField();
  }

  public static unsafe void EmitFrameMetaData(Il2CppSystem.Guid id, int tag, Il2CppSystem.Array data)
  {
    Il2CppSystem.Type type = data != null ? data.GetType().GetElementType() : throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsBlittable(type))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object) type));
    Profiler.Internal_EmitGlobalMetaData_Array((void*) &id, 16 /*0x10*/, tag, data, data.Length, UnsafeUtility.SizeOf(type), true);
  }

  public static unsafe void EmitFrameMetaData<T>(Il2CppSystem.Guid id, int tag, List<T> data) where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
    if (!UnsafeUtility.IsBlittable(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object) typeFromHandle));
    Profiler.Internal_EmitGlobalMetaData_Array((void*) &id, 16 /*0x10*/, tag, (Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), data.Count, UnsafeUtility.SizeOf(typeFromHandle), true);
  }

  public static unsafe void EmitFrameMetaData<T>(Il2CppSystem.Guid id, int tag, NativeArray<T> data) where T : struct
  {
    Profiler.Internal_EmitGlobalMetaData_Native((void*) &id, 16 /*0x10*/, tag, (System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>(), true);
  }

  public static unsafe void EmitSessionMetaData(Il2CppSystem.Guid id, int tag, Il2CppSystem.Array data)
  {
    Il2CppSystem.Type type = data != null ? data.GetType().GetElementType() : throw new Il2CppSystem.ArgumentNullException(nameof (data));
    if (!UnsafeUtility.IsBlittable(type))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object) type));
    Profiler.Internal_EmitGlobalMetaData_Array((void*) &id, 16 /*0x10*/, tag, data, data.Length, UnsafeUtility.SizeOf(type), false);
  }

  public static unsafe void EmitSessionMetaData<T>(Il2CppSystem.Guid id, int tag, List<T> data) where T : struct
  {
    if (data == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (data));
    Il2CppSystem.Type typeFromHandle = Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
    if (!UnsafeUtility.IsBlittable(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())))
      throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("{0} type must be blittable", (Il2CppSystem.Object) typeFromHandle));
    Profiler.Internal_EmitGlobalMetaData_Array((void*) &id, 16 /*0x10*/, tag, (Il2CppSystem.Array) NoAllocHelpers.ExtractArrayFromList<T>(data), data.Count, UnsafeUtility.SizeOf(typeFromHandle), false);
  }

  public static unsafe void EmitSessionMetaData<T>(Il2CppSystem.Guid id, int tag, NativeArray<T> data) where T : struct
  {
    Profiler.Internal_EmitGlobalMetaData_Native((void*) &id, 16 /*0x10*/, tag, (System.IntPtr) data.GetUnsafeReadOnlyPtr<T>(), ((NativeArray<T>) ref data).Length, UnsafeUtility.SizeOf<T>(), false);
  }

  public static unsafe void Internal_EmitGlobalMetaData_Array(
    void* id,
    int idLen,
    int tag,
    Il2CppSystem.Array data,
    int count,
    int elementSize,
    bool frameData)
  {
    Profiler.Internal_EmitGlobalMetaData_ArrayDelegateField((System.IntPtr) id, idLen, tag, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data), count, elementSize, frameData);
  }

  public static unsafe void Internal_EmitGlobalMetaData_Native(
    void* id,
    int idLen,
    int tag,
    System.IntPtr data,
    int count,
    int elementSize,
    bool frameData)
  {
    Profiler.Internal_EmitGlobalMetaData_NativeDelegateField((System.IntPtr) id, idLen, tag, data, count, elementSize, frameData);
  }

  public static void SetCategoryEnabled(ProfilerCategory category, bool enabled)
  {
    if ((int) (ushort) category == (int) (ushort) ProfilerCategory.Any)
      throw new Il2CppSystem.ArgumentException("Argument should be a valid category", nameof (category));
    Profiler.Internal_SetCategoryEnabled((ushort) category, enabled);
  }

  public static bool IsCategoryEnabled(ProfilerCategory category)
  {
    return (int) (ushort) category != (int) (ushort) ProfilerCategory.Any ? Profiler.Internal_IsCategoryEnabled((ushort) category) : throw new Il2CppSystem.ArgumentException("Argument should be a valid category", nameof (category));
  }

  public static uint GetCategoriesCount() => Profiler.GetCategoriesCountDelegateField();

  public static void GetAllCategories(Il2CppStructArray<ProfilerCategory> categories)
  {
    for (int category = 0; (long) category < Il2CppSystem.Math.Min((long) Profiler.GetCategoriesCount(), (long) ((Il2CppArrayBase) categories).Length); ++category)
      ((Il2CppArrayBase<ProfilerCategory>) categories)[category] = new ProfilerCategory((ushort) category);
  }

  public static void GetAllCategories(NativeArray<ProfilerCategory> categories)
  {
    for (int index = 0; (long) index < Il2CppSystem.Math.Min((long) Profiler.GetCategoriesCount(), (long) ((NativeArray<ProfilerCategory>) ref categories).Length); ++index)
      ((NativeArray<ProfilerCategory>) ref categories)[index] = new ProfilerCategory((ushort) index);
  }

  public static void Internal_SetCategoryEnabled(ushort categoryId, bool enabled)
  {
    Profiler.Internal_SetCategoryEnabledDelegateField(categoryId, enabled);
  }

  public static bool Internal_IsCategoryEnabled(ushort categoryId)
  {
    return Profiler.Internal_IsCategoryEnabledDelegateField(categoryId);
  }

  public static void get_logFile_Injected(out ManagedSpanWrapper ret)
  {
    Profiler.get_logFile_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void set_logFile_Injected(ref ManagedSpanWrapper value)
  {
    Profiler.set_logFile_InjectedDelegateField((System.IntPtr) ref value);
  }

  public static void AddFramesFromFile_Internal_Injected(
    ref ManagedSpanWrapper file,
    bool keepExistingFrames)
  {
    Profiler.AddFramesFromFile_Internal_InjectedDelegateField((System.IntPtr) ref file, keepExistingFrames);
  }

  public static void BeginThreadProfilingInternal_Injected(
    ref ManagedSpanWrapper threadGroupName,
    ref ManagedSpanWrapper threadName)
  {
    Profiler.BeginThreadProfilingInternal_InjectedDelegateField((System.IntPtr) ref threadGroupName, (System.IntPtr) ref threadName);
  }

  public static void BeginSampleImpl_Injected(ref ManagedSpanWrapper name, System.IntPtr targetObject)
  {
    Profiler.BeginSampleImpl_InjectedDelegateField((System.IntPtr) ref name, targetObject);
  }

  private delegate bool get_supportedDelegate();

  private delegate bool get_enableBinaryLogDelegate();

  private delegate void set_enableBinaryLogDelegate(bool value);

  private delegate int get_maxUsedMemoryDelegate();

  private delegate void set_maxUsedMemoryDelegate(int value);

  private delegate void set_enabledDelegate(bool value);

  private delegate bool get_enableAllocationCallstacksDelegate();

  private delegate void set_enableAllocationCallstacksDelegate(bool value);

  private delegate void SetAreaEnabledDelegate(ProfilerArea area, bool enabled);

  private delegate bool GetAreaEnabledDelegate(ProfilerArea area);

  private delegate void EndSampleDelegate();

  private delegate long get_usedHeapSizeLongDelegate();

  private delegate long GetMonoHeapSizeLongDelegate();

  private delegate bool SetTempAllocatorRequestedSizeDelegate(uint size);

  private delegate uint GetTempAllocatorSizeDelegate();

  private delegate long GetTotalUnusedReservedMemoryLongDelegate();

  private delegate long InternalGetTotalFragmentationInfoDelegate(System.IntPtr pStats, int count);

  private delegate long GetAllocatedMemoryForGraphicsDriverDelegate();

  private delegate void Internal_EmitGlobalMetaData_ArrayDelegate(
    System.IntPtr id,
    int idLen,
    int tag,
    System.IntPtr data,
    int count,
    int elementSize,
    bool frameData);

  private delegate void Internal_EmitGlobalMetaData_NativeDelegate(
    System.IntPtr id,
    int idLen,
    int tag,
    System.IntPtr data,
    int count,
    int elementSize,
    bool frameData);

  private delegate uint GetCategoriesCountDelegate();

  private delegate void Internal_SetCategoryEnabledDelegate(ushort categoryId, bool enabled);

  private delegate bool Internal_IsCategoryEnabledDelegate(ushort categoryId);

  private delegate void get_logFile_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void set_logFile_InjectedDelegate(System.IntPtr value);

  private delegate void AddFramesFromFile_Internal_InjectedDelegate(
    System.IntPtr file,
    bool keepExistingFrames);

  private delegate void BeginThreadProfilingInternal_InjectedDelegate(
    System.IntPtr threadGroupName,
    System.IntPtr threadName);

  private delegate void BeginSampleImpl_InjectedDelegate(System.IntPtr name, System.IntPtr targetObject);
}
