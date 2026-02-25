// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIDialogAnswerElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text.RegularExpressions;
using SadCatStudios.PlayerInput;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIDialogAnswerElement(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonPromptText;
  private static readonly System.IntPtr NativeFieldInfoPtr_choiceTextMesh;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_specialColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateChangeColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_button;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_colorRegex;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Int32_String_Boolean_Action_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIDialogAnswerElement()
  {
    Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIDialogAnswerElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr);
    UIDialogAnswerElement.NativeFieldInfoPtr_buttonPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (buttonPromptText));
    UIDialogAnswerElement.NativeFieldInfoPtr_choiceTextMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (choiceTextMesh));
    UIDialogAnswerElement.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (inputAction));
    UIDialogAnswerElement.NativeFieldInfoPtr_specialColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (specialColor));
    UIDialogAnswerElement.NativeFieldInfoPtr_stateChangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (stateChangeColor));
    UIDialogAnswerElement.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (button));
    UIDialogAnswerElement.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (active));
    UIDialogAnswerElement.NativeFieldInfoPtr_colorRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, nameof (colorRegex));
    UIDialogAnswerElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, 100672315);
    UIDialogAnswerElement.NativeMethodInfoPtr_Init_Public_Void_Int32_String_Boolean_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, 100672316);
    UIDialogAnswerElement.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, 100672317);
    UIDialogAnswerElement.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, 100672318);
    UIDialogAnswerElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, 100672319);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100511, XrefRangeEnd = 100516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 100563, RefRangeEnd = 100565, XrefRangeStart = 100516, XrefRangeEnd = 100563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(int index, string choice, bool seen, Il2CppSystem.Action<int> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(choice);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &seen;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.NativeMethodInfoPtr_Init_Public_Void_Int32_String_Boolean_Action_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 100566, RefRangeEnd = 100568, XrefRangeStart = 100565, XrefRangeEnd = 100566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100568, XrefRangeEnd = 100573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100573, XrefRangeEnd = 100580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDialogAnswerElement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text buttonPromptText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_buttonPromptText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_buttonPromptText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI choiceTextMesh
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_choiceTextMesh));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_choiceTextMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputAction inputAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_inputAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_inputAction)) = value;
    }
  }

  public unsafe Color specialColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_specialColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_specialColor)) = value;
    }
  }

  public unsafe Color stateChangeColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_stateChangeColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_stateChangeColor)) = value;
    }
  }

  public unsafe Button button
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_button));
      return num == System.IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe Regex colorRegex
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_colorRegex));
      return num == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.NativeFieldInfoPtr_colorRegex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIDialogAnswerElement+<>c__DisplayClass9_0")]
  public sealed class __c__DisplayClass9_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;
    private static readonly System.IntPtr NativeFieldInfoPtr_index;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Init_b__0_Internal_Void_0;

    static __c__DisplayClass9_0()
    {
      Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDialogAnswerElement>.NativeClassPtr, "<>c__DisplayClass9_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr);
      UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr, nameof (callback));
      UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr, nameof (index));
      UIDialogAnswerElement.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr, 100672320);
      UIDialogAnswerElement.__c__DisplayClass9_0.NativeMethodInfoPtr__Init_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr, 100672321);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass9_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDialogAnswerElement.__c__DisplayClass9_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100505, XrefRangeEnd = 100511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Init_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDialogAnswerElement.__c__DisplayClass9_0.NativeMethodInfoPtr__Init_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppSystem.Action<int> callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogAnswerElement.__c__DisplayClass9_0.NativeFieldInfoPtr_index)) = value;
      }
    }
  }
}
