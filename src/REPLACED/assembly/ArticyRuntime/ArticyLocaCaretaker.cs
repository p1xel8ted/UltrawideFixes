// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyLocaCaretaker
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyLocaCaretaker(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_targetComponent;
  private static readonly System.IntPtr NativeFieldInfoPtr_locaKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_parameters;
  private static readonly System.IntPtr NativeFieldInfoPtr_localizedTextAssignmentMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_AssignLocalizedTextMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocaKey_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocaKey_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateText_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DefaultAssignLocalizedString_Private_Static_Void_Component_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyLocaCaretaker()
  {
    Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyLocaCaretaker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr);
    ArticyLocaCaretaker.NativeFieldInfoPtr_targetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (targetComponent));
    ArticyLocaCaretaker.NativeFieldInfoPtr_locaKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (locaKey));
    ArticyLocaCaretaker.NativeFieldInfoPtr_parameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (parameters));
    ArticyLocaCaretaker.NativeFieldInfoPtr_localizedTextAssignmentMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (localizedTextAssignmentMethod));
    ArticyLocaCaretaker.NativeFieldInfoPtr_AssignLocalizedTextMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (AssignLocalizedTextMethod));
    ArticyLocaCaretaker.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, nameof (mText));
    ArticyLocaCaretaker.NativeMethodInfoPtr_get_LocaKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663493 /*0x060000C5*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_set_LocaKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663494 /*0x060000C6*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_get_Text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663495 /*0x060000C7*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663496 /*0x060000C8*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663497 /*0x060000C9*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663498 /*0x060000CA*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_UpdateText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663499 /*0x060000CB*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663500 /*0x060000CC*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr_DefaultAssignLocalizedString_Private_Static_Void_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663501 /*0x060000CD*/);
    ArticyLocaCaretaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr, 100663502 /*0x060000CE*/);
  }

  public unsafe string LocaKey
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_get_LocaKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 987566, RefRangeEnd = 987567, XrefRangeStart = 987565, XrefRangeEnd = 987566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_set_LocaKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Text
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_get_Text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987567, XrefRangeEnd = 987568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_set_Text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987568, XrefRangeEnd = 987590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987590, XrefRangeEnd = 987606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 987649, RefRangeEnd = 987653, XrefRangeStart = 987606, XrefRangeEnd = 987649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_UpdateText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987653, XrefRangeEnd = 987654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnLanguageChanged(ArticyLanguage aOldLanguage, ArticyLanguage aNewLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewLanguage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_OnLanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987654, XrefRangeEnd = 987668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DefaultAssignLocalizedString(
    Component aTargetComponent,
    string aLocalizedText)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetComponent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aLocalizedText);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr_DefaultAssignLocalizedString_Private_Static_Void_Component_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987668, XrefRangeEnd = 987675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyLocaCaretaker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyLocaCaretaker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyLocaCaretaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Component targetComponent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_targetComponent));
      return num == System.IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_targetComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string locaKey
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_locaKey)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_locaKey), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe List<string> parameters
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_parameters));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_parameters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LocalizedTextAssignMethod localizedTextAssignmentMethod
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_localizedTextAssignmentMethod));
      return num == System.IntPtr.Zero ? (LocalizedTextAssignMethod) null : Il2CppObjectPool.Get<LocalizedTextAssignMethod>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_localizedTextAssignmentMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<Component, string> AssignLocalizedTextMethod
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyLocaCaretaker.NativeFieldInfoPtr_AssignLocalizedTextMethod, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<Component, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<Component, string>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyLocaCaretaker.NativeFieldInfoPtr_AssignLocalizedTextMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_mText)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyLocaCaretaker.NativeFieldInfoPtr_mText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
