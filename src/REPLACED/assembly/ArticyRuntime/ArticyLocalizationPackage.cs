// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLocalizationPackage
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

public sealed class ArticyLocalizationPackage(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedStringsKeys;
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedStringsValues;
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedStrings;
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedAudioAssetsKeys;
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedAudioAssetsValues;
  private static readonly IntPtr NativeFieldInfoPtr_mLocalizedAudioAssets;
  private static readonly IntPtr NativeMethodInfoPtr_get_LocaKeys_Internal_get_List_1_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedStrings_Internal_get_Dictionary_2_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LocalizedStrings_Internal_set_Void_Dictionary_2_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LocalizedVOAssets_Internal_get_Dictionary_2_String_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_LocalizedVOAssets_Internal_set_Void_Dictionary_2_String_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyLocalizationPackage()
  {
    Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLocalizationPackage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr);
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedStringsKeys));
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedStringsValues));
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedStrings));
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedAudioAssetsKeys));
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedAudioAssetsValues));
    ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, nameof (mLocalizedAudioAssets));
    ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocaKeys_Internal_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663594);
    ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocalizedStrings_Internal_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663595);
    ArticyLocalizationPackage.NativeMethodInfoPtr_set_LocalizedStrings_Internal_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663596);
    ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocalizedVOAssets_Internal_get_Dictionary_2_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663597);
    ArticyLocalizationPackage.NativeMethodInfoPtr_set_LocalizedVOAssets_Internal_set_Void_Dictionary_2_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663598);
    ArticyLocalizationPackage.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663599);
    ArticyLocalizationPackage.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663600 /*0x06000130*/);
    ArticyLocalizationPackage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr, 100663601);
  }

  public unsafe List<string> LocaKeys
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocaKeys_Internal_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
    }
  }

  public unsafe Dictionary<string, string> LocalizedStrings
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocalizedStrings_Internal_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_set_LocalizedStrings_Internal_set_Void_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Dictionary<string, ulong> LocalizedVOAssets
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_get_LocalizedVOAssets_Internal_get_Dictionary_2_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Dictionary<string, ulong>) null : Il2CppObjectPool.Get<Dictionary<string, ulong>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_set_LocalizedVOAssets_Internal_set_Void_Dictionary_2_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988679, XrefRangeEnd = 988730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988730, XrefRangeEnd = 988755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988755, XrefRangeEnd = 988788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLocalizationPackage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationPackage>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationPackage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<string> mLocalizedStringsKeys
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsKeys));
      return num == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mLocalizedStringsValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsValues));
      return num == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStringsValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, string> mLocalizedStrings
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStrings));
      return num == IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> mLocalizedAudioAssetsKeys
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsKeys));
      return num == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ulong> mLocalizedAudioAssetsValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsValues));
      return num == IntPtr.Zero ? (List<ulong>) null : Il2CppObjectPool.Get<List<ulong>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssetsValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, ulong> mLocalizedAudioAssets
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssets));
      return num == IntPtr.Zero ? (Dictionary<string, ulong>) null : Il2CppObjectPool.Get<Dictionary<string, ulong>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationPackage.NativeFieldInfoPtr_mLocalizedAudioAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
