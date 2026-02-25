// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CustomToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class CustomToggle(IntPtr pointer) : Toggle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedSprite;
  private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedColor;
  private static readonly IntPtr NativeFieldInfoPtr__disabledHighlightedTrigger;
  private static readonly IntPtr NativeFieldInfoPtr__autoNavUp;
  private static readonly IntPtr NativeFieldInfoPtr__autoNavDown;
  private static readonly IntPtr NativeFieldInfoPtr__autoNavLeft;
  private static readonly IntPtr NativeFieldInfoPtr__autoNavRight;
  private static readonly IntPtr NativeFieldInfoPtr_isHighlightDisabled;
  private static readonly IntPtr NativeFieldInfoPtr__CancelEvent;
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomToggle()
  {
    Il2CppClassPointerStore<CustomToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CustomToggle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr);
    CustomToggle.NativeFieldInfoPtr__disabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_disabledHighlightedSprite));
    CustomToggle.NativeFieldInfoPtr__disabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_disabledHighlightedColor));
    CustomToggle.NativeFieldInfoPtr__disabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_disabledHighlightedTrigger));
    CustomToggle.NativeFieldInfoPtr__autoNavUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_autoNavUp));
    CustomToggle.NativeFieldInfoPtr__autoNavDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_autoNavDown));
    CustomToggle.NativeFieldInfoPtr__autoNavLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_autoNavLeft));
    CustomToggle.NativeFieldInfoPtr__autoNavRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_autoNavRight));
    CustomToggle.NativeFieldInfoPtr_isHighlightDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (isHighlightDisabled));
    CustomToggle.NativeFieldInfoPtr__CancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, nameof (_CancelEvent));
    CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669699);
    CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669700);
    CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669701);
    CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669702);
    CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669703);
    CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669704);
    CustomToggle.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669705);
    CustomToggle.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669706);
    CustomToggle.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669707);
    CustomToggle.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669708);
    CustomToggle.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669709);
    CustomToggle.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669710);
    CustomToggle.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669711);
    CustomToggle.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669712);
    CustomToggle.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669713);
    CustomToggle.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669714);
    CustomToggle.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669715);
    CustomToggle.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669716);
    CustomToggle.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669717);
    CustomToggle.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669718);
    CustomToggle.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669719);
    CustomToggle.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669720);
    CustomToggle.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669721);
    CustomToggle.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669722);
    CustomToggle.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669723);
    CustomToggle.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669724);
    CustomToggle.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669725);
    CustomToggle.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669726);
    CustomToggle.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669727);
    CustomToggle.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669728);
    CustomToggle.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669729);
    CustomToggle.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669730);
    CustomToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr, 100669731);
  }

  public virtual unsafe Sprite disabledHighlightedSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Color disabledHighlightedColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string disabledHighlightedTrigger
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavUp
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavDown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavLeft
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavRight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool isDisabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78604, XrefRangeEnd = 78608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78608, XrefRangeEnd = 78612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void add_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void remove_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78612, XrefRangeEnd = 78620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnLeft()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78620, XrefRangeEnd = 78628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnRight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78628, XrefRangeEnd = 78636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78636, XrefRangeEnd = 78644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78644, XrefRangeEnd = 78661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCanvasGroupChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78661, XrefRangeEnd = 78685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78685, XrefRangeEnd = 78693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void StartColorTween(Color targetColor, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &targetColor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78693, XrefRangeEnd = 78700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void DoSpriteSwap(Sprite newSprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78700, XrefRangeEnd = 78719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void TriggerAnimation(string triggername)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(triggername)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78719, XrefRangeEnd = 78720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78720, XrefRangeEnd = 78723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomToggle.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78725, RefRangeEnd = 78726, XrefRangeStart = 78723, XrefRangeEnd = 78725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateHightlightDisabled(bool isSelected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isSelected
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnCancel(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78726, XrefRangeEnd = 78727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomToggle()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomToggle>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Sprite _disabledHighlightedSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _disabledHighlightedColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedColor)) = value;
    }
  }

  public unsafe string _disabledHighlightedTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedTrigger)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__disabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _autoNavUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavUp)) = value;
    }
  }

  public unsafe bool _autoNavDown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavDown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavDown)) = value;
    }
  }

  public unsafe bool _autoNavLeft
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavLeft));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavLeft)) = value;
    }
  }

  public unsafe bool _autoNavRight
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavRight));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__autoNavRight)) = value;
    }
  }

  public unsafe bool isHighlightDisabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr_isHighlightDisabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr_isHighlightDisabled)) = value;
    }
  }

  public unsafe UnityAction _CancelEvent
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__CancelEvent));
      return num == IntPtr.Zero ? (UnityAction) null : Il2CppObjectPool.Get<UnityAction>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomToggle.NativeFieldInfoPtr__CancelEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
