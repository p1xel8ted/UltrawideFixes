// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyText
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyText(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_TextChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_mUnresolvedText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArguments;
  private static readonly System.IntPtr NativeFieldInfoPtr_mContextObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRegistredVariableListeners;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRegistredObjectPropertyListeners;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRegistredTypePropertyListeners;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromProperty_Public_Static_ArticyText_Expression_1_Func_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Unresolved_Text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ContextObject_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ContextObject_Public_set_Void_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Arguments_Public_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Arguments_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTextFromProperty_Public_Void_Expression_1_Func_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshResolvedText_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnVariableChanged_Private_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPropertyChanged_Private_Void_ArticyChangedProperty_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddPropToRegistredObjectsCache_Private_Void_Dictionary_2_TKey_HashSet_1_String_TKey_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PropertyToText_Private_Static_String_Expression_1_Func_1_T_0;

  static ArticyText()
  {
    Il2CppClassPointerStore<ArticyText>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyText>.NativeClassPtr);
    ArticyText.NativeFieldInfoPtr_TextChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (TextChanged));
    ArticyText.NativeFieldInfoPtr_mUnresolvedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mUnresolvedText));
    ArticyText.NativeFieldInfoPtr_mArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mArguments));
    ArticyText.NativeFieldInfoPtr_mContextObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mContextObject));
    ArticyText.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mText));
    ArticyText.NativeFieldInfoPtr_mRegistredVariableListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mRegistredVariableListeners));
    ArticyText.NativeFieldInfoPtr_mRegistredObjectPropertyListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mRegistredObjectPropertyListeners));
    ArticyText.NativeFieldInfoPtr_mRegistredTypePropertyListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, nameof (mRegistredTypePropertyListeners));
    ArticyText.NativeMethodInfoPtr_FromProperty_Public_Static_ArticyText_Expression_1_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663862);
    ArticyText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663863);
    ArticyText.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663864);
    ArticyText.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663865);
    ArticyText.NativeMethodInfoPtr_get_Unresolved_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663866);
    ArticyText.NativeMethodInfoPtr_get_ContextObject_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663867);
    ArticyText.NativeMethodInfoPtr_set_ContextObject_Public_set_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663868);
    ArticyText.NativeMethodInfoPtr_get_Arguments_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663869);
    ArticyText.NativeMethodInfoPtr_set_Arguments_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663870);
    ArticyText.NativeMethodInfoPtr_SetTextFromProperty_Public_Void_Expression_1_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663871);
    ArticyText.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663872 /*0x06000240*/);
    ArticyText.NativeMethodInfoPtr_RefreshResolvedText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663873);
    ArticyText.NativeMethodInfoPtr_OnVariableChanged_Private_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663874);
    ArticyText.NativeMethodInfoPtr_OnPropertyChanged_Private_Void_ArticyChangedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663875);
    ArticyText.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663876);
    ArticyText.NativeMethodInfoPtr_AddPropToRegistredObjectsCache_Private_Void_Dictionary_2_TKey_HashSet_1_String_TKey_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663877);
    ArticyText.NativeMethodInfoPtr_PropertyToText_Private_Static_String_Expression_1_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyText>.NativeClassPtr, 100663878);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991414, XrefRangeEnd = 991416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyText FromProperty<T>(Expression<Il2CppSystem.Func<T>> aProperty)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.MethodInfoStoreGeneric_FromProperty_Public_Static_ArticyText_Expression_1_Func_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyText) null : Il2CppObjectPool.Get<ArticyText>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991416, XrefRangeEnd = 991441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyText>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string Text
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 991442, RefRangeEnd = 991443, XrefRangeStart = 991441, XrefRangeEnd = 991442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Unresolved_Text
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_get_Unresolved_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ArticyRef ContextObject
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_get_ContextObject_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_set_ContextObject_Public_set_Void_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray Arguments
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_get_Arguments_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_set_Arguments_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991443, XrefRangeEnd = 991445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTextFromProperty<T>(Expression<Il2CppSystem.Func<T>> aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aProperty)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.MethodInfoStoreGeneric_SetTextFromProperty_Public_Void_Expression_1_Func_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 991595, RefRangeEnd = 991596, XrefRangeStart = 991445, XrefRangeEnd = 991595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 991891, RefRangeEnd = 991897, XrefRangeStart = 991596, XrefRangeEnd = 991891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshResolvedText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_RefreshResolvedText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991897, XrefRangeEnd = 991898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnVariableChanged(string aVariable, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_OnVariableChanged_Private_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnPropertyChanged(ArticyChangedProperty aChangedProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) aChangedProperty))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_OnPropertyChanged_Private_Void_ArticyChangedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnLanguageChanged(ArticyLanguage aOldLanguage, ArticyLanguage aNewLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewLanguage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 991910, RefRangeEnd = 991912, XrefRangeStart = 991898, XrefRangeEnd = 991910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddPropToRegistredObjectsCache<TKey>(
    Dictionary<TKey, HashSet<string>> mCache,
    TKey aKey,
    string aProp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mCache);
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    TKey& local1;
    if (!typeof (TKey).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TKey> local2 = (object) aKey;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TKey&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TKey&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref aKey;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aProp);
    System.IntPtr num2;
    IL2CPP.il2cpp_runtime_invoke(ArticyText.MethodInfoStoreGeneric_AddPropToRegistredObjectsCache_Private_Void_Dictionary_2_TKey_HashSet_1_String_TKey_String_0<TKey>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991912, XrefRangeEnd = 991978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string PropertyToText<T>(Expression<Il2CppSystem.Func<T>> aProperty)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyText.MethodInfoStoreGeneric_PropertyToText_Private_Static_String_Expression_1_Func_1_T_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe ArticyTextChangedEvent TextChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_TextChanged));
      return num == System.IntPtr.Zero ? (ArticyTextChangedEvent) null : Il2CppObjectPool.Get<ArticyTextChangedEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_TextChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mUnresolvedText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mUnresolvedText)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mUnresolvedText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStringArray mArguments
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mArguments));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mArguments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef mContextObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mContextObject));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mContextObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mText)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe List<string> mRegistredVariableListeners
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredVariableListeners));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredVariableListeners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, HashSet<string>> mRegistredObjectPropertyListeners
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredObjectPropertyListeners));
      return num == System.IntPtr.Zero ? (Dictionary<string, HashSet<string>>) null : Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredObjectPropertyListeners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ArticyType, HashSet<string>> mRegistredTypePropertyListeners
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredTypePropertyListeners));
      return num == System.IntPtr.Zero ? (Dictionary<ArticyType, HashSet<string>>) null : Il2CppObjectPool.Get<Dictionary<ArticyType, HashSet<string>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyText.NativeFieldInfoPtr_mRegistredTypePropertyListeners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_FromProperty_Public_Static_ArticyText_Expression_1_Func_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyText.NativeMethodInfoPtr_FromProperty_Public_Static_ArticyText_Expression_1_Func_1_T_0, Il2CppClassPointerStore<ArticyText>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_SetTextFromProperty_Public_Void_Expression_1_Func_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyText.NativeMethodInfoPtr_SetTextFromProperty_Public_Void_Expression_1_Func_1_T_0, Il2CppClassPointerStore<ArticyText>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_AddPropToRegistredObjectsCache_Private_Void_Dictionary_2_TKey_HashSet_1_String_TKey_String_0<TKey>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyText.NativeMethodInfoPtr_AddPropToRegistredObjectsCache_Private_Void_Dictionary_2_TKey_HashSet_1_String_TKey_String_0, Il2CppClassPointerStore<ArticyText>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_PropertyToText_Private_Static_String_Expression_1_Func_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyText.NativeMethodInfoPtr_PropertyToText_Private_Static_String_Expression_1_Func_1_T_0, Il2CppClassPointerStore<ArticyText>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
