// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UISubmenuHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UISubmenuHandler(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__submenuStack_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_submenuStack_Protected_get_Stack_1_SubmenuActions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMenuHandler_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_New_Void_SubmenuActions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromTopLevel_Protected_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToTopLevel_Protected_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitMenu_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitSubmenu_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SelectObject_Public_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static UISubmenuHandler()
  {
    Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UISubmenuHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr);
    UISubmenuHandler.NativeFieldInfoPtr__submenuStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, "<submenuStack>k__BackingField");
    UISubmenuHandler.NativeMethodInfoPtr_get_submenuStack_Protected_get_Stack_1_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672494);
    UISubmenuHandler.NativeMethodInfoPtr_UpdateMenuHandler_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672495);
    UISubmenuHandler.NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_New_Void_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672496);
    UISubmenuHandler.NativeMethodInfoPtr_FromTopLevel_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672497);
    UISubmenuHandler.NativeMethodInfoPtr_ToTopLevel_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672498);
    UISubmenuHandler.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672499);
    UISubmenuHandler.NativeMethodInfoPtr_ExitSubmenu_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672500);
    UISubmenuHandler.NativeMethodInfoPtr_SelectObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672501);
    UISubmenuHandler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, 100672502);
  }

  public unsafe Stack<UISubmenuHandler.SubmenuActions> submenuStack
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.NativeMethodInfoPtr_get_submenuStack_Protected_get_Stack_1_SubmenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Stack<UISubmenuHandler.SubmenuActions>) null : Il2CppObjectPool.Get<Stack<UISubmenuHandler.SubmenuActions>>(num3);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 101597, RefRangeEnd = 101600, XrefRangeStart = 101576, XrefRangeEnd = 101597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateMenuHandler()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.NativeMethodInfoPtr_UpdateMenuHandler_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 101616, RefRangeEnd = 101618, XrefRangeStart = 101600, XrefRangeEnd = 101616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnterSubmenu(UISubmenuHandler.SubmenuActions action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISubmenuHandler.NativeMethodInfoPtr_EnterSubmenu_Public_Virtual_New_Void_SubmenuActions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void FromTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISubmenuHandler.NativeMethodInfoPtr_FromTopLevel_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ToTopLevel()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISubmenuHandler.NativeMethodInfoPtr_ToTopLevel_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ExitMenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISubmenuHandler.NativeMethodInfoPtr_ExitMenu_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 101635, RefRangeEnd = 101638, XrefRangeStart = 101618, XrefRangeEnd = 101635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitSubmenu()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.NativeMethodInfoPtr_ExitSubmenu_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 101645, RefRangeEnd = 101649, XrefRangeStart = 101638, XrefRangeEnd = 101645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SelectObject(GameObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.NativeMethodInfoPtr_SelectObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 100878, RefRangeEnd = 100880, XrefRangeStart = 100878, XrefRangeEnd = 100880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISubmenuHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Stack<UISubmenuHandler.SubmenuActions> _submenuStack_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.NativeFieldInfoPtr__submenuStack_k__BackingField));
      return num == System.IntPtr.Zero ? (Stack<UISubmenuHandler.SubmenuActions>) null : Il2CppObjectPool.Get<Stack<UISubmenuHandler.SubmenuActions>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.NativeFieldInfoPtr__submenuStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class SubmenuActions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubmenuObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_DontHideParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_RunOnExit;
    private static readonly System.IntPtr NativeFieldInfoPtr_RunOnEnter;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubmenuButton;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SubmenuActions()
    {
      Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UISubmenuHandler>.NativeClassPtr, nameof (SubmenuActions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr);
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (SubmenuObject));
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SelectedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (SelectedItem));
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_DontHideParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (DontHideParent));
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (RunOnExit));
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (RunOnEnter));
      UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, nameof (SubmenuButton));
      UISubmenuHandler.SubmenuActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr, 100672503);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubmenuActions()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISubmenuHandler.SubmenuActions>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISubmenuHandler.SubmenuActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject SubmenuObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuObject));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Selectable SelectedItem
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SelectedItem));
        return num == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SelectedItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool DontHideParent
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_DontHideParent));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_DontHideParent)) = value;
      }
    }

    public unsafe UnityEvent RunOnExit
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnExit));
        return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnExit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityEvent RunOnEnter
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnEnter));
        return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_RunOnEnter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Button SubmenuButton
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuButton));
        return num == System.IntPtr.Zero ? (Button) null : Il2CppObjectPool.Get<Button>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenuHandler.SubmenuActions.NativeFieldInfoPtr_SubmenuButton), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
