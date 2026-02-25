// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Logging.LoggingInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Epic.OnlineServices.Logging;

public static class LoggingInterface : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_IntPtr_0;

  static LoggingInterface()
  {
    Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Logging", nameof (LoggingInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr);
    LoggingInterface.NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100668815);
    LoggingInterface.NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100668816);
    LoggingInterface.NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoggingInterface>.NativeClassPtr, 100668817);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388304, XrefRangeEnd = 388320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Result SetCallback(LogMessageFunc callback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_SetCallback_Public_Static_Result_LogMessageFunc_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388320, XrefRangeEnd = 388321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Result SetLogLevel(LogCategory logCategory, LogLevel logLevel)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &logCategory;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logLevel;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_SetLogLevel_Public_Static_Result_LogCategory_LogLevel_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388321, XrefRangeEnd = 388334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogMessageFuncInternalImplementation(System.IntPtr message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &message
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoggingInterface.NativeMethodInfoPtr_LogMessageFuncInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public LoggingInterface(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
