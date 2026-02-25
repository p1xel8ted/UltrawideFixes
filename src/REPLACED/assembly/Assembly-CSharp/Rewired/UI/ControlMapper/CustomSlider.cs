// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.CustomSlider
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

public class CustomSlider(IntPtr pointer) : Slider(pointer)
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

  static CustomSlider()
  {
    Il2CppClassPointerStore<CustomSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (CustomSlider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr);
    CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_disabledHighlightedSprite));
    CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_disabledHighlightedColor));
    CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_disabledHighlightedTrigger));
    CustomSlider.NativeFieldInfoPtr__autoNavUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_autoNavUp));
    CustomSlider.NativeFieldInfoPtr__autoNavDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_autoNavDown));
    CustomSlider.NativeFieldInfoPtr__autoNavLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_autoNavLeft));
    CustomSlider.NativeFieldInfoPtr__autoNavRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_autoNavRight));
    CustomSlider.NativeFieldInfoPtr_isHighlightDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (isHighlightDisabled));
    CustomSlider.NativeFieldInfoPtr__CancelEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, nameof (_CancelEvent));
    CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669666);
    CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669667);
    CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669668);
    CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669669);
    CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669670);
    CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669671);
    CustomSlider.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669672);
    CustomSlider.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669673);
    CustomSlider.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669674);
    CustomSlider.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669675);
    CustomSlider.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669676);
    CustomSlider.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669677);
    CustomSlider.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669678);
    CustomSlider.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669679);
    CustomSlider.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669680);
    CustomSlider.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669681);
    CustomSlider.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669682);
    CustomSlider.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669683);
    CustomSlider.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669684);
    CustomSlider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669685);
    CustomSlider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669686);
    CustomSlider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669687);
    CustomSlider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669688);
    CustomSlider.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669689);
    CustomSlider.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669690);
    CustomSlider.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669691);
    CustomSlider.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669692);
    CustomSlider.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669693);
    CustomSlider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669694);
    CustomSlider.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669695);
    CustomSlider.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669696 /*0x06001900*/);
    CustomSlider.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669697);
    CustomSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr, 100669698);
  }

  public virtual unsafe Sprite disabledHighlightedSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavUp_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavUp_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavDown_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavDown_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavLeft_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavLeft_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_autoNavRight_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_set_autoNavRight_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_get_isDisabled_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78481, XrefRangeEnd = 78485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_add__CancelEvent_Private_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78485, XrefRangeEnd = 78489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove__CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_remove__CancelEvent_Private_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_add_CancelEvent_Public_Virtual_Final_New_add_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_remove_CancelEvent_Public_Virtual_Final_New_rem_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78489, XrefRangeEnd = 78497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnLeft()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnLeft_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78497, XrefRangeEnd = 78505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnRight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnRight_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78505, XrefRangeEnd = 78513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnUp()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnUp_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78513, XrefRangeEnd = 78521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Selectable FindSelectableOnDown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_FindSelectableOnDown_Public_Virtual_Selectable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78521, XrefRangeEnd = 78538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCanvasGroupChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78538, XrefRangeEnd = 78562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &state;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_DoStateTransition_Protected_Virtual_Void_SelectionState_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78562, XrefRangeEnd = 78570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void StartColorTween(Color targetColor, bool instant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &targetColor;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &instant;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_StartColorTween_Private_Void_Color_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78570, XrefRangeEnd = 78577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void DoSpriteSwap(Sprite newSprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newSprite)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_DoSpriteSwap_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78577, XrefRangeEnd = 78596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void TriggerAnimation(string triggername)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(triggername)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_TriggerAnimation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78596, XrefRangeEnd = 78597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78597, XrefRangeEnd = 78600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CustomSlider.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 78602, RefRangeEnd = 78603, XrefRangeStart = 78600, XrefRangeEnd = 78602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateHightlightDisabled(bool isSelected)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isSelected
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_EvaluateHightlightDisabled_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78603, XrefRangeEnd = 78604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CustomSlider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomSlider>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Sprite _disabledHighlightedSprite
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite));
      return num == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color _disabledHighlightedColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedColor)) = value;
    }
  }

  public unsafe string _disabledHighlightedTrigger
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__disabledHighlightedTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _autoNavUp
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavUp));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavUp)) = value;
    }
  }

  public unsafe bool _autoNavDown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavDown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavDown)) = value;
    }
  }

  public unsafe bool _autoNavLeft
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavLeft));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavLeft)) = value;
    }
  }

  public unsafe bool _autoNavRight
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavRight));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__autoNavRight)) = value;
    }
  }

  public unsafe bool isHighlightDisabled
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr_isHighlightDisabled));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr_isHighlightDisabled)) = value;
    }
  }

  public unsafe UnityAction _CancelEvent
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__CancelEvent));
      return num == IntPtr.Zero ? (UnityAction) null : Il2CppObjectPool.Get<UnityAction>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CustomSlider.NativeFieldInfoPtr__CancelEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
