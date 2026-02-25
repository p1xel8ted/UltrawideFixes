// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.ProfilerRecorder
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Profiling.LowLevel;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Profiling;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorder
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handle;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0;
  [FieldOffset(0)]
  public ulong handle;
  public const ProfilerRecorderOptions SharedRecorder = (ProfilerRecorderOptions) 128 /*0x80*/;
  private static readonly ProfilerRecorder.GetValueUnitType_InjectedDelegate GetValueUnitType_InjectedDelegateField;
  private static readonly ProfilerRecorder.GetValueDataType_InjectedDelegate GetValueDataType_InjectedDelegateField;
  private static readonly ProfilerRecorder.GetCurrentValue_InjectedDelegate GetCurrentValue_InjectedDelegateField;
  private static readonly ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate GetCurrentValueAsDouble_InjectedDelegateField;
  private static readonly ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate GetLastValueAsDouble_InjectedDelegateField;
  private static readonly ProfilerRecorder.GetWrapped_InjectedDelegate GetWrapped_InjectedDelegateField;
  private static readonly ProfilerRecorder.CopyTo_List_InjectedDelegate CopyTo_List_InjectedDelegateField;
  private static readonly ProfilerRecorder.CopyTo_Pointer_InjectedDelegate CopyTo_Pointer_InjectedDelegateField;

  static ProfilerRecorder()
  {
    Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (ProfilerRecorder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr);
    ProfilerRecorder.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, nameof (handle));
    ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663390 /*0x0600005E*/);
    ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663391 /*0x0600005F*/);
    ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663392 /*0x06000060*/);
    ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663393 /*0x06000061*/);
    ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663394 /*0x06000062*/);
    ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663395 /*0x06000063*/);
    ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663396 /*0x06000064*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663397 /*0x06000065*/);
    ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663398 /*0x06000066*/);
    ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663399 /*0x06000067*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663400 /*0x06000068*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663401 /*0x06000069*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663402 /*0x0600006A*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663403 /*0x0600006B*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663404 /*0x0600006C*/);
    ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663405 /*0x0600006D*/);
    ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663406 /*0x0600006E*/);
    ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663407 /*0x0600006F*/);
    ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663408 /*0x06000070*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663409 /*0x06000071*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663410 /*0x06000072*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663411 /*0x06000073*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663412 /*0x06000074*/);
    ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, 100663413 /*0x06000075*/);
    ProfilerRecorder.GetValueUnitType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueUnitType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueUnitType_Injected");
    ProfilerRecorder.GetValueDataType_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetValueDataType_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetValueDataType_Injected");
    ProfilerRecorder.GetCurrentValue_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValue_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValue_Injected");
    ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetCurrentValueAsDouble_Injected");
    ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetLastValueAsDouble_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetLastValueAsDouble_Injected");
    ProfilerRecorder.GetWrapped_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.GetWrapped_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::GetWrapped_Injected");
    ProfilerRecorder.CopyTo_List_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_List_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_List_Injected");
    ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField = IL2CPP.ResolveICall<ProfilerRecorder.CopyTo_Pointer_InjectedDelegate>("Unity.Profiling.ProfilerRecorder::CopyTo_Pointer_Injected");
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 413696 /*0x065000*/, RefRangeEnd = 413700, XrefRangeStart = 413694, XrefRangeEnd = 413696 /*0x065000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerRecorder(
    ProfilerRecorderHandle statHandle,
    int capacity = 1,
    ProfilerRecorderOptions options = ProfilerRecorderOptions.Default)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &statHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &capacity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr__ctor_Public_Void_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool Valid
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 413700, RefRangeEnd = 413708, XrefRangeStart = 413700, XrefRangeEnd = 413700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Valid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 413710, RefRangeEnd = 413714, XrefRangeStart = 413708, XrefRangeEnd = 413710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Start_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 413716, RefRangeEnd = 413720, XrefRangeStart = 413714, XrefRangeEnd = 413716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Stop_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe long LastValue
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 413722, RefRangeEnd = 413724, XrefRangeStart = 413720, XrefRangeEnd = 413722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_LastValue_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int Count
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 413726, RefRangeEnd = 413728, XrefRangeStart = 413724, XrefRangeEnd = 413726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsRunning
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 413730, RefRangeEnd = 413731, XrefRangeStart = 413728, XrefRangeEnd = 413730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_get_IsRunning_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 413733, RefRangeEnd = 413735, XrefRangeStart = 413731, XrefRangeEnd = 413733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProfilerRecorderSample GetSample(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSample_Public_ProfilerRecorderSample_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorderSample*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413735, XrefRangeEnd = 413737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerRecorder Create(
    ProfilerRecorderHandle statHandle,
    int maxSampleCount,
    ProfilerRecorderOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &statHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSampleCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Private_Static_ProfilerRecorder_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorder*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413737, XrefRangeEnd = 413739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Control(
    ProfilerRecorder handle,
    ProfilerRecorder.ControlOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Private_Static_Void_ProfilerRecorder_ControlOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413739, XrefRangeEnd = 413741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetLastValue(ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Private_Static_Int64_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413741, XrefRangeEnd = 413743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetCount(
    ProfilerRecorder handle,
    ProfilerRecorder.CountOptions countOptions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &countOptions;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Private_Static_Int32_ProfilerRecorder_CountOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413743, XrefRangeEnd = 413745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetValid(ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Private_Static_Boolean_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413745, XrefRangeEnd = 413747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetRunning(ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Private_Static_Boolean_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413747, XrefRangeEnd = 413749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ProfilerRecorderSample GetSampleInternal(ProfilerRecorder handle, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Private_Static_ProfilerRecorderSample_ProfilerRecorder_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ProfilerRecorderSample*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 413751, RefRangeEnd = 413753, XrefRangeStart = 413749, XrefRangeEnd = 413751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void CheckInitializedAndThrow()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_CheckInitializedAndThrow_Private_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413753, XrefRangeEnd = 413755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Create_Injected(
    [In] ref ProfilerRecorderHandle statHandle,
    int maxSampleCount,
    ProfilerRecorderOptions options,
    out ProfilerRecorder ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref statHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxSampleCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Create_Injected_Private_Static_Void_byref_ProfilerRecorderHandle_Int32_ProfilerRecorderOptions_byref_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413755, XrefRangeEnd = 413757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Control_Injected(
    [In] ref ProfilerRecorder handle,
    ProfilerRecorder.ControlOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_Control_Injected_Private_Static_Void_byref_ProfilerRecorder_ControlOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413757, XrefRangeEnd = 413759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long GetLastValue_Injected([In] ref ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetLastValue_Injected_Private_Static_Int64_byref_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413759, XrefRangeEnd = 413761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetCount_Injected(
    [In] ref ProfilerRecorder handle,
    ProfilerRecorder.CountOptions countOptions)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &countOptions;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetCount_Injected_Private_Static_Int32_byref_ProfilerRecorder_CountOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413761, XrefRangeEnd = 413763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetValid_Injected([In] ref ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetValid_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413763, XrefRangeEnd = 413765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetRunning_Injected([In] ref ProfilerRecorder handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref handle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetRunning_Injected_Private_Static_Boolean_byref_ProfilerRecorder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413765, XrefRangeEnd = 413767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSampleInternal_Injected(
    [In] ref ProfilerRecorder handle,
    int index,
    out ProfilerRecorderSample ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref handle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProfilerRecorder.NativeMethodInfoPtr_GetSampleInternal_Injected_Private_Static_Void_byref_ProfilerRecorder_Int32_byref_ProfilerRecorderSample_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorder>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe ProfilerRecorder StartNew(
    ProfilerCategory category,
    string statName,
    int capacity = default (int),
    ProfilerRecorderOptions options = default (ProfilerRecorderOptions))
  {
    string str = statName;
    char* chPtr = (char*) str;
    if ((System.IntPtr) chPtr != System.IntPtr.Zero)
      chPtr += RuntimeHelpers.OffsetToStringData;
    return new ProfilerRecorder(category, chPtr, statName.Length, capacity, options | ProfilerRecorderOptions.StartImmediately);
  }

  public static ProfilerRecorder StartNew(
    ProfilerMarker marker,
    int capacity = default (int),
    ProfilerRecorderOptions options = default (ProfilerRecorderOptions))
  {
    return new ProfilerRecorder(marker, capacity, options | ProfilerRecorderOptions.StartImmediately);
  }

  public static ProfilerRecorder StartNew()
  {
    return ProfilerRecorder.Create(new ProfilerRecorderHandle(), 0, ProfilerRecorderOptions.StartImmediately);
  }

  public ProfilerMarkerDataType DataType
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetValueDataType(this);
    }
  }

  public ProfilerMarkerDataUnit UnitType
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetValueUnitType(this);
    }
  }

  public void Reset()
  {
    this.CheckInitializedAndThrow();
    ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.Reset);
  }

  public long CurrentValue
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetCurrentValue(this);
    }
  }

  public double CurrentValueAsDouble
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetCurrentValueAsDouble(this);
    }
  }

  public double LastValueAsDouble
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetLastValueAsDouble(this);
    }
  }

  public int Capacity
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetCount(this, ProfilerRecorder.CountOptions.MaxCount);
    }
  }

  public bool WrappedAround
  {
    get
    {
      this.CheckInitializedAndThrow();
      return ProfilerRecorder.GetWrapped(this);
    }
  }

  public void CopyTo(List<ProfilerRecorderSample> outSamples, bool reset = default (bool))
  {
    if (outSamples == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (outSamples));
    this.CheckInitializedAndThrow();
    ProfilerRecorder.CopyTo_List(this, outSamples, reset);
  }

  public unsafe int CopyTo(ProfilerRecorderSample* dest, int destSize, bool reset = default (bool))
  {
    this.CheckInitializedWithParamsAndThrow(dest);
    return ProfilerRecorder.CopyTo_Pointer(this, dest, destSize, reset);
  }

  public Il2CppStructArray<ProfilerRecorderSample> ToArray()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void FilterToCurrentThread()
  {
    this.CheckInitializedAndThrow();
    ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetFilterToCurrentThread);
  }

  public void CollectFromAllThreads()
  {
    this.CheckInitializedAndThrow();
    ProfilerRecorder.Control(this, ProfilerRecorder.ControlOptions.SetToCollectFromAllThreads);
  }

  public static ProfilerMarkerDataUnit GetValueUnitType(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetValueUnitType_Injected(ref handle);
  }

  public static ProfilerMarkerDataType GetValueDataType(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetValueDataType_Injected(ref handle);
  }

  public static long GetCurrentValue(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetCurrentValue_Injected(ref handle);
  }

  public static double GetCurrentValueAsDouble(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetCurrentValueAsDouble_Injected(ref handle);
  }

  public static double GetLastValueAsDouble(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetLastValueAsDouble_Injected(ref handle);
  }

  public static bool GetWrapped(ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetWrapped_Injected(ref handle);
  }

  public static void CopyTo_List(
    ProfilerRecorder handle,
    List<ProfilerRecorderSample> outSamples,
    bool reset)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe int CopyTo_Pointer(
    ProfilerRecorder handle,
    ProfilerRecorderSample* outSamples,
    int outSamplesSize,
    bool reset)
  {
    return ProfilerRecorder.CopyTo_Pointer_Injected(ref handle, outSamples, outSamplesSize, reset);
  }

  public unsafe void CheckInitializedWithParamsAndThrow(ProfilerRecorderSample* dest)
  {
    if (this.handle == 0UL)
      throw new Il2CppSystem.InvalidOperationException("ProfilerRecorder object is not initialized or has been disposed.");
    if ((System.IntPtr) dest == System.IntPtr.Zero)
      throw new Il2CppSystem.ArgumentNullException(nameof (dest));
  }

  public static ProfilerMarkerDataUnit GetValueUnitType_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetValueUnitType_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static ProfilerMarkerDataType GetValueDataType_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetValueDataType_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static long GetCurrentValue_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetCurrentValue_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static double GetCurrentValueAsDouble_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetCurrentValueAsDouble_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static double GetLastValueAsDouble_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetLastValueAsDouble_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static bool GetWrapped_Injected([In] ref ProfilerRecorder handle)
  {
    return ProfilerRecorder.GetWrapped_InjectedDelegateField((System.IntPtr) ref handle);
  }

  public static void CopyTo_List_Injected(
    [In] ref ProfilerRecorder handle,
    ref BlittableListWrapper outSamples,
    bool reset)
  {
    ProfilerRecorder.CopyTo_List_InjectedDelegateField((System.IntPtr) ref handle, (System.IntPtr) ref outSamples, reset);
  }

  public static unsafe int CopyTo_Pointer_Injected(
    [In] ref ProfilerRecorder handle,
    ProfilerRecorderSample* outSamples,
    int outSamplesSize,
    bool reset)
  {
    return ProfilerRecorder.CopyTo_Pointer_InjectedDelegateField((System.IntPtr) ref handle, (System.IntPtr) outSamples, outSamplesSize, reset);
  }

  public enum ControlOptions
  {
    Start = 0,
    Stop = 1,
    Reset = 2,
    Release = 4,
    SetFilterToCurrentThread = 5,
    SetToCollectFromAllThreads = 6,
  }

  public enum CountOptions
  {
    Count,
    MaxCount,
  }

  private delegate ProfilerMarkerDataUnit GetValueUnitType_InjectedDelegate([In] System.IntPtr handle);

  private delegate ProfilerMarkerDataType GetValueDataType_InjectedDelegate([In] System.IntPtr handle);

  private delegate long GetCurrentValue_InjectedDelegate([In] System.IntPtr handle);

  private delegate double GetCurrentValueAsDouble_InjectedDelegate([In] System.IntPtr handle);

  private delegate double GetLastValueAsDouble_InjectedDelegate([In] System.IntPtr handle);

  private delegate bool GetWrapped_InjectedDelegate([In] System.IntPtr handle);

  private delegate void CopyTo_List_InjectedDelegate([In] System.IntPtr handle, System.IntPtr outSamples, bool reset);

  private delegate int CopyTo_Pointer_InjectedDelegate(
    [In] System.IntPtr handle,
    System.IntPtr outSamples,
    int outSamplesSize,
    bool reset);
}
