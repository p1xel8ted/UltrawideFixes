// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLanguage
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyLanguage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyLanguageId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCultureName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLanguageName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsVoiceOver;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyLanguageId_Public_get_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyLanguageId_Internal_set_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CultureName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LanguageName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LanguageName_Internal_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVoiceOver_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsVoiceOver_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt16_String_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArticyLanguage_0;

  static ArticyLanguage()
  {
    Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLanguage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr);
    ArticyLanguage.NativeFieldInfoPtr_mArticyLanguageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, nameof (mArticyLanguageId));
    ArticyLanguage.NativeFieldInfoPtr_mCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, nameof (mCultureName));
    ArticyLanguage.NativeFieldInfoPtr_mLanguageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, nameof (mLanguageName));
    ArticyLanguage.NativeFieldInfoPtr_mIsVoiceOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, nameof (mIsVoiceOver));
    ArticyLanguage.NativeMethodInfoPtr_get_ArticyLanguageId_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663503 /*0x060000CF*/);
    ArticyLanguage.NativeMethodInfoPtr_set_ArticyLanguageId_Internal_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663504 /*0x060000D0*/);
    ArticyLanguage.NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663505 /*0x060000D1*/);
    ArticyLanguage.NativeMethodInfoPtr_set_CultureName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663506 /*0x060000D2*/);
    ArticyLanguage.NativeMethodInfoPtr_get_LanguageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663507 /*0x060000D3*/);
    ArticyLanguage.NativeMethodInfoPtr_set_LanguageName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663508 /*0x060000D4*/);
    ArticyLanguage.NativeMethodInfoPtr_get_IsVoiceOver_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663509 /*0x060000D5*/);
    ArticyLanguage.NativeMethodInfoPtr_set_IsVoiceOver_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663510 /*0x060000D6*/);
    ArticyLanguage.NativeMethodInfoPtr__ctor_Public_Void_UInt16_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663511 /*0x060000D7*/);
    ArticyLanguage.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663512 /*0x060000D8*/);
    ArticyLanguage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663513 /*0x060000D9*/);
    ArticyLanguage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr, 100663514 /*0x060000DA*/);
  }

  public unsafe ushort ArticyLanguageId
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 387216, RefRangeEnd = 387218, XrefRangeStart = 387216, XrefRangeEnd = 387218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_get_ArticyLanguageId_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_set_ArticyLanguageId_Internal_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CultureName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_set_CultureName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LanguageName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_get_LanguageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_set_LanguageName_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsVoiceOver
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_get_IsVoiceOver_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_set_IsVoiceOver_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987675, XrefRangeEnd = 987676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLanguage(
    ushort articyLanguageId,
    string cultureName,
    string languageName,
    bool isVoiceOver)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLanguage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &articyLanguageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(cultureName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(languageName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isVoiceOver;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr__ctor_Public_Void_UInt16_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(47)]
  [CachedScanResults(RefRangeStart = 22365, RefRangeEnd = 22412, XrefRangeStart = 22365, XrefRangeEnd = 22412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator string(ArticyLanguage aArticyLanguage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aArticyLanguage)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ArticyLanguage_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(47)]
  [CachedScanResults(RefRangeStart = 22365, RefRangeEnd = 22412, XrefRangeStart = 22365, XrefRangeEnd = 22412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyLanguage.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(ArticyLanguage aOther)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLanguage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe ushort mArticyLanguageId
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mArticyLanguageId));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mArticyLanguageId)) = value;
    }
  }

  public unsafe string mCultureName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mCultureName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mLanguageName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mLanguageName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mLanguageName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mIsVoiceOver
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mIsVoiceOver));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLanguage.NativeFieldInfoPtr_mIsVoiceOver)) = value;
    }
  }
}
