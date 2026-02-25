// Decompiled with JetBrains decompiler
// Type: UnityEngine.DebugLogHandler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class DebugLogHandler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Log_Injected_Private_Static_Void_LogType_LogOption_byref_ManagedSpanWrapper_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_LogException_Injected_Private_Static_Void_Exception_IntPtr_0;

  static DebugLogHandler()
  {
    Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (DebugLogHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr);
    DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664366);
    DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664367);
    DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664368 /*0x06000430*/);
    DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664369);
    DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664370);
    DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664371);
    DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Injected_Private_Static_Void_LogType_LogOption_byref_ManagedSpanWrapper_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664372);
    DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Injected_Private_Static_Void_Exception_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664373);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 419698, RefRangeEnd = 419701, XrefRangeStart = 419681, XrefRangeEnd = 419698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Log(LogType level, LogOption options, string msg, Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &level;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(msg);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419701, XrefRangeEnd = 419706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_LogException(Il2CppSystem.Exception ex, Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ex);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419706, XrefRangeEnd = 419708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogFormat(
    LogType logType,
    Object context,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419708, XrefRangeEnd = 419710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogFormat(
    LogType logType,
    LogOption logOptions,
    Object context,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logOptions;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419710, XrefRangeEnd = 419721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogException(Il2CppSystem.Exception exception, Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DebugLogHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419721, XrefRangeEnd = 419723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Log_Injected(
    LogType level,
    LogOption options,
    ref ManagedSpanWrapper msg,
    System.IntPtr obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &level;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref msg;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &obj;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Injected_Private_Static_Void_LogType_LogOption_byref_ManagedSpanWrapper_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 419723, XrefRangeEnd = 419725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_LogException_Injected(Il2CppSystem.Exception ex, System.IntPtr obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ex);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Injected_Private_Static_Void_Exception_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual void LogFormat(
    LogType logType,
    Object context,
    string format,
    params Il2CppSystem.Object[] args)
  {
    this.LogFormat(logType, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public void LogFormat(
    LogType logType,
    LogOption logOptions,
    Object context,
    string format,
    params Il2CppSystem.Object[] args)
  {
    this.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }
}
