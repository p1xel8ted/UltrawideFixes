// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyRuntimeSettings
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyRuntimeSettings(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__Auxiliary_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_sInstance;
  private static readonly IntPtr NativeFieldInfoPtr_sDefaultLogVerbositiesMap;
  private static readonly IntPtr NativeFieldInfoPtr_mIsTransientInstance;
  private static readonly IntPtr NativeFieldInfoPtr_mAssemblyNameGeneratedContent;
  private static readonly IntPtr NativeFieldInfoPtr_mUseAddressables;
  private static readonly IntPtr NativeFieldInfoPtr_mInitializeAddressablesAsync;
  private static readonly IntPtr NativeFieldInfoPtr_mResolveInvalidTokensAsEmptyString;
  private static readonly IntPtr NativeFieldInfoPtr_mAutomaticallyResolveStrings;
  private static readonly IntPtr NativeFieldInfoPtr_mLogVerbositiesMap;
  private static readonly IntPtr NativeFieldInfoPtr_mLogVerbositiesMapKeys;
  private static readonly IntPtr NativeFieldInfoPtr_mLogVerbositiesMapValues;
  private static readonly IntPtr NativeMethodInfoPtr_get_ArticyRuntimeSettingsAssetFileName_Internal_Static_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_DefaultLogVerbositiesMap_Internal_Static_get_Dictionary_2_ArticyLogSubsystem_ArticyLogVerbosity_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AssemblyNameGeneratedContent_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AssemblyNameGeneratedContent_Public_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_UseAddressables_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_UseAddressables_Internal_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_InitializeAddressablesAsync_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_InitializeAddressablesAsync_Internal_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AutomaticallyResolveStrings_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_AutomaticallyResolveStrings_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ResolveInvalidTokensAsEmptyString_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_ResolveInvalidTokensAsEmptyString_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetLogVerbosity_Public_ArticyLogVerbosity_ArticyLogSubsystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetLogVerbosity_Public_Void_ArticyLogSubsystem_ArticyLogVerbosity_0;
  private static readonly IntPtr NativeMethodInfoPtr_SaveChanges_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSettings_Public_Static_ArticyRuntimeSettings_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyRuntimeSettings()
  {
    Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyRuntimeSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr);
    ArticyRuntimeSettings.NativeFieldInfoPtr__Auxiliary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, "<Auxiliary>k__BackingField");
    ArticyRuntimeSettings.NativeFieldInfoPtr_sInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (sInstance));
    ArticyRuntimeSettings.NativeFieldInfoPtr_sDefaultLogVerbositiesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (sDefaultLogVerbositiesMap));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mIsTransientInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mIsTransientInstance));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mAssemblyNameGeneratedContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mAssemblyNameGeneratedContent));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mUseAddressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mUseAddressables));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mInitializeAddressablesAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mInitializeAddressablesAsync));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mResolveInvalidTokensAsEmptyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mResolveInvalidTokensAsEmptyString));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mAutomaticallyResolveStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mAutomaticallyResolveStrings));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mLogVerbositiesMap));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mLogVerbositiesMapKeys));
    ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, nameof (mLogVerbositiesMapValues));
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_ArticyRuntimeSettingsAssetFileName_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663821 /*0x0600020D*/);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663822 /*0x0600020E*/);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663823 /*0x0600020F*/);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_DefaultLogVerbositiesMap_Internal_Static_get_Dictionary_2_ArticyLogSubsystem_ArticyLogVerbosity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663824 /*0x06000210*/);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_AssemblyNameGeneratedContent_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663825);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_AssemblyNameGeneratedContent_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663826);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_UseAddressables_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663827);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_UseAddressables_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663828);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_InitializeAddressablesAsync_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663829);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_InitializeAddressablesAsync_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663830);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_AutomaticallyResolveStrings_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663831);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_AutomaticallyResolveStrings_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663832);
    ArticyRuntimeSettings.NativeMethodInfoPtr_get_ResolveInvalidTokensAsEmptyString_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663833);
    ArticyRuntimeSettings.NativeMethodInfoPtr_set_ResolveInvalidTokensAsEmptyString_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663834);
    ArticyRuntimeSettings.NativeMethodInfoPtr_GetLogVerbosity_Public_ArticyLogVerbosity_ArticyLogSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663835);
    ArticyRuntimeSettings.NativeMethodInfoPtr_SetLogVerbosity_Public_Void_ArticyLogSubsystem_ArticyLogVerbosity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663836);
    ArticyRuntimeSettings.NativeMethodInfoPtr_SaveChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663837);
    ArticyRuntimeSettings.NativeMethodInfoPtr_GetSettings_Public_Static_ArticyRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663838);
    ArticyRuntimeSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663839);
    ArticyRuntimeSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663840 /*0x06000220*/);
    ArticyRuntimeSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr, 100663841);
  }

  public static unsafe string ArticyRuntimeSettingsAssetFileName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991004, XrefRangeEnd = 991010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_ArticyRuntimeSettingsAssetFileName_Internal_Static_get_String_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public static unsafe ArticyEditorAuxiliary Auxiliary
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991010, XrefRangeEnd = 991012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991012, XrefRangeEnd = 991014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0, IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe Dictionary<ArticyLogSubsystem, ArticyLogVerbosity> DefaultLogVerbositiesMap
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 991099, RefRangeEnd = 991100, XrefRangeStart = 991014, XrefRangeEnd = 991099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_DefaultLogVerbositiesMap_Internal_Static_get_Dictionary_2_ArticyLogSubsystem_ArticyLogVerbosity_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>) null : Il2CppObjectPool.Get<Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>>(num3);
    }
  }

  public unsafe string AssemblyNameGeneratedContent
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_AssemblyNameGeneratedContent_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991100, XrefRangeEnd = 991102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_AssemblyNameGeneratedContent_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UseAddressables
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_UseAddressables_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991102, XrefRangeEnd = 991103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_UseAddressables_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool InitializeAddressablesAsync
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_InitializeAddressablesAsync_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991103, XrefRangeEnd = 991104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_InitializeAddressablesAsync_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool AutomaticallyResolveStrings
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_AutomaticallyResolveStrings_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991104, XrefRangeEnd = 991105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_AutomaticallyResolveStrings_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool ResolveInvalidTokensAsEmptyString
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_get_ResolveInvalidTokensAsEmptyString_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991105, XrefRangeEnd = 991106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_set_ResolveInvalidTokensAsEmptyString_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 991133, RefRangeEnd = 991134, XrefRangeStart = 991106, XrefRangeEnd = 991133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLogVerbosity GetLogVerbosity(ArticyLogSubsystem aLogSubsystem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &aLogSubsystem
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_GetLogVerbosity_Public_ArticyLogVerbosity_ArticyLogSubsystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ArticyLogVerbosity*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991134, XrefRangeEnd = 991141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLogVerbosity(
    ArticyLogSubsystem aLogSubsystem,
    ArticyLogVerbosity aLogVerbosity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &aLogSubsystem;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &aLogVerbosity;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_SetLogVerbosity_Public_Void_ArticyLogSubsystem_ArticyLogVerbosity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 991147, RefRangeEnd = 991153, XrefRangeStart = 991141, XrefRangeEnd = 991147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveChanges()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_SaveChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 991198, RefRangeEnd = 991218, XrefRangeStart = 991153, XrefRangeEnd = 991198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyRuntimeSettings GetSettings()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_GetSettings_Public_Static_ArticyRuntimeSettings_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ArticyRuntimeSettings) null : Il2CppObjectPool.Get<ArticyRuntimeSettings>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991218, XrefRangeEnd = 991244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991244, XrefRangeEnd = 991258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991258, XrefRangeEnd = 991279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyRuntimeSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyRuntimeSettings>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRuntimeSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyEditorAuxiliary _Auxiliary_k__BackingField
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyRuntimeSettings.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyRuntimeSettings.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ArticyRuntimeSettings sInstance
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyRuntimeSettings.NativeFieldInfoPtr_sInstance, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (ArticyRuntimeSettings) null : Il2CppObjectPool.Get<ArticyRuntimeSettings>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyRuntimeSettings.NativeFieldInfoPtr_sInstance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Dictionary<ArticyLogSubsystem, ArticyLogVerbosity> sDefaultLogVerbositiesMap
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyRuntimeSettings.NativeFieldInfoPtr_sDefaultLogVerbositiesMap, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>) null : Il2CppObjectPool.Get<Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyRuntimeSettings.NativeFieldInfoPtr_sDefaultLogVerbositiesMap, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mIsTransientInstance
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mIsTransientInstance));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mIsTransientInstance)) = value;
    }
  }

  public unsafe string mAssemblyNameGeneratedContent
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mAssemblyNameGeneratedContent)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mAssemblyNameGeneratedContent), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mUseAddressables
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mUseAddressables));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mUseAddressables)) = value;
    }
  }

  public unsafe bool mInitializeAddressablesAsync
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mInitializeAddressablesAsync));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mInitializeAddressablesAsync)) = value;
    }
  }

  public unsafe bool mResolveInvalidTokensAsEmptyString
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mResolveInvalidTokensAsEmptyString));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mResolveInvalidTokensAsEmptyString)) = value;
    }
  }

  public unsafe bool mAutomaticallyResolveStrings
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mAutomaticallyResolveStrings));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mAutomaticallyResolveStrings)) = value;
    }
  }

  public unsafe Dictionary<ArticyLogSubsystem, ArticyLogVerbosity> mLogVerbositiesMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMap));
      return num == IntPtr.Zero ? (Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>) null : Il2CppObjectPool.Get<Dictionary<ArticyLogSubsystem, ArticyLogVerbosity>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyLogSubsystem> mLogVerbositiesMapKeys
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapKeys));
      return num == IntPtr.Zero ? (List<ArticyLogSubsystem>) null : Il2CppObjectPool.Get<List<ArticyLogSubsystem>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyLogVerbosity> mLogVerbositiesMapValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapValues));
      return num == IntPtr.Zero ? (List<ArticyLogVerbosity>) null : Il2CppObjectPool.Get<List<ArticyLogVerbosity>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyRuntimeSettings.NativeFieldInfoPtr_mLogVerbositiesMapValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
