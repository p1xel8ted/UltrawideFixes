// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLocalizationManager
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyLocalizationManager(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr__Auxiliary_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__FallbackVOLanguage_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_languageChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_customTextLookup;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLocalizeObjectDefinitions;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLanguageId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLanguages;
  private static readonly System.IntPtr NativeFieldInfoPtr_mThrowOnMissingText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mClearOnLanguageSwitch;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLanguage;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLocalizedStrings;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLocalizedVOAssets;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalizationKeys_Public_get_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalizedStrings_Public_get_Dictionary_2_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalizedVOAssets_Public_get_Dictionary_2_String_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Language_Public_get_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Language_Internal_set_Void_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FallbackVOLanguage_Public_get_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FallbackVOLanguage_Private_set_Void_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Languages_Public_get_Il2CppReferenceArray_1_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Languages_Internal_set_Void_Il2CppReferenceArray_1_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ThrowOnMissingText_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ThrowOnMissingText_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClearOnLanguageSwitch_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClearOnLanguageSwitch_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetAsync_Public_Task_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguage_Public_Void_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguageAsync_Public_Task_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguageAsync_Public_Task_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetLanguageAsync_Public_Task_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Localize_Public_String_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeWithVO_Public_String_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryLocalize_Public_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryLocalizeWithVO_Public_Boolean_String_byref_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LocalizeInternal_Internal_Boolean_String_Boolean_byref_String_Boolean_byref_ArticyRef_Boolean_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalizeObjectDefintions_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalizeObjectDefintions_Internal_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAwaitingImport_Internal_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchLanguage_Private_Void_ArticyLanguage_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SwitchLanguageAsync_Private_Task_ArticyLanguage_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackageUnloaded_Internal_Void_UInt64_HashSet_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackageLoaded_Internal_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PackageLoadedAsync_Internal_Task_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyLocalizationPackage_ArticyLanguage_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__get_Language_b__12_0_Private_Boolean_ArticyLanguage_0;

  static ArticyLocalizationManager()
  {
    Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLocalizationManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr);
    ArticyLocalizationManager.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (Logger));
    ArticyLocalizationManager.NativeFieldInfoPtr__Auxiliary_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<Auxiliary>k__BackingField");
    ArticyLocalizationManager.NativeFieldInfoPtr__FallbackVOLanguage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<FallbackVOLanguage>k__BackingField");
    ArticyLocalizationManager.NativeFieldInfoPtr_languageChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (languageChanged));
    ArticyLocalizationManager.NativeFieldInfoPtr_customTextLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (customTextLookup));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizeObjectDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLocalizeObjectDefinitions));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLanguageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLanguageId));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLanguages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLanguages));
    ArticyLocalizationManager.NativeFieldInfoPtr_mThrowOnMissingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mThrowOnMissingText));
    ArticyLocalizationManager.NativeFieldInfoPtr_mClearOnLanguageSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mClearOnLanguageSwitch));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLanguage));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLocalizedStrings));
    ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedVOAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, nameof (mLocalizedVOAssets));
    ArticyLocalizationManager.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663523 /*0x060000E3*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663524 /*0x060000E4*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizationKeys_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663525 /*0x060000E5*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizedStrings_Public_get_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663526 /*0x060000E6*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizedVOAssets_Public_get_Dictionary_2_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663527 /*0x060000E7*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_Language_Public_get_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663528 /*0x060000E8*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_Language_Internal_set_Void_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663529 /*0x060000E9*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_FallbackVOLanguage_Public_get_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663530 /*0x060000EA*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_FallbackVOLanguage_Private_set_Void_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663531 /*0x060000EB*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_Languages_Public_get_Il2CppReferenceArray_1_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663532 /*0x060000EC*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_Languages_Internal_set_Void_Il2CppReferenceArray_1_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663533 /*0x060000ED*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_ThrowOnMissingText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663534 /*0x060000EE*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_ThrowOnMissingText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663535 /*0x060000EF*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_ClearOnLanguageSwitch_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663536 /*0x060000F0*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_ClearOnLanguageSwitch_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663537 /*0x060000F1*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663538 /*0x060000F2*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_ResetAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663539 /*0x060000F3*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663540 /*0x060000F4*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663541 /*0x060000F5*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663542 /*0x060000F6*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663543 /*0x060000F7*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663544 /*0x060000F8*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663545 /*0x060000F9*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663546 /*0x060000FA*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663547 /*0x060000FB*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663548 /*0x060000FC*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_Localize_Public_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663549 /*0x060000FD*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_LocalizeWithVO_Public_String_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663550 /*0x060000FE*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_TryLocalize_Public_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663551 /*0x060000FF*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_TryLocalizeWithVO_Public_Boolean_String_byref_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663552 /*0x06000100*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_LocalizeInternal_Internal_Boolean_String_Boolean_byref_String_Boolean_byref_ArticyRef_Boolean_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663553 /*0x06000101*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizeObjectDefintions_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663554 /*0x06000102*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_set_LocalizeObjectDefintions_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663555 /*0x06000103*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_get_IsAwaitingImport_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663556 /*0x06000104*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663557 /*0x06000105*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663558 /*0x06000106*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663559 /*0x06000107*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SwitchLanguage_Private_Void_ArticyLanguage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663560 /*0x06000108*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_SwitchLanguageAsync_Private_Task_ArticyLanguage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663561 /*0x06000109*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_PackageUnloaded_Internal_Void_UInt64_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663562 /*0x0600010A*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_PackageLoaded_Internal_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663563 /*0x0600010B*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_PackageLoadedAsync_Internal_Task_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663564 /*0x0600010C*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyLocalizationPackage_ArticyLanguage_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663565 /*0x0600010D*/);
    ArticyLocalizationManager.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663566 /*0x0600010E*/);
    ArticyLocalizationManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663567 /*0x0600010F*/);
    ArticyLocalizationManager.NativeMethodInfoPtr__get_Language_b__12_0_Private_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, 100663569);
  }

  public static unsafe ArticyEditorAuxiliary Auxiliary
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988033, XrefRangeEnd = 988037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_Auxiliary_Internal_Static_get_ArticyEditorAuxiliary_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988037, XrefRangeEnd = 988041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_Auxiliary_Internal_Static_set_Void_ArticyEditorAuxiliary_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<string> LocalizationKeys
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988041, XrefRangeEnd = 988048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizationKeys_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
    }
  }

  public unsafe Dictionary<string, string> LocalizedStrings
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizedStrings_Public_get_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num3);
    }
  }

  public unsafe Dictionary<string, ulong> LocalizedVOAssets
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizedVOAssets_Public_get_Dictionary_2_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, ulong>) null : Il2CppObjectPool.Get<Dictionary<string, ulong>>(num3);
    }
  }

  public unsafe ArticyLanguage Language
  {
    [CallerCount(26), CachedScanResults(RefRangeStart = 988057, RefRangeEnd = 988083, XrefRangeStart = 988048, XrefRangeEnd = 988057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_Language_Public_get_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 988095, RefRangeEnd = 988097, XrefRangeStart = 988083, XrefRangeEnd = 988095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_Language_Internal_set_Void_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyLanguage FallbackVOLanguage
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_FallbackVOLanguage_Public_get_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_FallbackVOLanguage_Private_set_Void_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ArticyLanguage> Languages
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_Languages_Public_get_Il2CppReferenceArray_1_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ArticyLanguage>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArticyLanguage>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988097, XrefRangeEnd = 988109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_Languages_Internal_set_Void_Il2CppReferenceArray_1_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool ThrowOnMissingText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_ThrowOnMissingText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_ThrowOnMissingText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool ClearOnLanguageSwitch
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_ClearOnLanguageSwitch_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_ClearOnLanguageSwitch_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 988118, RefRangeEnd = 988122, XrefRangeStart = 988109, XrefRangeEnd = 988118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988130, RefRangeEnd = 988132, XrefRangeStart = 988122, XrefRangeEnd = 988130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task ResetAsync()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_ResetAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988163, RefRangeEnd = 988165, XrefRangeStart = 988132, XrefRangeEnd = 988163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLanguage(string aCultureName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aCultureName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988165, XrefRangeEnd = 988195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLanguage(ushort aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988200, RefRangeEnd = 988202, XrefRangeStart = 988195, XrefRangeEnd = 988200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetLanguage(ArticyLanguage aLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguage_Public_Void_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988202, XrefRangeEnd = 988210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task SetLanguageAsync(string aCultureName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aCultureName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988210, XrefRangeEnd = 988218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task SetLanguageAsync(ushort aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988226, RefRangeEnd = 988228, XrefRangeStart = 988218, XrefRangeEnd = 988226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task SetLanguageAsync(ArticyLanguage aLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetLanguageAsync_Public_Task_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988228, XrefRangeEnd = 988266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFallbackVOLanguage(string aCultureName)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aCultureName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988266, XrefRangeEnd = 988296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFallbackVOLanguage(ushort aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988296, XrefRangeEnd = 988298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFallbackVOLanguage(ArticyLanguage aLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SetFallbackVOLanguage_Public_Void_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 988299, RefRangeEnd = 988303, XrefRangeStart = 988298, XrefRangeEnd = 988299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string Localize(string aKey, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_Localize_Public_String_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988303, XrefRangeEnd = 988304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string LocalizeWithVO(
    string aKey,
    out ArticyRef aVOAsset,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(aKey);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_LocalizeWithVO_Public_String_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ArticyRef local = ref aVOAsset;
    System.IntPtr pointer = zero;
    ArticyRef articyRef = pointer == System.IntPtr.Zero ? (ArticyRef) null : new ArticyRef(pointer);
    local = articyRef;
    return IL2CPP.Il2CppStringToManaged(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 988305, RefRangeEnd = 988310, XrefRangeStart = 988304, XrefRangeEnd = 988305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryLocalize(
    string aKey,
    out string aResult,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(aKey);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_TryLocalize_Public_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    aResult = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988310, XrefRangeEnd = 988314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryLocalizeWithVO(
    string aKey,
    out string aText,
    out ArticyRef aVOAsset,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(aKey);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_TryLocalizeWithVO_Public_Boolean_String_byref_String_byref_ArticyRef_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    aText = IL2CPP.Il2CppStringToManaged(zero1);
    ref ArticyRef local = ref aVOAsset;
    System.IntPtr pointer = zero2;
    ArticyRef articyRef = pointer == System.IntPtr.Zero ? (ArticyRef) null : new ArticyRef(pointer);
    local = articyRef;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 988347, RefRangeEnd = 988353, XrefRangeStart = 988314, XrefRangeEnd = 988347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool LocalizeInternal(
    string aKey,
    bool aLocalizeText,
    out string aText,
    bool aLocalizeVO,
    out ArticyRef aVO,
    bool aAllowThrowOnMissingText,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(aKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aLocalizeText;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aLocalizeVO;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &aAllowThrowOnMissingText;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_LocalizeInternal_Internal_Boolean_String_Boolean_byref_String_Boolean_byref_ArticyRef_Boolean_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    aText = IL2CPP.Il2CppStringToManaged(zero1);
    ref ArticyRef local = ref aVO;
    System.IntPtr pointer = zero2;
    ArticyRef articyRef = pointer == System.IntPtr.Zero ? (ArticyRef) null : new ArticyRef(pointer);
    local = articyRef;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  public unsafe bool LocalizeObjectDefintions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_LocalizeObjectDefintions_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988353, XrefRangeEnd = 988365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_set_LocalizeObjectDefintions_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsAwaitingImport
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 988372, RefRangeEnd = 988377, XrefRangeStart = 988365, XrefRangeEnd = 988372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_get_IsAwaitingImport_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 988472, RefRangeEnd = 988477, XrefRangeStart = 988377, XrefRangeEnd = 988472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchLanguage(ArticyLanguage aLanguage, bool aForceClear = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aForceClear;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SwitchLanguage_Private_Void_ArticyLanguage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988485, RefRangeEnd = 988487, XrefRangeStart = 988477, XrefRangeEnd = 988485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task SwitchLanguageAsync(ArticyLanguage aLanguage, bool aForceClear = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aForceClear;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_SwitchLanguageAsync_Private_Task_ArticyLanguage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 988559, RefRangeEnd = 988560, XrefRangeStart = 988487, XrefRangeEnd = 988559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PackageUnloaded(ulong aPackageId, HashSet<string> aObjectsToKeep)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &aPackageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObjectsToKeep);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_PackageUnloaded_Internal_Void_UInt64_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988560, XrefRangeEnd = 988601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PackageLoaded(ulong aPackageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aPackageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_PackageLoaded_Internal_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988601, XrefRangeEnd = 988609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task PackageLoadedAsync(ulong aPackageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aPackageId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_PackageLoadedAsync_Internal_Task_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task) null : Il2CppObjectPool.Get<Task>(num3);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 988647, RefRangeEnd = 988659, XrefRangeStart = 988609, XrefRangeEnd = 988647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessDataFromPackage(
    ArticyLocalizationPackage aPackage,
    ArticyLanguage aLanguage,
    bool aOnlyVO = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPackage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aOnlyVO;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_ProcessDataFromPackage_Private_Void_ArticyLocalizationPackage_ArticyLanguage_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988659, XrefRangeEnd = 988666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988666, XrefRangeEnd = 988679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLocalizationManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe bool _get_Language_b__12_0(ArticyLanguage entry)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entry)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.NativeMethodInfoPtr__get_Language_b__12_0_Private_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public string Localize(string aKey, params Il2CppSystem.Object[] aParams)
  {
    return this.Localize(aKey, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public string LocalizeWithVO(string aKey, out ArticyRef aVOAsset, params Il2CppSystem.Object[] aParams)
  {
    return this.LocalizeWithVO(aKey, out aVOAsset, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public bool TryLocalize(string aKey, out string aResult, params Il2CppSystem.Object[] aParams)
  {
    return this.TryLocalize(aKey, out aResult, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public bool TryLocalizeWithVO(
    string aKey,
    out string aText,
    out ArticyRef aVOAsset,
    params Il2CppSystem.Object[] aParams)
  {
    return this.TryLocalizeWithVO(aKey, out aText, out aVOAsset, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public bool LocalizeInternal(
    string aKey,
    bool aLocalizeText,
    out string aText,
    bool aLocalizeVO,
    out ArticyRef aVO,
    bool aAllowThrowOnMissingText,
    params Il2CppSystem.Object[] aParams)
  {
    return this.LocalizeInternal(aKey, aLocalizeText, out aText, aLocalizeVO, out aVO, aAllowThrowOnMissingText, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLocalizationManager.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLocalizationManager.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ArticyEditorAuxiliary _Auxiliary_k__BackingField
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLocalizationManager.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyEditorAuxiliary) null : Il2CppObjectPool.Get<ArticyEditorAuxiliary>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLocalizationManager.NativeFieldInfoPtr__Auxiliary_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyLanguage _FallbackVOLanguage_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr__FallbackVOLanguage_k__BackingField));
      return num == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr__FallbackVOLanguage_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LanguageChangedEvent languageChanged
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_languageChanged));
      return num == System.IntPtr.Zero ? (LanguageChangedEvent) null : Il2CppObjectPool.Get<LanguageChangedEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_languageChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CustomTextLookup customTextLookup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_customTextLookup));
      return num == System.IntPtr.Zero ? (CustomTextLookup) null : Il2CppObjectPool.Get<CustomTextLookup>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_customTextLookup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mLocalizeObjectDefinitions
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizeObjectDefinitions));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizeObjectDefinitions)) = value;
    }
  }

  public unsafe ushort mLanguageId
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguageId));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguageId)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<ArticyLanguage> mLanguages
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguages));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArticyLanguage>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArticyLanguage>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mThrowOnMissingText
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mThrowOnMissingText));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mThrowOnMissingText)) = value;
    }
  }

  public unsafe bool mClearOnLanguageSwitch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mClearOnLanguageSwitch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mClearOnLanguageSwitch)) = value;
    }
  }

  public unsafe ArticyLanguage mLanguage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguage));
      return num == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLanguage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, string> mLocalizedStrings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedStrings));
      return num == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, ulong> mLocalizedVOAssets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedVOAssets));
      return num == System.IntPtr.Zero ? (Dictionary<string, ulong>) null : Il2CppObjectPool.Get<Dictionary<string, ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.NativeFieldInfoPtr_mLocalizedVOAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass31_0")]
  public sealed class __c__DisplayClass31_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aCultureName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass31_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass31_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass31_0.NativeFieldInfoPtr_aCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr, nameof (aCultureName));
      ArticyLocalizationManager.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr, 100663570);
      ArticyLocalizationManager.__c__DisplayClass31_0.NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr, 100663571);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass31_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass31_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetLanguage_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass31_0.NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe string aCultureName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass31_0.NativeFieldInfoPtr_aCultureName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass31_0.NativeFieldInfoPtr_aCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass32_0")]
  public sealed class __c__DisplayClass32_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass32_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass32_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass32_0.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr, nameof (aId));
      ArticyLocalizationManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr, 100663572);
      ArticyLocalizationManager.__c__DisplayClass32_0.NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr, 100663573);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass32_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass32_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _SetLanguage_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass32_0.NativeMethodInfoPtr__SetLanguage_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ushort aId
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass32_0.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass32_0.NativeFieldInfoPtr_aId)) = value;
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass34_0")]
  public sealed class __c__DisplayClass34_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aCultureName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass34_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass34_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_aCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, nameof (aCultureName));
      ArticyLocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, 100663574);
      ArticyLocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr, 100663575);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass34_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass34_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetLanguageAsync_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass34_0.NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe string aCultureName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_aCultureName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass34_0.NativeFieldInfoPtr_aCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass35_0")]
  public sealed class __c__DisplayClass35_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass35_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass35_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass35_0.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr, nameof (aId));
      ArticyLocalizationManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr, 100663576);
      ArticyLocalizationManager.__c__DisplayClass35_0.NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr, 100663577);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass35_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass35_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _SetLanguageAsync_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass35_0.NativeMethodInfoPtr__SetLanguageAsync_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ushort aId
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass35_0.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass35_0.NativeFieldInfoPtr_aId)) = value;
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass37_0")]
  public sealed class __c__DisplayClass37_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aCultureName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass37_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass37_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass37_0.NativeFieldInfoPtr_aCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr, nameof (aCultureName));
      ArticyLocalizationManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr, 100663578);
      ArticyLocalizationManager.__c__DisplayClass37_0.NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr, 100663579);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass37_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass37_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _SetFallbackVOLanguage_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass37_0.NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe string aCultureName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass37_0.NativeFieldInfoPtr_aCultureName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass37_0.NativeFieldInfoPtr_aCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<>c__DisplayClass38_0")]
  public sealed class __c__DisplayClass38_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0;

    static __c__DisplayClass38_0()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<>c__DisplayClass38_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr);
      ArticyLocalizationManager.__c__DisplayClass38_0.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr, nameof (aId));
      ArticyLocalizationManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr, 100663580);
      ArticyLocalizationManager.__c__DisplayClass38_0.NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr, 100663581);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass38_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager.__c__DisplayClass38_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass38_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _SetFallbackVOLanguage_b__0(ArticyLanguage x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager.__c__DisplayClass38_0.NativeMethodInfoPtr__SetFallbackVOLanguage_b__0_Internal_Boolean_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ushort aId
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass38_0.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager.__c__DisplayClass38_0.NativeFieldInfoPtr_aId)) = value;
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<PackageLoadedAsync>d__57")]
  public sealed class _PackageLoadedAsync_d__57 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_aPackageId;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadPackageResult_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _PackageLoadedAsync_d__57()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<PackageLoadedAsync>d__57");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr);
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr_aPackageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, nameof (aPackageId));
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr__loadPackageResult_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, "<loadPackageResult>5__2");
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, 100663582);
      ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr, 100663583);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987676, XrefRangeEnd = 987740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987740, XrefRangeEnd = 987744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _PackageLoadedAsync_d__57(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _PackageLoadedAsync_d__57()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._PackageLoadedAsync_d__57>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ulong aPackageId
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr_aPackageId));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr_aPackageId)) = value;
      }
    }

    public Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object> _loadPackageResult_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr__loadPackageResult_5__2);
        return new Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr__loadPackageResult_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._PackageLoadedAsync_d__57.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<ResetAsync>d__30")]
  public sealed class _ResetAsync_d__30 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _ResetAsync_d__30()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<ResetAsync>d__30");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr);
      ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._ResetAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, 100663584 /*0x06000120*/);
      ArticyLocalizationManager._ResetAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr, 100663585);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987744, XrefRangeEnd = 987762, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._ResetAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987762, XrefRangeEnd = 987766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._ResetAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _ResetAsync_d__30(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _ResetAsync_d__30()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._ResetAsync_d__30>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._ResetAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<SetLanguageAsync>d__34")]
  public sealed class _SetLanguageAsync_d__34 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aCultureName;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SetLanguageAsync_d__34()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<SetLanguageAsync>d__34");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr);
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr_aCultureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, nameof (aCultureName));
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, 100663586);
      ArticyLocalizationManager._SetLanguageAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr, 100663587);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987766, XrefRangeEnd = 987808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987808, XrefRangeEnd = 987812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SetLanguageAsync_d__34(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetLanguageAsync_d__34()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__34>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe string aCultureName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr_aCultureName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr_aCultureName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<SetLanguageAsync>d__35")]
  public sealed class _SetLanguageAsync_d__35 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_aId;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SetLanguageAsync_d__35()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<SetLanguageAsync>d__35");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr);
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr_aId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, nameof (aId));
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, 100663588);
      ArticyLocalizationManager._SetLanguageAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr, 100663589);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987812, XrefRangeEnd = 987853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987853, XrefRangeEnd = 987857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SetLanguageAsync_d__35(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetLanguageAsync_d__35()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__35>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ushort aId
    {
      get
      {
        return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr_aId));
      }
      [param: In] set
      {
        *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr_aId)) = value;
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__35.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<SetLanguageAsync>d__36")]
  public sealed class _SetLanguageAsync_d__36 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_aLanguage;
    private static readonly System.IntPtr NativeFieldInfoPtr__old_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SetLanguageAsync_d__36()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<SetLanguageAsync>d__36");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr);
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr_aLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, nameof (aLanguage));
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr__old_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, "<old>5__2");
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, 100663590);
      ArticyLocalizationManager._SetLanguageAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr, 100663591);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987857, XrefRangeEnd = 987871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987871, XrefRangeEnd = 987875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SetLanguageAsync_d__36(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SetLanguageAsync_d__36()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._SetLanguageAsync_d__36>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyLanguage aLanguage
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr_aLanguage));
        return num == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr_aLanguage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyLanguage _old_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr__old_5__2));
        return num == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr__old_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SetLanguageAsync_d__36.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyLocalizationManager+<SwitchLanguageAsync>d__54")]
  public sealed class _SwitchLanguageAsync_d__54 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_aForceClear;
    private static readonly System.IntPtr NativeFieldInfoPtr_aLanguage;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadObjDefPackageResult_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr__package_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__loadPackageResult_5__5;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _SwitchLanguageAsync_d__54()
    {
      Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyLocalizationManager>.NativeClassPtr, "<SwitchLanguageAsync>d__54");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr);
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<>1__state");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<>t__builder");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<>4__this");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aForceClear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, nameof (aForceClear));
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, nameof (aLanguage));
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadObjDefPackageResult_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<loadObjDefPackageResult>5__2");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<>u__1");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<>7__wrap2");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__package_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<package>5__4");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadPackageResult_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, "<loadPackageResult>5__5");
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, 100663592);
      ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr, 100663593);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987875, XrefRangeEnd = 988029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988029, XrefRangeEnd = 988033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _SwitchLanguageAsync_d__54(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _SwitchLanguageAsync_d__54()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocalizationManager._SwitchLanguageAsync_d__54>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyLocalizationManager __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyLocalizationManager) null : Il2CppObjectPool.Get<ArticyLocalizationManager>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool aForceClear
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aForceClear));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aForceClear)) = value;
      }
    }

    public unsafe ArticyLanguage aLanguage
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aLanguage));
        return num == System.IntPtr.Zero ? (ArticyLanguage) null : Il2CppObjectPool.Get<ArticyLanguage>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr_aLanguage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object> _loadObjDefPackageResult_5__2
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadObjDefPackageResult_5__2);
        return new Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadObjDefPackageResult_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe IEnumerator<ArticyPackage> __7__wrap2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___7__wrap2));
        return num == System.IntPtr.Zero ? (IEnumerator<ArticyPackage>) null : Il2CppObjectPool.Get<IEnumerator<ArticyPackage>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyPackage _package_5__4
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__package_5__4));
        return num == System.IntPtr.Zero ? (ArticyPackage) null : Il2CppObjectPool.Get<ArticyPackage>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__package_5__4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object> _loadPackageResult_5__5
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadPackageResult_5__5);
        return new Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocalizationManager._SwitchLanguageAsync_d__54.NativeFieldInfoPtr__loadPackageResult_5__5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<ArticyLocalizationPackage, Il2CppSystem.Object>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
