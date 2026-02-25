// Decompiled with JetBrains decompiler
// Type: UnityEngine.TouchScreenKeyboard
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class TouchScreenKeyboard(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInPlaceEditingAllowed_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inputFieldAppearance_Public_Static_get_InputFieldAppearance_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_status_Public_get_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Injected_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_active_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_active_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_status_Injected_Private_Static_Status_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_characterLimit_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canGetSelection_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_canSetSelection_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly TouchScreenKeyboard.get_hideInputDelegate get_hideInputDelegateField;
  private static readonly TouchScreenKeyboard.GetDoneDelegate GetDoneDelegateField;
  private static readonly TouchScreenKeyboard.GetWasCanceledDelegate GetWasCanceledDelegateField;
  private static readonly TouchScreenKeyboard.get_visibleDelegate get_visibleDelegateField;
  private static readonly TouchScreenKeyboard.get_characterLimit_InjectedDelegate get_characterLimit_InjectedDelegateField;
  private static readonly TouchScreenKeyboard.get_type_InjectedDelegate get_type_InjectedDelegateField;
  private static readonly TouchScreenKeyboard.get_area_InjectedDelegate get_area_InjectedDelegateField;

  static TouchScreenKeyboard()
  {
    Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TouchScreenKeyboard));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr);
    TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, nameof (m_Ptr));
    TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, "<disableInPlaceEditing>k__BackingField");
    TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668604);
    TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668605);
    TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668606);
    TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668607);
    TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668608);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668609);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668610);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668611);
    TouchScreenKeyboard.NativeMethodInfoPtr_IsInPlaceEditingAllowed_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668612);
    TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668613);
    TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668614);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668615);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668616);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668617);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_inputFieldAppearance_Public_Static_get_InputFieldAppearance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668618);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668619);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668620);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668621);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668622);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668623);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668624);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668625);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668626);
    TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668627);
    TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668628);
    TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Injected_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668629);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668630);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668631);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668632);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668633);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Injected_Private_Static_Status_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668634);
    TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668635);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668636);
    TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, 100668637);
    TouchScreenKeyboard.get_hideInputDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_hideInputDelegate>("UnityEngine.TouchScreenKeyboard::get_hideInput");
    TouchScreenKeyboard.GetDoneDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetDoneDelegate>("UnityEngine.TouchScreenKeyboard::GetDone");
    TouchScreenKeyboard.GetWasCanceledDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.GetWasCanceledDelegate>("UnityEngine.TouchScreenKeyboard::GetWasCanceled");
    TouchScreenKeyboard.get_visibleDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_visibleDelegate>("UnityEngine.TouchScreenKeyboard::get_visible");
    TouchScreenKeyboard.get_characterLimit_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_characterLimit_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_characterLimit_Injected");
    TouchScreenKeyboard.get_type_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_type_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_type_Injected");
    TouchScreenKeyboard.get_area_InjectedDelegateField = IL2CPP.ResolveICall<TouchScreenKeyboard.get_area_InjectedDelegate>("UnityEngine.TouchScreenKeyboard::get_area_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465955, XrefRangeEnd = 465957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_Destroy(System.IntPtr ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465957, XrefRangeEnd = 465963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465963, XrefRangeEnd = 465972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TouchScreenKeyboard.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 465972, XrefRangeEnd = 465985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TouchScreenKeyboard(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline,
    bool secure,
    bool alert,
    string textPlaceholder,
    int characterLimit)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keyboardType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &autocorrection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &multiline;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &secure;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &alert;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &characterLimit;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr__ctor_Public_Void_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 466008, RefRangeEnd = 466011, XrefRangeStart = 465985, XrefRangeEnd = 466008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr TouchScreenKeyboard_InternalConstructorHelper(
    ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments,
    string text,
    string textPlaceholder)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref arguments;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe bool isSupported
  {
    [CallerCount(18), CachedScanResults(RefRangeStart = 466017, RefRangeEnd = 466035, XrefRangeStart = 466011, XrefRangeEnd = 466017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isSupported_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool disableInPlaceEditing
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466035, XrefRangeEnd = 466037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_disableInPlaceEditing_Internal_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => TouchScreenKeyboard._disableInPlaceEditing_k__BackingField = value;
  }

  public static unsafe bool isInPlaceEditingAllowed
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 466041, RefRangeEnd = 466052, XrefRangeStart = 466037, XrefRangeEnd = 466041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_isInPlaceEditingAllowed_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466052, XrefRangeEnd = 466054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsInPlaceEditingAllowed()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_IsInPlaceEditingAllowed_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 466070, RefRangeEnd = 466072, XrefRangeStart = 466054, XrefRangeEnd = 466070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline,
    bool secure,
    bool alert,
    string textPlaceholder,
    int characterLimit)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[8];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keyboardType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &autocorrection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &multiline;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &secure;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &alert;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(textPlaceholder);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &characterLimit;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_Boolean_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (TouchScreenKeyboard) null : Il2CppObjectPool.Get<TouchScreenKeyboard>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 466090, RefRangeEnd = 466091, XrefRangeStart = 466072, XrefRangeEnd = 466090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline,
    bool secure)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keyboardType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &autocorrection;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &multiline;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &secure;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_Open_Public_Static_TouchScreenKeyboard_String_TouchScreenKeyboardType_Boolean_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (TouchScreenKeyboard) null : Il2CppObjectPool.Get<TouchScreenKeyboard>(num3);
  }

  public unsafe string text
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 466097, RefRangeEnd = 466105, XrefRangeStart = 466091, XrefRangeEnd = 466097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(12), CachedScanResults(RefRangeStart = 466120, RefRangeEnd = 466132, XrefRangeStart = 466105, XrefRangeEnd = 466120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe bool hideInput
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 466134, RefRangeEnd = 466138, XrefRangeStart = 466132, XrefRangeEnd = 466134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_hideInput_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => TouchScreenKeyboard.get_hideInputDelegateField();
  }

  public static unsafe TouchScreenKeyboard.InputFieldAppearance inputFieldAppearance
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 466140, RefRangeEnd = 466142, XrefRangeStart = 466138, XrefRangeEnd = 466140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_inputFieldAppearance_Public_Static_get_InputFieldAppearance_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TouchScreenKeyboard.InputFieldAppearance*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool active
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 466146, RefRangeEnd = 466151, XrefRangeStart = 466142, XrefRangeEnd = 466146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 466155, RefRangeEnd = 466161, XrefRangeStart = 466151, XrefRangeEnd = 466155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TouchScreenKeyboard.Status status
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 466165, RefRangeEnd = 466166, XrefRangeStart = 466161, XrefRangeEnd = 466165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TouchScreenKeyboard.Status*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int characterLimit
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 466170, RefRangeEnd = 466172, XrefRangeStart = 466166, XrefRangeEnd = 466170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      System.IntPtr native = TouchScreenKeyboard.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return TouchScreenKeyboard.get_characterLimit_Injected(native);
    }
  }

  public unsafe bool canGetSelection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466172, XrefRangeEnd = 466176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool canSetSelection
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 466180, RefRangeEnd = 466182, XrefRangeStart = 466176, XrefRangeEnd = 466180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe RangeInt selection
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 466184, RefRangeEnd = 466187, XrefRangeStart = 466182, XrefRangeEnd = 466184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_selection_Public_get_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RangeInt*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(10), CachedScanResults(RefRangeStart = 466192, RefRangeEnd = 466202, XrefRangeStart = 466187, XrefRangeEnd = 466192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_selection_Public_set_Void_RangeInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466202, XrefRangeEnd = 466204, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSelection(out int start, out int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_GetSelection_Private_Static_Void_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466204, XrefRangeEnd = 466206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetSelection(int start, int length)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &start;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_SetSelection_Private_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466206, XrefRangeEnd = 466208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(
    ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments,
    ref ManagedSpanWrapper text,
    ref ManagedSpanWrapper textPlaceholder)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref arguments;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref text;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref textPlaceholder;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_TouchScreenKeyboard_InternalConstructorHelper_Injected_Private_Static_IntPtr_byref_TouchScreenKeyboard_InternalConstructorHelperArguments_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466208, XrefRangeEnd = 466210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_text_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466210, XrefRangeEnd = 466212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_text_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_text_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466212, XrefRangeEnd = 466214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_active_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_active_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466214, XrefRangeEnd = 466216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_active_Injected(System.IntPtr _unity_self, bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_active_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466216, XrefRangeEnd = 466218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe TouchScreenKeyboard.Status get_status_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_status_Injected_Private_Static_Status_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TouchScreenKeyboard.Status*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466218, XrefRangeEnd = 466220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_characterLimit_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_set_characterLimit_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466220, XrefRangeEnd = 466222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_canGetSelection_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canGetSelection_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466222, XrefRangeEnd = 466224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_canSetSelection_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.NativeMethodInfoPtr_get_canSetSelection_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TouchScreenKeyboard.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public static unsafe bool _disableInPlaceEditing_k__BackingField
  {
    get
    {
      bool editingKBackingField;
      IL2CPP.il2cpp_field_static_get_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*) &editingKBackingField);
      return editingKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TouchScreenKeyboard.NativeFieldInfoPtr__disableInPlaceEditing_k__BackingField, (void*) &value);
    }
  }

  public static TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline,
    bool secure,
    bool alert,
    string textPlaceholder)
  {
    int characterLimit = 0;
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline,
    bool secure,
    bool alert)
  {
    int characterLimit = 0;
    string textPlaceholder = "";
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection,
    bool multiline)
  {
    int characterLimit = 0;
    string textPlaceholder = "";
    bool alert = false;
    bool secure = false;
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static TouchScreenKeyboard Open(
    string text,
    TouchScreenKeyboardType keyboardType,
    bool autocorrection)
  {
    int characterLimit = 0;
    string textPlaceholder = "";
    bool alert = false;
    bool secure = false;
    bool multiline = false;
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType)
  {
    int characterLimit = 0;
    string textPlaceholder = "";
    bool alert = false;
    bool secure = false;
    bool multiline = false;
    bool autocorrection = true;
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static TouchScreenKeyboard Open(string text)
  {
    int characterLimit = 0;
    string textPlaceholder = "";
    bool alert = false;
    bool secure = false;
    bool multiline = false;
    bool autocorrection = true;
    TouchScreenKeyboardType keyboardType = TouchScreenKeyboardType.Default;
    return TouchScreenKeyboard.Open(text, keyboardType, autocorrection, multiline, secure, alert, textPlaceholder, characterLimit);
  }

  public static bool GetDone(System.IntPtr ptr) => TouchScreenKeyboard.GetDoneDelegateField(ptr);

  public bool done => TouchScreenKeyboard.GetDone(this.m_Ptr);

  public static bool GetWasCanceled(System.IntPtr ptr)
  {
    return TouchScreenKeyboard.GetWasCanceledDelegateField(ptr);
  }

  public bool wasCanceled => TouchScreenKeyboard.GetWasCanceled(this.m_Ptr);

  public TouchScreenKeyboardType type
  {
    get
    {
      System.IntPtr native = TouchScreenKeyboard.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return TouchScreenKeyboard.get_type_Injected(native);
    }
  }

  public int targetDisplay
  {
    get => 0;
    set
    {
    }
  }

  public static Rect area
  {
    get
    {
      Rect ret;
      TouchScreenKeyboard.get_area_Injected(out ret);
      return ret;
    }
  }

  public static bool visible => TouchScreenKeyboard.get_visibleDelegateField();

  public static int get_characterLimit_Injected(System.IntPtr _unity_self)
  {
    return TouchScreenKeyboard.get_characterLimit_InjectedDelegateField(_unity_self);
  }

  public static TouchScreenKeyboardType get_type_Injected(System.IntPtr _unity_self)
  {
    return TouchScreenKeyboard.get_type_InjectedDelegateField(_unity_self);
  }

  public static void get_area_Injected(out Rect ret)
  {
    TouchScreenKeyboard.get_area_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public enum Status
  {
    Visible,
    Done,
    Canceled,
    LostFocus,
  }

  public enum InputFieldAppearance
  {
    Customizable,
    AlwaysVisible,
    AlwaysHidden,
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TouchScreenKeyboard_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<TouchScreenKeyboard.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TouchScreenKeyboard>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TouchScreenKeyboard.BindingsMarshaller>.NativeClassPtr);
      TouchScreenKeyboard.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TouchScreenKeyboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TouchScreenKeyboard.BindingsMarshaller>.NativeClassPtr, 100668638);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) touchScreenKeyboard)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TouchScreenKeyboard.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_TouchScreenKeyboard_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public class Android
  {
  }

  private delegate bool get_hideInputDelegate();

  private delegate bool GetDoneDelegate(System.IntPtr ptr);

  private delegate bool GetWasCanceledDelegate(System.IntPtr ptr);

  private delegate bool get_visibleDelegate();

  private delegate int get_characterLimit_InjectedDelegate(System.IntPtr _unity_self);

  private delegate TouchScreenKeyboardType get_type_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void get_area_InjectedDelegate([Out] System.IntPtr ret);
}
