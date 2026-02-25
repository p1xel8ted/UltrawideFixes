// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIConfirmationWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Replaced.Scripts.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIConfirmationWindow(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_articyTitleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyText;
  private static readonly System.IntPtr NativeFieldInfoPtr_yesButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_noButton;
  private static readonly System.IntPtr NativeFieldInfoPtr_additionalArticyText;
  private static readonly System.IntPtr NativeFieldInfoPtr_tryReturnFocusTo;
  private static readonly System.IntPtr NativeFieldInfoPtr_TextFormatArguments;
  private static readonly System.IntPtr NativeFieldInfoPtr__ShowAdditionalText_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_submenu;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Confirmed_Public_get_ButtonClickedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Cancelled_Public_get_ButtonClickedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ShowAdditionalText_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ShowAdditionalText_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AskConfirmationNoResult_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AskConfirmation_Public_UniTask_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIConfirmationWindow()
  {
    Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIConfirmationWindow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr);
    UIConfirmationWindow.NativeFieldInfoPtr_articyTitleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (articyTitleText));
    UIConfirmationWindow.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (titleText));
    UIConfirmationWindow.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (text));
    UIConfirmationWindow.NativeFieldInfoPtr_articyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (articyText));
    UIConfirmationWindow.NativeFieldInfoPtr_yesButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (yesButton));
    UIConfirmationWindow.NativeFieldInfoPtr_noButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (noButton));
    UIConfirmationWindow.NativeFieldInfoPtr_additionalArticyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (additionalArticyText));
    UIConfirmationWindow.NativeFieldInfoPtr_tryReturnFocusTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (tryReturnFocusTo));
    UIConfirmationWindow.NativeFieldInfoPtr_TextFormatArguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (TextFormatArguments));
    UIConfirmationWindow.NativeFieldInfoPtr__ShowAdditionalText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, "<ShowAdditionalText>k__BackingField");
    UIConfirmationWindow.NativeFieldInfoPtr_submenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, nameof (submenu));
    UIConfirmationWindow.NativeMethodInfoPtr_get_Confirmed_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672299);
    UIConfirmationWindow.NativeMethodInfoPtr_get_Cancelled_Public_get_ButtonClickedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672300);
    UIConfirmationWindow.NativeMethodInfoPtr_get_ShowAdditionalText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672301);
    UIConfirmationWindow.NativeMethodInfoPtr_set_ShowAdditionalText_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672302);
    UIConfirmationWindow.NativeMethodInfoPtr_AskConfirmationNoResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672303);
    UIConfirmationWindow.NativeMethodInfoPtr_AskConfirmation_Public_UniTask_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672304);
    UIConfirmationWindow.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672305);
    UIConfirmationWindow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, 100672306);
  }

  public unsafe Button.ButtonClickedEvent Confirmed
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_get_Confirmed_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Button.ButtonClickedEvent) null : Il2CppObjectPool.Get<Button.ButtonClickedEvent>(num3);
    }
  }

  public unsafe Button.ButtonClickedEvent Cancelled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_get_Cancelled_Public_get_ButtonClickedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Button.ButtonClickedEvent) null : Il2CppObjectPool.Get<Button.ButtonClickedEvent>(num3);
    }
  }

  public unsafe bool ShowAdditionalText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_get_ShowAdditionalText_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_set_ShowAdditionalText_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100468, XrefRangeEnd = 100472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AskConfirmationNoResult()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_AskConfirmationNoResult_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 100480, RefRangeEnd = 100483, XrefRangeStart = 100472, XrefRangeEnd = 100480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask<bool> AskConfirmation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_AskConfirmation_Public_UniTask_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask<bool>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100483, XrefRangeEnd = 100501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100501, XrefRangeEnd = 100505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIConfirmationWindow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef articyTitleText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_articyTitleText));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_articyTitleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text titleText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_titleText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text text
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_text));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef articyText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_articyText));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_articyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button yesButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_yesButton));
      return num == System.IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_yesButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Button noButton
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_noButton));
      return num == System.IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_noButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef additionalArticyText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_additionalArticyText));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_additionalArticyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Selectable> tryReturnFocusTo
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_tryReturnFocusTo));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Selectable>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Selectable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_tryReturnFocusTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray TextFormatArguments
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_TextFormatArguments));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_TextFormatArguments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _ShowAdditionalText_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr__ShowAdditionalText_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr__ShowAdditionalText_k__BackingField)) = value;
    }
  }

  public unsafe UISubmenu submenu
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_submenu));
      return num == System.IntPtr.Zero ? (UISubmenu) null : Il2CppObjectPool.Get<UISubmenu>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.NativeFieldInfoPtr_submenu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIConfirmationWindow+<>c__DisplayClass19_0")]
  public sealed class __c__DisplayClass19_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_done;
    private static readonly System.IntPtr NativeFieldInfoPtr_confirmed;
    private static readonly System.IntPtr NativeFieldInfoPtr_exited;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AskConfirmation_b__0_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AskConfirmation_b__1_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AskConfirmation_b__2_Internal_Void_0;

    static __c__DisplayClass19_0()
    {
      Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, "<>c__DisplayClass19_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr);
      UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, nameof (done));
      UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_confirmed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, nameof (confirmed));
      UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_exited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, nameof (exited));
      UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, 100672307);
      UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, 100672308);
      UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, 100672309);
      UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr, 100672310);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass19_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIConfirmationWindow.__c__DisplayClass19_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void _AskConfirmation_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void _AskConfirmation_b__1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void _AskConfirmation_b__2()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow.__c__DisplayClass19_0.NativeMethodInfoPtr__AskConfirmation_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool done
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_done));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_done)) = value;
      }
    }

    public unsafe bool confirmed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_confirmed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_confirmed)) = value;
      }
    }

    public unsafe bool exited
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_exited));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow.__c__DisplayClass19_0.NativeFieldInfoPtr_exited)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIConfirmationWindow+<AskConfirmation>d__19")]
  public sealed class _AskConfirmation_d__19 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _AskConfirmation_d__19()
    {
      Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, "<AskConfirmation>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr);
      UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, "<>1__state");
      UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, "<>t__builder");
      UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, "<>4__this");
      UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, "<>8__1");
      UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, "<>u__1");
      UIConfirmationWindow._AskConfirmation_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, 100672311);
      UIConfirmationWindow._AskConfirmation_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr, 100672312);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 100451, RefRangeEnd = 100452, XrefRangeStart = 100388, XrefRangeEnd = 100451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow._AskConfirmation_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100452, XrefRangeEnd = 100455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow._AskConfirmation_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _AskConfirmation_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _AskConfirmation_d__19()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmation_d__19>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder<bool> __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIConfirmationWindow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIConfirmationWindow) null : Il2CppObjectPool.Get<UIConfirmationWindow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIConfirmationWindow.__c__DisplayClass19_0 __8__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___8__1));
        return num == System.IntPtr.Zero ? (UIConfirmationWindow.__c__DisplayClass19_0) null : Il2CppObjectPool.Get<UIConfirmationWindow.__c__DisplayClass19_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmation_d__19.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIConfirmationWindow+<AskConfirmationNoResult>d__18")]
  public sealed class _AskConfirmationNoResult_d__18 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _AskConfirmationNoResult_d__18()
    {
      Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIConfirmationWindow>.NativeClassPtr, "<AskConfirmationNoResult>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr);
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, "<>1__state");
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, "<>t__builder");
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, "<>4__this");
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, "<>u__1");
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, 100672313);
      UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr, 100672314);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100455, XrefRangeEnd = 100468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _AskConfirmationNoResult_d__18(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _AskConfirmationNoResult_d__18()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIConfirmationWindow._AskConfirmationNoResult_d__18>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UIConfirmationWindow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIConfirmationWindow) null : Il2CppObjectPool.Get<UIConfirmationWindow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask<bool>.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___u__1);
        return new UniTask<bool>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIConfirmationWindow._AskConfirmationNoResult_d__18.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<bool>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
