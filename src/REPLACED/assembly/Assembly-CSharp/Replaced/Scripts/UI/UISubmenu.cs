// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UISubmenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI;

public class UISubmenu(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_menu;
  private static readonly IntPtr NativeFieldInfoPtr_actions;
  private static readonly IntPtr NativeMethodInfoPtr_get_Menu_Public_get_UISubmenuHandler_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Actions_Public_get_SubmenuActions_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Actions_Public_set_Void_SubmenuActions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Enter_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISubmenu()
  {
    Il2CppClassPointerStore<UISubmenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UISubmenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr);
    UISubmenu.NativeFieldInfoPtr_menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, nameof (menu));
    UISubmenu.NativeFieldInfoPtr_actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, nameof (actions));
    UISubmenu.NativeMethodInfoPtr_get_Menu_Public_get_UISubmenuHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670729);
    UISubmenu.NativeMethodInfoPtr_get_Actions_Public_get_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670730);
    UISubmenu.NativeMethodInfoPtr_set_Actions_Public_set_Void_SubmenuActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670731);
    UISubmenu.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670732);
    UISubmenu.NativeMethodInfoPtr_Enter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670733);
    UISubmenu.NativeMethodInfoPtr_Exit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670734);
    UISubmenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr, 100670735);
  }

  public unsafe UISubmenuHandler Menu
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_get_Menu_Public_get_UISubmenuHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (UISubmenuHandler) null : Il2CppObjectPool.Get<UISubmenuHandler>(num3);
    }
  }

  public unsafe UISubmenuHandler.SubmenuActions Actions
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_get_Actions_Public_get_SubmenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (UISubmenuHandler.SubmenuActions) null : Il2CppObjectPool.Get<UISubmenuHandler.SubmenuActions>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_set_Actions_Public_set_Void_SubmenuActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87807, XrefRangeEnd = 87810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 87811, RefRangeEnd = 87815, XrefRangeStart = 87810, XrefRangeEnd = 87811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_Enter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87817, RefRangeEnd = 87818, XrefRangeStart = 87815, XrefRangeEnd = 87817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Exit()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr_Exit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISubmenu()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISubmenu>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubmenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UISubmenuHandler menu
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenu.NativeFieldInfoPtr_menu));
      return num == IntPtr.Zero ? (UISubmenuHandler) null : Il2CppObjectPool.Get<UISubmenuHandler>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenu.NativeFieldInfoPtr_menu), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UISubmenuHandler.SubmenuActions actions
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubmenu.NativeFieldInfoPtr_actions));
      return num == IntPtr.Zero ? (UISubmenuHandler.SubmenuActions) null : Il2CppObjectPool.Get<UISubmenuHandler.SubmenuActions>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubmenu.NativeFieldInfoPtr_actions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
