// Decompiled with JetBrains decompiler
// Type: UnityEngine.Jobs.IJobParallelForTransformExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Jobs;

public static class IJobParallelForTransformExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0;

  static IJobParallelForTransformExtensions()
  {
    Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", nameof (IJobParallelForTransformExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr);
    IJobParallelForTransformExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100668925);
    IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100668926);
    IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, 100668927);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472465, XrefRangeEnd = 472468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyJobInit<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetReflectionData<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472468, XrefRangeEnd = 472472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe JobHandle Schedule<T>(
    this T jobData,
    TransformAccessArray transforms,
    JobHandle dependsOn = default (JobHandle))
    where T : new()
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) jobData;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref jobData;
    *numPtr2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transforms;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dependsOn;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(JobHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public IJobParallelForTransformExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe JobHandle ScheduleReadOnly<T>(
    T jobData,
    TransformAccessArray transforms,
    int batchSize,
    JobHandle dependsOn = default (JobHandle))
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
    return JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
  }

  public static unsafe void RunReadOnly<T>(T jobData, TransformAccessArray transforms) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
  }

  public static unsafe JobHandle ScheduleByRef<T>(
    ref T jobData,
    TransformAccessArray transforms,
    JobHandle dependsOn = default (JobHandle))
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
    return JobsUtility.ScheduleParallelForTransform(ref parameters, transforms.GetTransformAccessArrayForSchedule());
  }

  public static unsafe JobHandle ScheduleReadOnlyByRef<T>(
    ref T jobData,
    TransformAccessArray transforms,
    int batchSize,
    JobHandle dependsOn = default (JobHandle))
    where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), dependsOn, ScheduleMode.Batched);
    return JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), batchSize);
  }

  public static unsafe void RunReadOnlyByRef<T>(ref T jobData, TransformAccessArray transforms) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobParallelForTransformExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.ScheduleParallelForTransformReadOnly(ref parameters, transforms.GetTransformAccessArrayForSchedule(), transforms.length);
  }

  public sealed class TransformParallelForLoopStruct<T> : Il2CppSystem.ValueType where T : new()
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_jobReflectionData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

    static TransformParallelForLoopStruct()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr, "TransformParallelForLoopStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr);
      IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, nameof (jobReflectionData));
      IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100668928 /*0x06001600*/);
      IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, 100668929);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472414, XrefRangeEnd = 472440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472440, XrefRangeEnd = 472465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Execute(
      ref T jobData,
      System.IntPtr jobData2,
      System.IntPtr bufferRangePatchData,
      ref JobRanges ranges,
      int jobIndex)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobData2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferRangePatchData;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ranges;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      System.IntPtr num1;
      IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref T local = ref jobData;
      System.IntPtr num2 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
      local = (T) valueGeneric;
    }

    public TransformParallelForLoopStruct(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TransformParallelForLoopStruct()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr))
    {
    }

    public static unsafe BurstLike.SharedStatic<System.IntPtr> jobReflectionData
    {
      get
      {
        System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*) num);
        return new BurstLike.SharedStatic<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
      }
    }

    public sealed class TransformJobData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformAccessArray;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsReadOnly;

      static TransformJobData()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, nameof (TransformJobData<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr);
        IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, nameof (TransformAccessArray));
        IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr, nameof (IsReadOnly));
      }

      public TransformJobData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public TransformJobData()
        : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData>.NativeClassPtr))
      {
      }

      public unsafe System.IntPtr TransformAccessArray
      {
        get
        {
          return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray));
        }
        [param: In] set
        {
          *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_TransformAccessArray)) = value;
        }
      }

      public unsafe int IsReadOnly
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.TransformJobData.NativeFieldInfoPtr_IsReadOnly)) = value;
        }
      }
    }

    public sealed class ExecuteJobFunction(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

      static ExecuteJobFunction()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>>.NativeClassPtr, nameof (ExecuteJobFunction<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100668931);
        IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100668932);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 413315, RefRangeEnd = 413316, XrefRangeStart = 413315, XrefRangeEnd = 413316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExecuteJobFunction(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      public virtual unsafe void Invoke(
        ref T jobData,
        System.IntPtr additionalPtr,
        System.IntPtr bufferRangePatchData,
        ref JobRanges ranges,
        int jobIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) jobData);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferRangePatchData;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ranges;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
        System.IntPtr num1;
        IL2CPP.il2cpp_runtime_invoke(IJobParallelForTransformExtensions.TransformParallelForLoopStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        ref T local = ref jobData;
        System.IntPtr num2 = ptr;
        // ISSUE: variable of the null type
        __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
        local = (T) valueGeneric;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetReflectionData_Private_Static_IntPtr_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_GetReflectionData_Private_Static_IntPtr_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobParallelForTransformExtensions.NativeMethodInfoPtr_Schedule_Public_Static_JobHandle_T_TransformAccessArray_JobHandle_0, Il2CppClassPointerStore<IJobParallelForTransformExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
