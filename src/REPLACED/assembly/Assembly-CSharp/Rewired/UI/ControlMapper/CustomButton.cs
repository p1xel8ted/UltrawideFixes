// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CustomButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class CustomButton(System.IntPtr pointer) : UnityEngine.UI.Button(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__disabledHighlightedSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr__disabledHighlightedColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__disabledHighlightedTrigger;
  private static readonly System.IntPtr NativeFieldInfoPtr__autoNavUp;
  private static readonly System.IntPtr NativeFieldInfoPtr__autoNavDown;
  private static readonly System.IntPtr NativeFieldInfoPtr__autoNavLeft;
  private static readonly System.IntPtr NativeFieldInfoPtr__autoNavRight;
  private static readonly System.IntPtr NativeFieldInfoPtr_isHighlightDisabled;
  private static readonly System.IntPtr NativeFieldInfoPtr__CancelEvent;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Press_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CustomButton()
  {
    Il2CppClassPointerStore<CustomButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CustomButton));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomButton>.NativeClassPtr);
    CustomButton.NativeFieldInfoPtr__disabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_disabledHighlightedSprite));
    CustomButton.NativeFieldInfoPtr__disabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_disabledHighlightedColor));
    CustomButton.NativeFieldInfoPtr__disabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_disabledHighlightedTrigger));
    CustomButton.NativeFieldInfoPtr__autoNavUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_autoNavUp));
    CustomButton.NativeFieldInfoPtr__autoNavDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_autoNavDown));
    CustomButton.NativeFieldInfoPtr__autoNavLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_autoNavLeft));
    CustomButton.NativeFieldInfoPtr__autoNavRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_autoNavRight));
    CustomButton.NativeFieldInfoPtr_isHighlightDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (isHighlightDisabled));
    CustomButton.NativeFieldInfoPtr__CancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, nameof (_CancelEvent));
    CustomButton.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669623);
    CustomButton.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669624);
    CustomButton.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669625);
    CustomButton.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669626);
    CustomButton.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669627);
    CustomButton.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669628);
    CustomButton.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669629);
    CustomButton.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669630);
    CustomButton.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669631);
    CustomButton.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669632);
    CustomButton.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669633);
    CustomButton.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669634);
    CustomButton.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669635);
    CustomButton.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669636);
    CustomButton.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669637);
    CustomButton.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669638);
    CustomButton.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669639);
    CustomButton.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669640);
    CustomButton.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669641);
    CustomButton.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669642);
    CustomButton.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669643);
    CustomButton.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669644);
    CustomButton.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669645);
    CustomButton.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669646);
    CustomButton.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669647);
    CustomButton.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669648);
    CustomButton.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669649);
    CustomButton.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669650);
    CustomButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669651);
    CustomButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669652);
    CustomButton.NativeMethodInfoPtr_Press_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669653);
    CustomButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669654);
    CustomButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669655);
    CustomButton.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669656);
    CustomButton.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669657);
    CustomButton.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669658);
    CustomButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, 100669659);
  }

  public virtual unsafe Sprite disabledHighlightedSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Color disabledHighlightedColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string disabledHighlightedTrigger
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavUp
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavDown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavLeft
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool autoNavRight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool isDisabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78344, XrefRangeEnd = 78348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78348, XrefRangeEnd = 78352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void add_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public virtual unsafe void remove_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78352, XrefRangeEnd = 78360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnLeft()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78360, XrefRangeEnd = 78368, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnRight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78368, XrefRangeEnd = 78376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78376, XrefRangeEnd = 78384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78384, XrefRangeEnd = 78401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCanvasGroupChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78401, XrefRangeEnd = 78425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &instant;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78425, XrefRangeEnd = 78433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void StartColorTween(Color targetColor, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &targetColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &instant;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78433, XrefRangeEnd = 78440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void DoSpriteSwap(Sprite newSprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78440, XrefRangeEnd = 78459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void TriggerAnimation(string triggername)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(triggername)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78459, XrefRangeEnd = 78460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78460, XrefRangeEnd = 78463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78464, RefRangeEnd = 78465, XrefRangeStart = 78463, XrefRangeEnd = 78464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Press()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_Press_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78465, XrefRangeEnd = 78466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerClick(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_OnPointerClick_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78466, XrefRangeEnd = 78473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSubmit(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78473, XrefRangeEnd = 78477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe IEnumerator OnFinishSubmit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_OnFinishSubmit_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78479, RefRangeEnd = 78480, XrefRangeStart = 78477, XrefRangeEnd = 78479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateHightlightDisabled(bool isSelected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &isSelected
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnCancel(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78480, XrefRangeEnd = 78481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomButton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomButton>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Sprite _disabledHighlightedSprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedSprite));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _disabledHighlightedColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedColor)) = value;
    }
  }

  public unsafe string _disabledHighlightedTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedTrigger)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__disabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _autoNavUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavUp)) = value;
    }
  }

  public unsafe bool _autoNavDown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavDown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavDown)) = value;
    }
  }

  public unsafe bool _autoNavLeft
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavLeft));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavLeft)) = value;
    }
  }

  public unsafe bool _autoNavRight
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavRight));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__autoNavRight)) = value;
    }
  }

  public unsafe bool isHighlightDisabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr_isHighlightDisabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr_isHighlightDisabled)) = value;
    }
  }

  public unsafe UnityAction _CancelEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__CancelEvent));
      return num == System.IntPtr.Zero ? (UnityAction) null : Il2CppObjectPool.Get<UnityAction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomButton.NativeFieldInfoPtr__CancelEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("Rewired.UI.ControlMapper.CustomButton+<OnFinishSubmit>d__51")]
  public sealed class _OnFinishSubmit_d__51(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__fadeTime_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__elapsedTime_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _OnFinishSubmit_d__51()
    {
      Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomButton>.NativeClassPtr, "<OnFinishSubmit>d__51");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr);
      CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, "<>1__state");
      CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, "<>2__current");
      CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, "<>4__this");
      CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__fadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, "<fadeTime>5__2");
      CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__elapsedTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, "<elapsedTime>5__3");
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669660);
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669661);
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669662);
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669663);
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669664);
      CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr, 100669665);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _OnFinishSubmit_d__51(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomButton._OnFinishSubmit_d__51>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78334, XrefRangeEnd = 78339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78339, XrefRangeEnd = 78344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomButton._OnFinishSubmit_d__51.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CustomButton __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CustomButton) null : Il2CppObjectPool.Get<CustomButton>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _fadeTime_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__fadeTime_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__fadeTime_5__2)) = value;
      }
    }

    public unsafe float _elapsedTime_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__elapsedTime_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomButton._OnFinishSubmit_d__51.NativeFieldInfoPtr__elapsedTime_5__3)) = value;
      }
    }
  }
}
