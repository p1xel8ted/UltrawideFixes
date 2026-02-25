// Decompiled with JetBrains decompiler
// Type: Unity.Baselib.LowLevel.Binding
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Baselib.LowLevel;

public static class Binding
{
  public const uint Baselib_NetworkAddress_IpMaxStringLength = 46;
  public const uint Baselib_RegisteredNetwork_Endpoint_MaxSize = 28;
  public const int Baselib_SystemSemaphore_MaxCount = 2147483647 /*0x7FFFFFFF*/;
  public const uint Baselib_TLS_MinimumGuaranteedSlots = 100;
  public const ulong Baselib_SecondsPerMinute = 60;
  public const ulong Baselib_MillisecondsPerSecond = 1000;
  public const ulong Baselib_MillisecondsPerMinute = 60000;
  public const ulong Baselib_MicrosecondsPerMillisecond = 1000;
  public const ulong Baselib_MicrosecondsPerSecond = 1000000;
  public const ulong Baselib_MicrosecondsPerMinute = 60000000;
  public const ulong Baselib_NanosecondsPerMicrosecond = 1000;
  public const ulong Baselib_NanosecondsPerMillisecond = 1000000;
  public const ulong Baselib_NanosecondsPerSecond = 1000000000;
  public const ulong Baselib_NanosecondsPerMinute = 60000000000;
  public const ulong Baselib_Timer_MaxNumberOfNanosecondsPerTick = 1000;
  public const double Baselib_Timer_MinNumberOfNanosecondsPerTick = 0.01;
  public const double Baselib_Timer_HighPrecisionTimerCrossThreadMontotonyTolerance_InNanoseconds = 100.0;
  private static readonly Binding.Baselib_Memory_AllocateDelegate Baselib_Memory_AllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Allocate");
  private static readonly Binding.Baselib_Memory_ReallocateDelegate Baselib_Memory_ReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_ReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Reallocate");
  private static readonly Binding.Baselib_Memory_FreeDelegate Baselib_Memory_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_Free");
  private static readonly Binding.Baselib_Memory_AlignedAllocateDelegate Baselib_Memory_AlignedAllocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedAllocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedAllocate");
  private static readonly Binding.Baselib_Memory_AlignedReallocateDelegate Baselib_Memory_AlignedReallocateDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedReallocateDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedReallocate");
  private static readonly Binding.Baselib_Memory_AlignedFreeDelegate Baselib_Memory_AlignedFreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Memory_AlignedFreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Memory_AlignedFree");
  private static readonly Binding.Baselib_RegisteredNetwork_IsEmulatedDelegate Baselib_RegisteredNetwork_IsEmulatedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_IsEmulatedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_IsEmulated");
  private static readonly Binding.Baselib_SystemFutex_NativeSupportDelegate Baselib_SystemFutex_NativeSupportDelegateField = IL2CPP.ResolveICall<Binding.Baselib_SystemFutex_NativeSupportDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_NativeSupport");
  private static readonly Binding.Baselib_SystemFutex_WaitDelegate Baselib_SystemFutex_WaitDelegateField = IL2CPP.ResolveICall<Binding.Baselib_SystemFutex_WaitDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_Wait");
  private static readonly Binding.Baselib_SystemFutex_NotifyDelegate Baselib_SystemFutex_NotifyDelegateField = IL2CPP.ResolveICall<Binding.Baselib_SystemFutex_NotifyDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_SystemFutex_Notify");
  private static readonly Binding.Baselib_Thread_YieldExecutionDelegate Baselib_Thread_YieldExecutionDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_YieldExecutionDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_YieldExecution");
  private static readonly Binding.Baselib_Thread_GetCurrentThreadIdDelegate Baselib_Thread_GetCurrentThreadIdDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Thread_GetCurrentThreadIdDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Thread_GetCurrentThreadId");
  private static readonly Binding.Baselib_TLS_AllocDelegate Baselib_TLS_AllocDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_AllocDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Alloc");
  private static readonly Binding.Baselib_TLS_FreeDelegate Baselib_TLS_FreeDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_FreeDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Free");
  private static readonly Binding.Baselib_TLS_SetDelegate Baselib_TLS_SetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_SetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Set");
  private static readonly Binding.Baselib_TLS_GetDelegate Baselib_TLS_GetDelegateField = IL2CPP.ResolveICall<Binding.Baselib_TLS_GetDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_TLS_Get");
  private static readonly Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate Baselib_Timer_GetHighPrecisionTimerTicksDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetHighPrecisionTimerTicks");
  private static readonly Binding.Baselib_Timer_WaitForAtLeastDelegate Baselib_Timer_WaitForAtLeastDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_WaitForAtLeastDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_WaitForAtLeast");
  private static readonly Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField = IL2CPP.ResolveICall<Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_Timer_GetTimeSinceStartupInSeconds");
  private static readonly Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField = IL2CPP.ResolveICall<Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate>("Unity.Baselib.LowLevel.Binding::Baselib_RegisteredNetwork_Endpoint_Empty_Injected");

  public static IntPtr Baselib_Memory_Allocate(UIntPtr size)
  {
    return Binding.Baselib_Memory_AllocateDelegateField(size);
  }

  public static IntPtr Baselib_Memory_Reallocate(IntPtr ptr, UIntPtr newSize)
  {
    return Binding.Baselib_Memory_ReallocateDelegateField(ptr, newSize);
  }

  public static void Baselib_Memory_Free(IntPtr ptr)
  {
    Binding.Baselib_Memory_FreeDelegateField(ptr);
  }

  public static IntPtr Baselib_Memory_AlignedAllocate(UIntPtr size, UIntPtr alignment)
  {
    return Binding.Baselib_Memory_AlignedAllocateDelegateField(size, alignment);
  }

  public static IntPtr Baselib_Memory_AlignedReallocate(
    IntPtr ptr,
    UIntPtr newSize,
    UIntPtr alignment)
  {
    return Binding.Baselib_Memory_AlignedReallocateDelegateField(ptr, newSize, alignment);
  }

  public static void Baselib_Memory_AlignedFree(IntPtr ptr)
  {
    Binding.Baselib_Memory_AlignedFreeDelegateField(ptr);
  }

  public static bool Baselib_RegisteredNetwork_IsEmulated()
  {
    return Binding.Baselib_RegisteredNetwork_IsEmulatedDelegateField();
  }

  public static Binding.Baselib_RegisteredNetwork_Endpoint Baselib_RegisteredNetwork_Endpoint_Empty()
  {
    Binding.Baselib_RegisteredNetwork_Endpoint ret;
    Binding.Baselib_RegisteredNetwork_Endpoint_Empty_Injected(out ret);
    return ret;
  }

  public static bool Baselib_SystemFutex_NativeSupport()
  {
    return Binding.Baselib_SystemFutex_NativeSupportDelegateField();
  }

  public static void Baselib_SystemFutex_Wait(
    IntPtr address,
    int expected,
    uint timeoutInMilliseconds)
  {
    Binding.Baselib_SystemFutex_WaitDelegateField(address, expected, timeoutInMilliseconds);
  }

  public static void Baselib_SystemFutex_Notify(
    IntPtr address,
    uint count,
    Binding.Baselib_WakeupFallbackStrategy wakeupFallbackStrategy)
  {
    Binding.Baselib_SystemFutex_NotifyDelegateField(address, count, wakeupFallbackStrategy);
  }

  public static void Baselib_Thread_YieldExecution()
  {
    Binding.Baselib_Thread_YieldExecutionDelegateField();
  }

  public static IntPtr Baselib_Thread_GetCurrentThreadId()
  {
    return Binding.Baselib_Thread_GetCurrentThreadIdDelegateField();
  }

  public static UIntPtr Baselib_TLS_Alloc() => Binding.Baselib_TLS_AllocDelegateField();

  public static void Baselib_TLS_Free(UIntPtr handle)
  {
    Binding.Baselib_TLS_FreeDelegateField(handle);
  }

  public static void Baselib_TLS_Set(UIntPtr handle, UIntPtr value)
  {
    Binding.Baselib_TLS_SetDelegateField(handle, value);
  }

  public static UIntPtr Baselib_TLS_Get(UIntPtr handle)
  {
    return Binding.Baselib_TLS_GetDelegateField(handle);
  }

  public static ulong Baselib_Timer_GetHighPrecisionTimerTicks()
  {
    return Binding.Baselib_Timer_GetHighPrecisionTimerTicksDelegateField();
  }

  public static void Baselib_Timer_WaitForAtLeast(uint timeInMilliseconds)
  {
    Binding.Baselib_Timer_WaitForAtLeastDelegateField(timeInMilliseconds);
  }

  public static double Baselib_Timer_GetTimeSinceStartupInSeconds()
  {
    return Binding.Baselib_Timer_GetTimeSinceStartupInSecondsDelegateField();
  }

  public static void Baselib_RegisteredNetwork_Endpoint_Empty_Injected(
    out Binding.Baselib_RegisteredNetwork_Endpoint ret)
  {
    Binding.Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegateField((IntPtr) ref ret);
  }

  public enum Baselib_ErrorCode
  {
    UnexpectedError = -1, // 0xFFFFFFFF
    Success = 0,
    OutOfMemory = 16777216, // 0x01000000
    OutOfSystemResources = 16777217, // 0x01000001
    InvalidAddressRange = 16777218, // 0x01000002
    InvalidArgument = 16777219, // 0x01000003
    InvalidBufferSize = 16777220, // 0x01000004
    InvalidState = 16777221, // 0x01000005
    NotSupported = 16777222, // 0x01000006
    Timeout = 16777223, // 0x01000007
    UnsupportedAlignment = 33554432, // 0x02000000
    InvalidPageSize = 33554433, // 0x02000001
    InvalidPageCount = 33554434, // 0x02000002
    UnsupportedPageState = 33554435, // 0x02000003
    ThreadCannotJoinSelf = 50331648, // 0x03000000
    NetworkInitializationError = 67108864, // 0x04000000
    AddressInUse = 67108865, // 0x04000001
    AddressUnreachable = 67108866, // 0x04000002
    AddressFamilyNotSupported = 67108867, // 0x04000003
    Disconnected = 67108868, // 0x04000004
    InvalidPathname = 83886080, // 0x05000000
    RequestedAccessIsNotAllowed = 83886081, // 0x05000001
    IOError = 83886082, // 0x05000002
    FailedToOpenDynamicLibrary = 100663296, // 0x06000000
    FunctionNotFound = 100663297, // 0x06000001
    NoSupportedAddressFound = 117440512, // 0x07000000
    TryAgain = 117440513, // 0x07000001
  }

  public enum Baselib_ErrorState_NativeErrorCodeType : byte
  {
    None,
    PlatformDefined,
  }

  public enum Baselib_ErrorState_ExtraInformationType : byte
  {
    None,
    StaticString,
    GenerationCounter,
  }

  public enum Baselib_ErrorState_ExplainVerbosity
  {
    ErrorType,
    ErrorType_SourceLocation_Explanation,
  }

  public enum Baselib_FileIO_OpenFlags : uint
  {
    Read = 1,
    Write = 2,
    OpenAlways = 4,
    CreateAlways = 8,
  }

  public enum Baselib_FileIO_Priority
  {
    Normal,
    High,
  }

  public enum Baselib_FileIO_EventQueue_ResultType
  {
    Baselib_FileIO_EventQueue_Callback = 1,
    Baselib_FileIO_EventQueue_OpenFile = 2,
    Baselib_FileIO_EventQueue_ReadFile = 3,
    Baselib_FileIO_EventQueue_CloseFile = 4,
  }

  public enum Baselib_Memory_PageState
  {
    Reserved = 0,
    NoAccess = 1,
    ReadOnly = 2,
    ReadWrite = 4,
    ReadOnly_Executable = 18, // 0x00000012
    ReadWrite_Executable = 20, // 0x00000014
  }

  public enum Baselib_NetworkAddress_Family
  {
    Invalid,
    IPv4,
    IPv6,
  }

  public enum Baselib_NetworkAddress_AddressReuse
  {
    DoNotAllow,
    Allow,
  }

  public struct Baselib_RegisteredNetwork_Endpoint
  {
  }

  public enum Baselib_RegisteredNetwork_CompletionStatus
  {
    Failed,
    Success,
  }

  public enum Baselib_RegisteredNetwork_ProcessStatus
  {
    Done = 0,
    NonePendingImmediately = 0,
    Pending = 1,
  }

  public enum Baselib_RegisteredNetwork_CompletionQueueStatus
  {
    NoResultsAvailable,
    ResultsAvailable,
  }

  public enum Baselib_Socket_Protocol
  {
    UDP = 1,
    TCP = 2,
  }

  public enum Baselib_Socket_PollEvents
  {
    Readable = 1,
    Writable = 2,
    Connected = 4,
  }

  public enum Baselib_WakeupFallbackStrategy
  {
    OneByOne,
    All,
  }

  private delegate IntPtr Baselib_Memory_AllocateDelegate(UIntPtr size);

  private delegate IntPtr Baselib_Memory_ReallocateDelegate(IntPtr ptr, UIntPtr newSize);

  private delegate void Baselib_Memory_FreeDelegate(IntPtr ptr);

  private delegate IntPtr Baselib_Memory_AlignedAllocateDelegate(UIntPtr size, UIntPtr alignment);

  private delegate IntPtr Baselib_Memory_AlignedReallocateDelegate(
    IntPtr ptr,
    UIntPtr newSize,
    UIntPtr alignment);

  private delegate void Baselib_Memory_AlignedFreeDelegate(IntPtr ptr);

  private delegate bool Baselib_RegisteredNetwork_IsEmulatedDelegate();

  private delegate bool Baselib_SystemFutex_NativeSupportDelegate();

  private delegate void Baselib_SystemFutex_WaitDelegate(
    IntPtr address,
    int expected,
    uint timeoutInMilliseconds);

  private delegate void Baselib_SystemFutex_NotifyDelegate(
    IntPtr address,
    uint count,
    Binding.Baselib_WakeupFallbackStrategy wakeupFallbackStrategy);

  private delegate void Baselib_Thread_YieldExecutionDelegate();

  private delegate IntPtr Baselib_Thread_GetCurrentThreadIdDelegate();

  private delegate UIntPtr Baselib_TLS_AllocDelegate();

  private delegate void Baselib_TLS_FreeDelegate(UIntPtr handle);

  private delegate void Baselib_TLS_SetDelegate(UIntPtr handle, UIntPtr value);

  private delegate UIntPtr Baselib_TLS_GetDelegate(UIntPtr handle);

  private delegate ulong Baselib_Timer_GetHighPrecisionTimerTicksDelegate();

  private delegate void Baselib_Timer_WaitForAtLeastDelegate(uint timeInMilliseconds);

  private delegate double Baselib_Timer_GetTimeSinceStartupInSecondsDelegate();

  private delegate void Baselib_RegisteredNetwork_Endpoint_Empty_InjectedDelegate([Out] IntPtr ret);
}
