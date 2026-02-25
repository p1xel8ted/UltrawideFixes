// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UITutorialDialogue
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
using Il2CppSystem.Text.RegularExpressions;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UITutorialDialogue(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_glyphText;
  private static readonly System.IntPtr NativeFieldInfoPtr_nextPrompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_previousPrompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_closePrompt;
  private static readonly System.IntPtr NativeFieldInfoPtr_closeSlider;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleText;
  private static readonly System.IntPtr NativeFieldInfoPtr_tutorialImage;
  private static readonly System.IntPtr NativeFieldInfoPtr_titleRegex;
  private static readonly System.IntPtr NativeFieldInfoPtr_articySubstRegex;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Private_Void_String_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowOnScreen_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubstArticyReplacements_Private_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunTutorial_Private_UniTask_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UITutorialDialogue()
  {
    Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UITutorialDialogue));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr);
    UITutorialDialogue.NativeFieldInfoPtr_glyphText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (glyphText));
    UITutorialDialogue.NativeFieldInfoPtr_nextPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (nextPrompt));
    UITutorialDialogue.NativeFieldInfoPtr_previousPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (previousPrompt));
    UITutorialDialogue.NativeFieldInfoPtr_closePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (closePrompt));
    UITutorialDialogue.NativeFieldInfoPtr_closeSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (closeSlider));
    UITutorialDialogue.NativeFieldInfoPtr_titleText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (titleText));
    UITutorialDialogue.NativeFieldInfoPtr_tutorialImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (tutorialImage));
    UITutorialDialogue.NativeFieldInfoPtr_titleRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (titleRegex));
    UITutorialDialogue.NativeFieldInfoPtr_articySubstRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, nameof (articySubstRegex));
    UITutorialDialogue.NativeMethodInfoPtr_SetText_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, 100672539);
    UITutorialDialogue.NativeMethodInfoPtr_ShowOnScreen_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, 100672540);
    UITutorialDialogue.NativeMethodInfoPtr_SubstArticyReplacements_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, 100672541);
    UITutorialDialogue.NativeMethodInfoPtr_RunTutorial_Private_UniTask_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, 100672542);
    UITutorialDialogue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, 100672543);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101893, RefRangeEnd = 101895, XrefRangeStart = 101883, XrefRangeEnd = 101893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text, int currentI, int maxI)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentI;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxI;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.NativeMethodInfoPtr_SetText_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 101933, RefRangeEnd = 101934, XrefRangeStart = 101895, XrefRangeEnd = 101933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask ShowOnScreen(
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
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.NativeMethodInfoPtr_ShowOnScreen_Public_UniTask_String_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101967, RefRangeEnd = 101969, XrefRangeStart = 101934, XrefRangeEnd = 101967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string SubstArticyReplacements(string str)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(str)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.NativeMethodInfoPtr_SubstArticyReplacements_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101969, XrefRangeEnd = 101974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask RunTutorial(
    Il2CppStringArray tutorialStrings,
    Il2CppStringArray title,
    Il2CppReferenceArray<Sprite> images)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tutorialStrings);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) images);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.NativeMethodInfoPtr_RunTutorial_Private_UniTask_Il2CppStringArray_Il2CppStringArray_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UITutorialDialogue()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIGlyphText glyphText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_glyphText));
      return num == System.IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_glyphText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyLocaCaretaker nextPrompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_nextPrompt));
      return num == System.IntPtr.Zero ? (ArticyLocaCaretaker) null : Il2CppObjectPool.Get<ArticyLocaCaretaker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_nextPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyLocaCaretaker previousPrompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_previousPrompt));
      return num == System.IntPtr.Zero ? (ArticyLocaCaretaker) null : Il2CppObjectPool.Get<ArticyLocaCaretaker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_previousPrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyLocaCaretaker closePrompt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_closePrompt));
      return num == System.IntPtr.Zero ? (ArticyLocaCaretaker) null : Il2CppObjectPool.Get<ArticyLocaCaretaker>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_closePrompt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Slider closeSlider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_closeSlider));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_closeSlider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text titleText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_titleText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_titleText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image tutorialImage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_tutorialImage));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue.NativeFieldInfoPtr_tutorialImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Regex titleRegex
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UITutorialDialogue.NativeFieldInfoPtr_titleRegex, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UITutorialDialogue.NativeFieldInfoPtr_titleRegex, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Regex articySubstRegex
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UITutorialDialogue.NativeFieldInfoPtr_articySubstRegex, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UITutorialDialogue.NativeFieldInfoPtr_articySubstRegex, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UITutorialDialogue+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__SubstArticyReplacements_b__11_0_Internal_String_Match_0;

    static __c()
    {
      Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr);
      UITutorialDialogue.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr, "<>9");
      UITutorialDialogue.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr, "<>9__11_0");
      UITutorialDialogue.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr, 100672546);
      UITutorialDialogue.__c.NativeMethodInfoPtr__SubstArticyReplacements_b__11_0_Internal_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr, 100672547);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITutorialDialogue.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101822, XrefRangeEnd = 101833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _SubstArticyReplacements_b__11_0(Match match)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) match)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue.__c.NativeMethodInfoPtr__SubstArticyReplacements_b__11_0_Internal_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    public static unsafe UITutorialDialogue.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UITutorialDialogue.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UITutorialDialogue.__c) null : Il2CppObjectPool.Get<UITutorialDialogue.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UITutorialDialogue.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MatchEvaluator __9__11_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UITutorialDialogue.__c.NativeFieldInfoPtr___9__11_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MatchEvaluator) null : Il2CppObjectPool.Get<MatchEvaluator>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UITutorialDialogue.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UITutorialDialogue+<RunTutorial>d__12")]
  public sealed class _RunTutorial_d__12 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_tutorialStrings;
    private static readonly System.IntPtr NativeFieldInfoPtr_title;
    private static readonly System.IntPtr NativeFieldInfoPtr_images;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__closeTimer_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__submit_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RunTutorial_d__12()
    {
      Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UITutorialDialogue>.NativeClassPtr, "<RunTutorial>d__12");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr);
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<>1__state");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<>t__builder");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<>4__this");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_tutorialStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, nameof (tutorialStrings));
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, nameof (title));
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_images = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, nameof (images));
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<i>5__2");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__closeTimer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<closeTimer>5__3");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__submit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<submit>5__4");
      UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, "<>u__1");
      UITutorialDialogue._RunTutorial_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, 100672548);
      UITutorialDialogue._RunTutorial_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr, 100672549);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 101879, RefRangeEnd = 101883, XrefRangeStart = 101833, XrefRangeEnd = 101879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue._RunTutorial_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(UITutorialDialogue._RunTutorial_d__12.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RunTutorial_d__12(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RunTutorial_d__12()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UITutorialDialogue._RunTutorial_d__12>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe UITutorialDialogue __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UITutorialDialogue) null : Il2CppObjectPool.Get<UITutorialDialogue>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStringArray tutorialStrings
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_tutorialStrings));
        return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_tutorialStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStringArray title
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_title));
        return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Sprite> images
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_images));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr_images), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }

    public unsafe float _closeTimer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__closeTimer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__closeTimer_5__3)) = value;
      }
    }

    public unsafe bool _submit_5__4
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__submit_5__4));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr__submit_5__4)) = value;
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__1
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___u__1));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UITutorialDialogue._RunTutorial_d__12.NativeFieldInfoPtr___u__1)) = value;
      }
    }
  }
}
