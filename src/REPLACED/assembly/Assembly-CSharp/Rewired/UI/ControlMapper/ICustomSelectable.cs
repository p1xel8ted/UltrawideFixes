// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.ICustomSelectable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class ICustomSelectable(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0;
  private static readonly IntPtr NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0;

  static ICustomSelectable()
  {
    Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (ICustomSelectable));
    ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669732);
    ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669733);
    ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669734);
    ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669735);
    ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669736);
    ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669737);
    ICustomSelectable.NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669738);
    ICustomSelectable.NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669739);
    ICustomSelectable.NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669740);
    ICustomSelectable.NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669741);
    ICustomSelectable.NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669742);
    ICustomSelectable.NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669743);
    ICustomSelectable.NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669744);
    ICustomSelectable.NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669745);
    ICustomSelectable.NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669746);
    ICustomSelectable.NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomSelectable>.NativeClassPtr, 100669747);
  }

  public virtual unsafe Sprite disabledHighlightedSprite
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedSprite_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedSprite_Public_Abstract_Virtual_New_set_Void_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedColor_Public_Abstract_Virtual_New_get_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedColor_Public_Abstract_Virtual_New_set_Void_Color_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_disabledHighlightedTrigger_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_disabledHighlightedTrigger_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavUp_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavUp_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavDown_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavDown_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavLeft_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavLeft_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_get_autoNavRight_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_set_autoNavRight_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [SpecialName]
  public virtual unsafe void add_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_add_CancelEvent_Public_Abstract_Virtual_New_add_Void_UnityAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [SpecialName]
  public virtual unsafe void remove_CancelEvent(UnityAction value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ICustomSelectable.NativeMethodInfoPtr_remove_CancelEvent_Public_Abstract_Virtual_New_rem_Void_UnityAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
