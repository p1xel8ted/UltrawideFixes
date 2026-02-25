// Decompiled with JetBrains decompiler
// Type: UnityEngine.Logger
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class Logger(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__logHandler_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__logEnabled_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__filterLogType_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetString_Private_Static_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;
  public const string kNoTagFormat = "{0}";
  public const string kTagFormat = "{0}: {1}";

  static Logger()
  {
    Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Logger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger>.NativeClassPtr);
    Logger.NativeFieldInfoPtr__logHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logHandler>k__BackingField");
    Logger.NativeFieldInfoPtr__logEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<logEnabled>k__BackingField");
    Logger.NativeFieldInfoPtr__filterLogType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "<filterLogType>k__BackingField");
    Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667214);
    Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667215);
    Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667216 /*0x06000F50*/);
    Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667217);
    Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667218);
    Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667219);
    Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667220);
    Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667221);
    Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667222);
    Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667223);
    Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667224);
    Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667225);
    Logger.NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667226);
    Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667227);
    Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667228);
    Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667229);
    Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667230);
    Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100667231);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437915, XrefRangeEnd = 437916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Logger(ILogHandler logHandler)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Logger>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) logHandler)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr__ctor_Public_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe ILogHandler logHandler
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logHandler_Public_Virtual_Final_New_get_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ILogHandler) null : Il2CppObjectPool.Get<ILogHandler>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logHandler_Public_Virtual_Final_New_set_Void_ILogHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool logEnabled
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64591, XrefRangeStart = 64585, XrefRangeEnd = 64591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_logEnabled_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_logEnabled_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe LogType filterLogType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_get_filterLogType_Public_Virtual_Final_New_get_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LogType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_set_filterLogType_Public_Virtual_Final_New_set_Void_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool IsLogTypeAllowed(LogType logType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &logType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_IsLogTypeAllowed_Public_Virtual_Final_New_Boolean_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 437921, RefRangeEnd = 437926, XrefRangeStart = 437916, XrefRangeEnd = 437921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetString(Il2CppSystem.Object message)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_GetString_Private_Static_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437926, XrefRangeEnd = 437936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Log(LogType logType, Il2CppSystem.Object message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437936, XrefRangeEnd = 437946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Log(LogType logType, Il2CppSystem.Object message, Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_LogType_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437946, XrefRangeEnd = 437957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Log(string tag, Il2CppSystem.Object message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_Log_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437957, XrefRangeEnd = 437968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogWarning(string tag, Il2CppSystem.Object message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogWarning_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437968, XrefRangeEnd = 437979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogError(string tag, Il2CppSystem.Object message)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(tag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) message);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogError_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437979, XrefRangeEnd = 437982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogException(Il2CppSystem.Exception exception)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437982, XrefRangeEnd = 437985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogException(Il2CppSystem.Exception exception, Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) exception);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437985, XrefRangeEnd = 437988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void LogFormat(
    LogType logType,
    string format,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    if (args == null)
      args = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &logType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437988, XrefRangeEnd = 437991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual void LogFormat(LogType logType, string format, params Il2CppSystem.Object[] args)
  {
    this.LogFormat(logType, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public virtual void LogFormat(
    LogType logType,
    Object context,
    string format,
    params Il2CppSystem.Object[] args)
  {
    this.LogFormat(logType, context, format, new Il2CppReferenceArray<Il2CppSystem.Object>(args));
  }

  public unsafe ILogHandler _logHandler_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField));
      return num == System.IntPtr.Zero ? (ILogHandler) null : Il2CppObjectPool.Get<ILogHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _logEnabled_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__logEnabled_k__BackingField)) = value;
    }
  }

  public unsafe LogType _filterLogType_k__BackingField
  {
    get
    {
      return *(LogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField));
    }
    [param: In] set
    {
      *(LogType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Logger.NativeFieldInfoPtr__filterLogType_k__BackingField)) = value;
    }
  }

  public void Log(LogType logType, string tag, Il2CppSystem.Object message)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void Log(LogType logType, string tag, Il2CppSystem.Object message, Object context)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void Log(Il2CppSystem.Object message)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void Log(string tag, Il2CppSystem.Object message, Object context)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void LogWarning(string tag, Il2CppSystem.Object message, Object context)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void LogError(string tag, Il2CppSystem.Object message, Object context)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
