// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.IJobExtensions
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
using Unity.Jobs.LowLevel.Unsafe;

#nullable disable
namespace Unity.Jobs;

public static class IJobExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0;

  static IJobExtensions()
  {
    Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs", nameof (IJobExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr);
    IJobExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, 100663306 /*0x0600000A*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 413424, RefRangeEnd = 413425, XrefRangeStart = 413364, XrefRangeEnd = 413424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyJobInit<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IJobExtensions.MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public IJobExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static System.IntPtr GetReflectionData<T>() where T : struct
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe JobHandle Schedule<T>(T jobData, JobHandle dependsOn = default (JobHandle)) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), dependsOn, ScheduleMode.Single);
    return JobsUtility.Schedule(ref parameters);
  }

  public static unsafe void Run<T>(T jobData) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.Schedule(ref parameters);
  }

  public static unsafe JobHandle ScheduleByRef<T>(ref T jobData, JobHandle dependsOn = default (JobHandle)) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), dependsOn, ScheduleMode.Single);
    return JobsUtility.Schedule(ref parameters);
  }

  public static unsafe void RunByRef<T>(ref T jobData) where T : struct
  {
    JobsUtility.JobScheduleParameters parameters = new JobsUtility.JobScheduleParameters(UnsafeUtility.AddressOf<T>(ref jobData), IJobExtensions.GetReflectionData<T>(), new JobHandle(), ScheduleMode.Run);
    JobsUtility.Schedule(ref parameters);
  }

  public sealed class JobStruct<T> : Il2CppSystem.ValueType where T : new()
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_jobReflectionData;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0;

    static JobStruct()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr, "JobStruct`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr);
      IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, nameof (jobReflectionData));
      IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, 100663307 /*0x0600000B*/);
      IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, 100663308 /*0x0600000C*/);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 413342, RefRangeEnd = 413343, XrefRangeStart = 413316, XrefRangeEnd = 413342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Initialize_Internal_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413343, XrefRangeEnd = 413364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Execute(
      ref T data,
      System.IntPtr additionalPtr,
      System.IntPtr bufferRangePatchData,
      ref JobRanges ranges,
      int jobIndex)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalPtr;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferRangePatchData;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ranges;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
      System.IntPtr num1;
      IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.NativeMethodInfoPtr_Execute_Public_Static_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, System.IntPtr.Zero, (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref T local = ref data;
      System.IntPtr num2 = ptr;
      // ISSUE: variable of the null type
      __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
      local = (T) valueGeneric;
    }

    public JobStruct(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public JobStruct()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr))
    {
    }

    public static unsafe BurstLike.SharedStatic<System.IntPtr> jobReflectionData
    {
      get
      {
        System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*) num);
        return new BurstLike.SharedStatic<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BurstLike.SharedStatic<System.IntPtr>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IJobExtensions.JobStruct<T>.NativeFieldInfoPtr_jobReflectionData, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
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
        Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>>.NativeClassPtr, nameof (ExecuteJobFunction<>)))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663310 /*0x0600000E*/);
        IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr, 100663311 /*0x0600000F*/);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 413315, RefRangeEnd = 413316, XrefRangeStart = 413312, XrefRangeEnd = 413315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ExecuteJobFunction(Il2CppSystem.Object @object, System.IntPtr method)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IJobExtensions.JobStruct<T>.ExecuteJobFunction>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      public virtual unsafe void Invoke(
        ref T data,
        System.IntPtr additionalPtr,
        System.IntPtr bufferRangePatchData,
        ref JobRanges ranges,
        int jobIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
        System.IntPtr* numPtr2 = numPtr1;
        System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr* numPtr3 = &ptr;
        *numPtr2 = (System.IntPtr) numPtr3;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &additionalPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bufferRangePatchData;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ranges;
        *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &jobIndex;
        System.IntPtr num1;
        IL2CPP.il2cpp_runtime_invoke(IJobExtensions.JobStruct<T>.ExecuteJobFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_T_IntPtr_IntPtr_byref_JobRanges_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        ref T local = ref data;
        System.IntPtr num2 = ptr;
        // ISSUE: variable of the null type
        __Null valueGeneric = num2 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num2, false, false);
        local = (T) valueGeneric;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_EarlyJobInit_Public_Static_Void_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IJobExtensions.NativeMethodInfoPtr_EarlyJobInit_Public_Static_Void_0, Il2CppClassPointerStore<IJobExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
