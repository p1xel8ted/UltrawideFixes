// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIPromptsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UIPromptsManager(System.IntPtr pointer) : LocalSingletonBehaviour<UIPromptsManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultPoolSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_root;
  private static readonly System.IntPtr NativeFieldInfoPtr_rootPostProcess;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialPrompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastPrompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastField;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPostProcessPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TutorialDialogueDisplayed_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowTutorialPrompt_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_ArticyRef_ArticyPromptField_byref_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryShowArticyPromptExclusively_Public_Boolean_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeAll_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__14_0_Private_Void_ResetToCheckpointEvent_0;

  static UIPromptsManager()
  {
    Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIPromptsManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr);
    UIPromptsManager.NativeFieldInfoPtr_defaultPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (defaultPoolSize));
    UIPromptsManager.NativeFieldInfoPtr_promptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (promptPrefab));
    UIPromptsManager.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (root));
    UIPromptsManager.NativeFieldInfoPtr_rootPostProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (rootPostProcess));
    UIPromptsManager.NativeFieldInfoPtr_tutorialPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (tutorialPrompt));
    UIPromptsManager.NativeFieldInfoPtr_lastPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (lastPrompt));
    UIPromptsManager.NativeFieldInfoPtr_lastField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (lastField));
    UIPromptsManager.NativeFieldInfoPtr_promptPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (promptPool));
    UIPromptsManager.NativeFieldInfoPtr_promptPostProcessPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (promptPostProcessPool));
    UIPromptsManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, nameof (eventDisposable));
    UIPromptsManager.NativeMethodInfoPtr_get_TutorialDialogueDisplayed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672206);
    UIPromptsManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672207);
    UIPromptsManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672208);
    UIPromptsManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672209);
    UIPromptsManager.NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672210);
    UIPromptsManager.NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672211);
    UIPromptsManager.NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672212);
    UIPromptsManager.NativeMethodInfoPtr_ShowTutorialPrompt_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672213);
    UIPromptsManager.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672214);
    UIPromptsManager.NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_ArticyRef_ArticyPromptField_byref_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672215);
    UIPromptsManager.NativeMethodInfoPtr_TryShowArticyPromptExclusively_Public_Boolean_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672216);
    UIPromptsManager.NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672217);
    UIPromptsManager.NativeMethodInfoPtr_FreeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672218);
    UIPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672219);
    UIPromptsManager.NativeMethodInfoPtr__Start_b__14_0_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr, 100672220);
  }

  public unsafe bool TutorialDialogueDisplayed
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 99244, RefRangeEnd = 99245, XrefRangeStart = 99241, XrefRangeEnd = 99244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_get_TutorialDialogueDisplayed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99245, XrefRangeEnd = 99272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPromptsManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99272, XrefRangeEnd = 99303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99303, XrefRangeEnd = 99318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPromptsManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99327, RefRangeEnd = 99328, XrefRangeStart = 99318, XrefRangeEnd = 99327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt GetPrompt(
    string text,
    Transform target,
    Vector3 offset,
    bool mash = false,
    bool postProcess = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &postProcess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 99343, RefRangeEnd = 99346, XrefRangeStart = 99328, XrefRangeEnd = 99343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt GetPromptOnScreen(
    string text,
    Vector2 anchoredPosition,
    bool postProcess = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &anchoredPosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &postProcess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99346, XrefRangeEnd = 99347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt ShowTextPrompt(string text, bool postProcess = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &postProcess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99348, RefRangeEnd = 99349, XrefRangeStart = 99347, XrefRangeEnd = 99348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask ShowTutorialPrompt(
    string text,
    Il2CppStringArray title,
    Il2CppReferenceArray<Sprite> images)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) images);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_ShowTutorialPrompt_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99349, XrefRangeEnd = 99354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LanguageChanged(ArticyLanguage aoldlanguage, ArticyLanguage anewlanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aoldlanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) anewlanguage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 99384, RefRangeEnd = 99388, XrefRangeStart = 99354, XrefRangeEnd = 99384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt ShowArticyPrompt(
    ArticyRef articyRef,
    UIPromptsManager.ArticyPromptField field,
    out string featureText,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> format)
  {
    if (format == null)
      format = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &field;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) format);
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_ArticyRef_ArticyPromptField_byref_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    featureText = IL2CPP.Il2CppStringToManaged(zero);
    System.IntPtr num4 = num3;
    return num4 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num4);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 99389, RefRangeEnd = 99392, XrefRangeStart = 99388, XrefRangeEnd = 99389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryShowArticyPromptExclusively(ArticyRef articyRef)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) articyRef)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_TryShowArticyPromptExclusively_Public_Boolean_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 99394, RefRangeEnd = 99395, XrefRangeStart = 99392, XrefRangeEnd = 99394, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreePrompt(UIButtonPrompt prompt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prompt)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 99397, RefRangeEnd = 99399, XrefRangeStart = 99395, XrefRangeEnd = 99397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr_FreeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99399, XrefRangeEnd = 99402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPromptsManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromptsManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 99397, RefRangeEnd = 99399, XrefRangeStart = 99397, XrefRangeEnd = 99399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__14_0(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManager.NativeMethodInfoPtr__Start_b__14_0_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public UIButtonPrompt ShowArticyPrompt(
    ArticyRef articyRef,
    UIPromptsManager.ArticyPromptField field,
    out string featureText,
    params Il2CppSystem.Object[] format)
  {
    return this.ShowArticyPrompt(articyRef, field, out featureText, new Il2CppReferenceArray<Il2CppSystem.Object>(format));
  }

  public unsafe int defaultPoolSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_defaultPoolSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_defaultPoolSize)) = value;
    }
  }

  public unsafe UIButtonPrompt promptPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPrefab));
      return num == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform root
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_root));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform rootPostProcess
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_rootPostProcess));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_rootPostProcess), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UITutorialDialogue tutorialPrompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_tutorialPrompt));
      return num == System.IntPtr.Zero ? (UITutorialDialogue) null : Il2CppObjectPool.Get<UITutorialDialogue>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_tutorialPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef lastPrompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_lastPrompt));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_lastPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIPromptsManager.ArticyPromptField lastField
  {
    get
    {
      return *(UIPromptsManager.ArticyPromptField*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_lastField));
    }
    [param: In] set
    {
      *(UIPromptsManager.ArticyPromptField*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_lastField)) = value;
    }
  }

  public unsafe ObjectPool promptPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool promptPostProcessPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPostProcessPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_promptPostProcessPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum ArticyPromptField
  {
    SmallText,
    Counter,
    Description,
  }
}
