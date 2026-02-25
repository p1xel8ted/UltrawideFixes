// Decompiled with JetBrains decompiler
// Type: Rewired.Localization.LocalizedStringProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Localization;

public class LocalizedStringProvider(IntPtr pointer) : LocalizedStringProviderBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__localizedStringsFile;
  private static readonly IntPtr NativeFieldInfoPtr__dictionary;
  private static readonly IntPtr NativeFieldInfoPtr__initialized;
  private static readonly IntPtr NativeMethodInfoPtr_get_dictionary_Protected_Virtual_New_get_Dictionary_2_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_dictionary_Protected_Virtual_New_set_Void_Dictionary_2_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_localizedStringsFile_Public_Virtual_New_get_TextAsset_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_localizedStringsFile_Public_Virtual_New_set_Void_TextAsset_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Protected_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryLoadLocalizedStringData_Protected_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalizedString_Protected_Virtual_Boolean_String_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalizedStringProvider()
  {
    Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Localization", nameof (LocalizedStringProvider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr);
    LocalizedStringProvider.NativeFieldInfoPtr__localizedStringsFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, nameof (_localizedStringsFile));
    LocalizedStringProvider.NativeFieldInfoPtr__dictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, nameof (_dictionary));
    LocalizedStringProvider.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, nameof (_initialized));
    LocalizedStringProvider.NativeMethodInfoPtr_get_dictionary_Protected_Virtual_New_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668472);
    LocalizedStringProvider.NativeMethodInfoPtr_set_dictionary_Protected_Virtual_New_set_Void_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668473);
    LocalizedStringProvider.NativeMethodInfoPtr_get_localizedStringsFile_Public_Virtual_New_get_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668474);
    LocalizedStringProvider.NativeMethodInfoPtr_set_localizedStringsFile_Public_Virtual_New_set_Void_TextAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668475);
    LocalizedStringProvider.NativeMethodInfoPtr_get_initialized_Protected_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668476);
    LocalizedStringProvider.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668477);
    LocalizedStringProvider.NativeMethodInfoPtr_TryLoadLocalizedStringData_Protected_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668478);
    LocalizedStringProvider.NativeMethodInfoPtr_TryGetLocalizedString_Protected_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668479);
    LocalizedStringProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr, 100668480);
  }

  public virtual unsafe Dictionary<string, string> dictionary
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_get_dictionary_Protected_Virtual_New_get_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_set_dictionary_Protected_Virtual_New_set_Void_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe TextAsset localizedStringsFile
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_get_localizedStringsFile_Public_Virtual_New_get_TextAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (TextAsset) null : Il2CppObjectPool.Get<TextAsset>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_set_localizedStringsFile_Public_Virtual_New_set_Void_TextAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe bool initialized
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_get_initialized_Protected_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public override unsafe bool Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_Initialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68660, XrefRangeEnd = 68681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool TryLoadLocalizedStringData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_TryLoadLocalizedStringData_Protected_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68681, XrefRangeEnd = 68684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool TryGetLocalizedString(string key, out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProvider.NativeMethodInfoPtr_TryGetLocalizedString_Protected_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68684, XrefRangeEnd = 68691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizedStringProvider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringProvider>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizedStringProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TextAsset _localizedStringsFile
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__localizedStringsFile));
      return num == IntPtr.Zero ? (TextAsset) null : Il2CppObjectPool.Get<TextAsset>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__localizedStringsFile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, string> _dictionary
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__dictionary));
      return num == IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__dictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProvider.NativeFieldInfoPtr__initialized)) = value;
    }
  }
}
