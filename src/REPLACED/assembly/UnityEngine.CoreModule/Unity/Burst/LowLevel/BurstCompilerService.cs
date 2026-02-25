// Decompiled with JetBrains decompiler
// Type: Unity.Burst.LowLevel.BurstCompilerService
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Bindings;

#nullable disable
namespace Unity.Burst.LowLevel;

public static class BurstCompilerService : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;
  private static readonly BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegate GetAsyncCompiledAsyncDelegateMethodDelegateField;
  private static readonly BurstCompilerService.get_IsInitializedDelegate get_IsInitializedDelegateField;
  private static readonly BurstCompilerService.SetCurrentExecutionModeDelegate SetCurrentExecutionModeDelegateField;
  private static readonly BurstCompilerService.GetCurrentExecutionModeDelegate GetCurrentExecutionModeDelegateField;
  private static readonly BurstCompilerService.GetDisassembly_InjectedDelegate GetDisassembly_InjectedDelegateField;
  private static readonly BurstCompilerService.CompileAsyncDelegateMethod_InjectedDelegate CompileAsyncDelegateMethod_InjectedDelegateField;
  private static readonly BurstCompilerService.GetMethodSignature_InjectedDelegate GetMethodSignature_InjectedDelegateField;
  private static readonly BurstCompilerService.LoadBurstLibrary_InjectedDelegate LoadBurstLibrary_InjectedDelegateField;

  static BurstCompilerService()
  {
    Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst.LowLevel", nameof (BurstCompilerService));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr);
    BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663618);
    BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663619);
    BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663620);
    BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetAsyncCompiledAsyncDelegateMethod");
    BurstCompilerService.get_IsInitializedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");
    BurstCompilerService.SetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.SetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::SetCurrentExecutionMode");
    BurstCompilerService.GetCurrentExecutionModeDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetCurrentExecutionModeDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetCurrentExecutionMode");
    BurstCompilerService.GetDisassembly_InjectedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetDisassembly_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetDisassembly_Injected");
    BurstCompilerService.CompileAsyncDelegateMethod_InjectedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.CompileAsyncDelegateMethod_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::CompileAsyncDelegateMethod_Injected");
    BurstCompilerService.GetMethodSignature_InjectedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetMethodSignature_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature_Injected");
    BurstCompilerService.LoadBurstLibrary_InjectedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.LoadBurstLibrary_InjectedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::LoadBurstLibrary_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414963, RefRangeEnd = 414964, XrefRangeStart = 414961, XrefRangeEnd = 414963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void* GetOrCreateSharedMemory(ref Hash128 key, uint size_of, uint alignment)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref key;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size_of;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
    System.IntPtr num;
    System.IntPtr sharedMemory = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return (void*) sharedMemory;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414966, RefRangeEnd = 414967, XrefRangeStart = 414964, XrefRangeEnd = 414966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(
    void* userData,
    BurstCompilerService.BurstLogType logType,
    byte* message,
    byte* filename,
    int lineNumber)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) userData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) message;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) filename;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lineNumber;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 414969, RefRangeEnd = 414970, XrefRangeStart = 414967, XrefRangeEnd = 414969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RuntimeLog(
    void* userData,
    BurstCompilerService.BurstLogType logType,
    byte* message,
    byte* filename,
    int lineNumber)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) userData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) message;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) filename;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &lineNumber;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public BurstCompilerService(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string GetDisassembly(MethodInfo m, string compilerOptions)
  {
    ManagedSpanWrapper managedSpan;
    string stringAndDispose;
    try
    {
      MethodInfo m1 = m;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(compilerOptions, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = compilerOptions.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper;
      ref ManagedSpanWrapper local2 = ref managedSpan;
      BurstCompilerService.GetDisassembly_Injected(m1, ref local1, out local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(managedSpan);
    }
    return stringAndDispose;
  }

  public static unsafe int CompileAsyncDelegateMethod(Il2CppSystem.Object delegateMethod, string compilerOptions)
  {
    try
    {
      Il2CppSystem.Object delegateMethod1 = delegateMethod;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(compilerOptions, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = compilerOptions.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      return BurstCompilerService.CompileAsyncDelegateMethod_Injected(delegateMethod1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void* GetAsyncCompiledAsyncDelegateMethod(int userID)
  {
    return (void*) BurstCompilerService.GetAsyncCompiledAsyncDelegateMethodDelegateField(userID);
  }

  public static string GetMethodSignature(MethodInfo method)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      BurstCompilerService.GetMethodSignature_Injected(method, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static bool IsInitialized => BurstCompilerService.get_IsInitializedDelegateField();

  public static void SetCurrentExecutionMode(uint environment)
  {
    BurstCompilerService.SetCurrentExecutionModeDelegateField(environment);
  }

  public static uint GetCurrentExecutionMode()
  {
    return BurstCompilerService.GetCurrentExecutionModeDelegateField();
  }

  public static unsafe bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(fullPathToLibBurstGenerated, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = fullPathToLibBurstGenerated.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return BurstCompilerService.LoadBurstLibrary_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void GetDisassembly_Injected(
    MethodInfo m,
    ref ManagedSpanWrapper compilerOptions,
    out ManagedSpanWrapper ret)
  {
    BurstCompilerService.GetDisassembly_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) m), (System.IntPtr) ref compilerOptions, (System.IntPtr) ref ret);
  }

  public static int CompileAsyncDelegateMethod_Injected(
    Il2CppSystem.Object delegateMethod,
    ref ManagedSpanWrapper compilerOptions)
  {
    return BurstCompilerService.CompileAsyncDelegateMethod_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) delegateMethod), (System.IntPtr) ref compilerOptions);
  }

  public static void GetMethodSignature_Injected(MethodInfo method, out ManagedSpanWrapper ret)
  {
    BurstCompilerService.GetMethodSignature_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method), (System.IntPtr) ref ret);
  }

  public static bool LoadBurstLibrary_Injected(ref ManagedSpanWrapper fullPathToLibBurstGenerated)
  {
    return BurstCompilerService.LoadBurstLibrary_InjectedDelegateField((System.IntPtr) ref fullPathToLibBurstGenerated);
  }

  public enum BurstLogType
  {
    Info,
    Warning,
    Error,
  }

  private delegate System.IntPtr GetAsyncCompiledAsyncDelegateMethodDelegate(int userID);

  private delegate bool get_IsInitializedDelegate();

  private delegate void SetCurrentExecutionModeDelegate(uint environment);

  private delegate uint GetCurrentExecutionModeDelegate();

  private delegate void GetDisassembly_InjectedDelegate(
    System.IntPtr m,
    System.IntPtr compilerOptions,
    [Out] System.IntPtr ret);

  private delegate int CompileAsyncDelegateMethod_InjectedDelegate(
    System.IntPtr delegateMethod,
    System.IntPtr compilerOptions);

  private delegate void GetMethodSignature_InjectedDelegate(System.IntPtr method, [Out] System.IntPtr ret);

  private delegate bool LoadBurstLibrary_InjectedDelegate(System.IntPtr fullPathToLibBurstGenerated);
}
