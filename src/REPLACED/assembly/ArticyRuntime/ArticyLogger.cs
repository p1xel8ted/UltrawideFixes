// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLogger
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class ArticyLogger(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLogSubsystem;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyLogSubsystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogInfo_Public_Void_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogWarning_Public_Void_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogError_Public_Void_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LogInternal_Public_Void_Object_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Void_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0;

  static ArticyLogger()
  {
    Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLogger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr);
    ArticyLogger.NativeFieldInfoPtr_mLogSubsystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, nameof (mLogSubsystem));
    ArticyLogger.NativeMethodInfoPtr__ctor_Internal_Void_ArticyLogSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663618);
    ArticyLogger.NativeMethodInfoPtr_LogInfo_Public_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663619);
    ArticyLogger.NativeMethodInfoPtr_LogWarning_Public_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663620);
    ArticyLogger.NativeMethodInfoPtr_LogError_Public_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663621);
    ArticyLogger.NativeMethodInfoPtr_LogInternal_Public_Void_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663622);
    ArticyLogger.NativeMethodInfoPtr_Log_Public_Void_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr, 100663623);
  }

  [CallerCount(64 /*0x40*/)]
  [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLogger(ArticyLogSubsystem aLogSubsystem)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLogger>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aLogSubsystem
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr__ctor_Internal_Void_ArticyLogSubsystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 988925, RefRangeEnd = 988949, XrefRangeStart = 988921, XrefRangeEnd = 988925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogInfo(Il2CppSystem.Object aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr_LogInfo_Public_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 988953, RefRangeEnd = 988962, XrefRangeStart = 988949, XrefRangeEnd = 988953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogWarning(Il2CppSystem.Object aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr_LogWarning_Public_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 988966, RefRangeEnd = 989001, XrefRangeStart = 988962, XrefRangeEnd = 988966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogError(Il2CppSystem.Object aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr_LogError_Public_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 989005, RefRangeEnd = 989006, XrefRangeStart = 989001, XrefRangeEnd = 989005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LogInternal(Il2CppSystem.Object aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr_LogInternal_Public_Void_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989006, XrefRangeEnd = 989010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Log(
    ArticyLogVerbosity aVerbosity,
    Il2CppSystem.Object aMessage,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aArgs)
  {
    if (aArgs == null)
      aArgs = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &aVerbosity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArgs);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLogger.NativeMethodInfoPtr_Log_Public_Void_ArticyLogVerbosity_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public void LogInfo(Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    this.LogInfo(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public void LogWarning(Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    this.LogWarning(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public void LogError(Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    this.LogError(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public void LogInternal(Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    this.LogInternal(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public void Log(ArticyLogVerbosity aVerbosity, Il2CppSystem.Object aMessage, params Il2CppSystem.Object[] aArgs)
  {
    this.Log(aVerbosity, aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aArgs));
  }

  public unsafe ArticyLogSubsystem mLogSubsystem
  {
    get
    {
      return *(ArticyLogSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLogger.NativeFieldInfoPtr_mLogSubsystem));
    }
    [param: In] set
    {
      *(ArticyLogSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLogger.NativeFieldInfoPtr_mLogSubsystem)) = value;
    }
  }
}
