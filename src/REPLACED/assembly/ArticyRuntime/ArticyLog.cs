// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLog
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public static class ArticyLog : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mSuppressedTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr_sArticyToUnityVerbosityMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_mForceInternalLoggingEnabled;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Settings_Private_Static_get_ArticyRuntimeSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InternalLoggingEnabled_Internal_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogInfo_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogInternal_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ArticyLogSubsystem_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushSuppression_Internal_Static_Void_ArticyLogSubsystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopSuppression_Internal_Static_Void_ArticyLogSubsystem_0;

  static ArticyLog()
  {
    Il2CppClassPointerStore<ArticyLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLog));
    ArticyLog.NativeFieldInfoPtr_mSuppressedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, nameof (mSuppressedTypes));
    ArticyLog.NativeFieldInfoPtr_sArticyToUnityVerbosityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, nameof (sArticyToUnityVerbosityMap));
    ArticyLog.NativeFieldInfoPtr_mSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, nameof (mSettings));
    ArticyLog.NativeFieldInfoPtr_mForceInternalLoggingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, nameof (mForceInternalLoggingEnabled));
    ArticyLog.NativeMethodInfoPtr_get_Settings_Private_Static_get_ArticyRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663625);
    ArticyLog.NativeMethodInfoPtr_get_InternalLoggingEnabled_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663626);
    ArticyLog.NativeMethodInfoPtr_LogInfo_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663627);
    ArticyLog.NativeMethodInfoPtr_LogWarning_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663628);
    ArticyLog.NativeMethodInfoPtr_LogError_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663629);
    ArticyLog.NativeMethodInfoPtr_LogInternal_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663630);
    ArticyLog.NativeMethodInfoPtr_Log_Public_Static_Void_ArticyLogSubsystem_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663631);
    ArticyLog.NativeMethodInfoPtr_PushSuppression_Internal_Static_Void_ArticyLogSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663632 /*0x06000150*/);
    ArticyLog.NativeMethodInfoPtr_PopSuppression_Internal_Static_Void_ArticyLogSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, 100663633);
  }

  public static unsafe ArticyRuntimeSettings Settings
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989033, XrefRangeEnd = 989048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_get_Settings_Private_Static_get_ArticyRuntimeSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRuntimeSettings) null : Il2CppObjectPool.Get<ArticyRuntimeSettings>(num3);
    }
  }

  public static unsafe bool InternalLoggingEnabled
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989048, XrefRangeEnd = 989052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_get_InternalLoggingEnabled_Internal_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989052, XrefRangeEnd = 989056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogInfo(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aSubsystem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_LogInfo_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 989060, RefRangeEnd = 989063, XrefRangeStart = 989056, XrefRangeEnd = 989060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogWarning(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aSubsystem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_LogWarning_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989063, XrefRangeEnd = 989067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogError(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aSubsystem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_LogError_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989067, XrefRangeEnd = 989071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LogInternal(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aSubsystem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_LogInternal_Public_Static_Void_ArticyLogSubsystem_Object_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 989119, RefRangeEnd = 989133, XrefRangeStart = 989071, XrefRangeEnd = 989119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Log(
    ArticyLogSubsystem aSubsystem,
    ArticyLogVerbosity aVerbosity,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &aSubsystem;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aVerbosity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_Log_Public_Static_Void_ArticyLogSubsystem_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989133, XrefRangeEnd = 989210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PushSuppression(ArticyLogSubsystem aSubsystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aSubsystem
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_PushSuppression_Internal_Static_Void_ArticyLogSubsystem_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989210, XrefRangeEnd = 989218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PopSuppression(ArticyLogSubsystem aSubsystem)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aSubsystem
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLog.NativeMethodInfoPtr_PopSuppression_Internal_Static_Void_ArticyLogSubsystem_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static void LogInfo(ArticyLogSubsystem aSubsystem, Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    ArticyLog.LogInfo(aSubsystem, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public static void LogWarning(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    params Il2CppSystem.Object[] aArgs)
  {
    ArticyLog.LogWarning(aSubsystem, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public static void LogError(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    params Il2CppSystem.Object[] aArgs)
  {
    ArticyLog.LogError(aSubsystem, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public static void LogInternal(
    ArticyLogSubsystem aSubsystem,
    Il2CppSystem.Object aMessage,
    params Il2CppSystem.Object[] aArgs)
  {
    ArticyLog.LogInternal(aSubsystem, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public static void Log(
    ArticyLogSubsystem aSubsystem,
    ArticyLogVerbosity aVerbosity,
    Il2CppSystem.Object aMessage,
    params Il2CppSystem.Object[] aArgs)
  {
    ArticyLog.Log(aSubsystem, aVerbosity, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public ArticyLog(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe HashSet<ArticyLogSubsystem> mSuppressedTypes
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLog.NativeFieldInfoPtr_mSuppressedTypes, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (HashSet<ArticyLogSubsystem>) null : Il2CppObjectPool.Get<HashSet<ArticyLogSubsystem>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLog.NativeFieldInfoPtr_mSuppressedTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<ArticyLogVerbosity, LogType> sArticyToUnityVerbosityMap
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLog.NativeFieldInfoPtr_sArticyToUnityVerbosityMap, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<ArticyLogVerbosity, LogType>) null : Il2CppObjectPool.Get<Dictionary<ArticyLogVerbosity, LogType>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLog.NativeFieldInfoPtr_sArticyToUnityVerbosityMap, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ArticyRuntimeSettings mSettings
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLog.NativeFieldInfoPtr_mSettings, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyRuntimeSettings) null : Il2CppObjectPool.Get<ArticyRuntimeSettings>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLog.NativeFieldInfoPtr_mSettings, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool mForceInternalLoggingEnabled
  {
    get
    {
      bool internalLoggingEnabled;
      IL2CPP.il2cpp_field_static_get_value(ArticyLog.NativeFieldInfoPtr_mForceInternalLoggingEnabled, (void*) &internalLoggingEnabled);
      return internalLoggingEnabled;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLog.NativeFieldInfoPtr_mForceInternalLoggingEnabled, (void*) &value);
    }
  }

  public class SuppressionHandle(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_mSubsystem;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyLogSubsystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

    static SuppressionHandle()
    {
      Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLog>.NativeClassPtr, nameof (SuppressionHandle));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr);
      ArticyLog.SuppressionHandle.NativeFieldInfoPtr_mSubsystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr, nameof (mSubsystem));
      ArticyLog.SuppressionHandle.NativeMethodInfoPtr__ctor_Public_Void_ArticyLogSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr, 100663634);
      ArticyLog.SuppressionHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr, 100663635);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989010, XrefRangeEnd = 989022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SuppressionHandle(ArticyLogSubsystem aSubsystem)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLog.SuppressionHandle>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &aSubsystem
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLog.SuppressionHandle.NativeMethodInfoPtr__ctor_Public_Void_ArticyLogSubsystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989022, XrefRangeEnd = 989033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLog.SuppressionHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ArticyLogSubsystem mSubsystem
    {
      get
      {
        return *(ArticyLogSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLog.SuppressionHandle.NativeFieldInfoPtr_mSubsystem));
      }
      [param: In] set
      {
        *(ArticyLogSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLog.SuppressionHandle.NativeFieldInfoPtr_mSubsystem)) = value;
      }
    }
  }
}
