// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIHorizontalSelect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIHorizontalSelect(IntPtr pointer) : Selectable(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_labelText;
  private static readonly IntPtr NativeFieldInfoPtr_leftArrow;
  private static readonly IntPtr NativeFieldInfoPtr_rightArrow;
  private static readonly IntPtr NativeFieldInfoPtr_disabledColor;
  private static readonly IntPtr NativeFieldInfoPtr_options;
  private static readonly IntPtr NativeFieldInfoPtr_optionTranslations;
  private static readonly IntPtr NativeFieldInfoPtr_onValueChanged;
  private static readonly IntPtr NativeFieldInfoPtr_normalColor;
  private static readonly IntPtr NativeFieldInfoPtr_selected;
  private static readonly IntPtr NativeFieldInfoPtr_raycaster;
  private static readonly IntPtr NativeFieldInfoPtr_raycastResults;
  private static readonly IntPtr NativeFieldInfoPtr_UseDisplayNameForTranslation;
  private static readonly IntPtr NativeMethodInfoPtr_get_Selected_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearOptions_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddTranslations_Public_Void_List_1_ArticyRef_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddOption_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateText_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveValue_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIHorizontalSelect()
  {
    Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIHorizontalSelect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr);
    UIHorizontalSelect.NativeFieldInfoPtr_labelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (labelText));
    UIHorizontalSelect.NativeFieldInfoPtr_leftArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (leftArrow));
    UIHorizontalSelect.NativeFieldInfoPtr_rightArrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (rightArrow));
    UIHorizontalSelect.NativeFieldInfoPtr_disabledColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (disabledColor));
    UIHorizontalSelect.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (options));
    UIHorizontalSelect.NativeFieldInfoPtr_optionTranslations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (optionTranslations));
    UIHorizontalSelect.NativeFieldInfoPtr_onValueChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (onValueChanged));
    UIHorizontalSelect.NativeFieldInfoPtr_normalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (normalColor));
    UIHorizontalSelect.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (selected));
    UIHorizontalSelect.NativeFieldInfoPtr_raycaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (raycaster));
    UIHorizontalSelect.NativeFieldInfoPtr_raycastResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (raycastResults));
    UIHorizontalSelect.NativeFieldInfoPtr_UseDisplayNameForTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, nameof (UseDisplayNameForTranslation));
    UIHorizontalSelect.NativeMethodInfoPtr_get_Selected_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672328);
    UIHorizontalSelect.NativeMethodInfoPtr_ClearOptions_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672329);
    UIHorizontalSelect.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672330);
    UIHorizontalSelect.NativeMethodInfoPtr_AddTranslations_Public_Void_List_1_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672331);
    UIHorizontalSelect.NativeMethodInfoPtr_AddOption_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672332);
    UIHorizontalSelect.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672333);
    UIHorizontalSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672334);
    UIHorizontalSelect.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672335);
    UIHorizontalSelect.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672336);
    UIHorizontalSelect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672337);
    UIHorizontalSelect.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672338);
    UIHorizontalSelect.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672339);
    UIHorizontalSelect.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672340);
    UIHorizontalSelect.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672341);
    UIHorizontalSelect.NativeMethodInfoPtr_UpdateText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672342);
    UIHorizontalSelect.NativeMethodInfoPtr_MoveValue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672343);
    UIHorizontalSelect.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672344);
    UIHorizontalSelect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr, 100672345);
  }

  public unsafe int Selected
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_get_Selected_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100602, XrefRangeEnd = 100604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearOptions()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_ClearOptions_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100604, XrefRangeEnd = 100608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddOptions(List<string> newOpt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newOpt)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_AddOptions_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100608, XrefRangeEnd = 100612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTranslations(List<ArticyRef> newOpt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newOpt)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_AddTranslations_Public_Void_List_1_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100612, XrefRangeEnd = 100615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddOption(string newOpt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(newOpt)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_AddOption_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100615, XrefRangeEnd = 100616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValueWithoutNotify(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &i
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100616, XrefRangeEnd = 100617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100617, XrefRangeEnd = 100618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100618, XrefRangeEnd = 100652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerDown(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100652, XrefRangeEnd = 100653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100653, XrefRangeEnd = 100654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100654, XrefRangeEnd = 100672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100672, XrefRangeEnd = 100684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100684, XrefRangeEnd = 100685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LanguageChanged(ArticyLanguage old, ArticyLanguage n)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) old);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) n);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 100705, RefRangeEnd = 100721, XrefRangeStart = 100685, XrefRangeEnd = 100705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_UpdateText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 100729, RefRangeEnd = 100731, XrefRangeStart = 100721, XrefRangeEnd = 100729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveValue(bool forward)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &forward
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr_MoveValue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100731, XrefRangeEnd = 100742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnMove(AxisEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIHorizontalSelect.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100742, XrefRangeEnd = 100746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIHorizontalSelect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIHorizontalSelect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIHorizontalSelect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text labelText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_labelText));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_labelText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text leftArrow
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_leftArrow));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_leftArrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text rightArrow
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_rightArrow));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_rightArrow), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color disabledColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_disabledColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_disabledColor)) = value;
    }
  }

  public unsafe List<string> options
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_options));
      return num == IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyRef> optionTranslations
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_optionTranslations));
      return num == IntPtr.Zero ? (List<ArticyRef>) null : Il2CppObjectPool.Get<List<ArticyRef>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_optionTranslations), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent<int> onValueChanged
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_onValueChanged));
      return num == IntPtr.Zero ? (UnityEvent<int>) null : Il2CppObjectPool.Get<UnityEvent<int>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_onValueChanged), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color normalColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_normalColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_normalColor)) = value;
    }
  }

  public unsafe int selected
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_selected));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_selected)) = value;
    }
  }

  public unsafe GraphicRaycaster raycaster
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_raycaster));
      return num == IntPtr.Zero ? (GraphicRaycaster) null : Il2CppObjectPool.Get<GraphicRaycaster>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_raycaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<RaycastResult> raycastResults
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_raycastResults));
      return num == IntPtr.Zero ? (List<RaycastResult>) null : Il2CppObjectPool.Get<List<RaycastResult>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_raycastResults), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool UseDisplayNameForTranslation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_UseDisplayNameForTranslation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIHorizontalSelect.NativeFieldInfoPtr_UseDisplayNameForTranslation)) = value;
    }
  }
}
