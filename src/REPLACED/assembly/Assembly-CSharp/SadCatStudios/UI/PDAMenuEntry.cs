// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.PDAMenuEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Articy.Unity;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class PDAMenuEntry(System.IntPtr pointer) : Selectable(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_orangeColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_blackColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryText;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_newEntryIcon;
  private static readonly System.IntPtr NativeFieldInfoPtr_newEntryIconInner;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryName;
  private static readonly System.IntPtr NativeFieldInfoPtr_entrySprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_entrySpriteMissing;
  private static readonly System.IntPtr NativeFieldInfoPtr_errorSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_SubmenuAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_background;
  private static readonly System.IntPtr NativeFieldInfoPtr_entryCharactersLength;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EntryName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CanEnterSubmenu_Private_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFromInventory_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateFromObjective_Public_Void_QuestProgress_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scroll_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAMenuEntry()
  {
    Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (PDAMenuEntry));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr);
    PDAMenuEntry.NativeFieldInfoPtr_orangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (orangeColor));
    PDAMenuEntry.NativeFieldInfoPtr_blackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (blackColor));
    PDAMenuEntry.NativeFieldInfoPtr_entryText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entryText));
    PDAMenuEntry.NativeFieldInfoPtr_entryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entryIcon));
    PDAMenuEntry.NativeFieldInfoPtr_newEntryIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (newEntryIcon));
    PDAMenuEntry.NativeFieldInfoPtr_newEntryIconInner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (newEntryIconInner));
    PDAMenuEntry.NativeFieldInfoPtr_entryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entryName));
    PDAMenuEntry.NativeFieldInfoPtr_entrySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entrySprite));
    PDAMenuEntry.NativeFieldInfoPtr_entrySpriteMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entrySpriteMissing));
    PDAMenuEntry.NativeFieldInfoPtr_errorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (errorSound));
    PDAMenuEntry.NativeFieldInfoPtr_scrollSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (scrollSound));
    PDAMenuEntry.NativeFieldInfoPtr_SubmenuAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (SubmenuAction));
    PDAMenuEntry.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (background));
    PDAMenuEntry.NativeFieldInfoPtr_entryCharactersLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (entryCharactersLength));
    PDAMenuEntry.NativeMethodInfoPtr_get_EntryName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672060);
    PDAMenuEntry.NativeMethodInfoPtr_get_CanEnterSubmenu_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672061);
    PDAMenuEntry.NativeMethodInfoPtr_UpdateFromInventory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672062);
    PDAMenuEntry.NativeMethodInfoPtr_UpdateFromObjective_Public_Void_QuestProgress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672063);
    PDAMenuEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672064);
    PDAMenuEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672065);
    PDAMenuEntry.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672066);
    PDAMenuEntry.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672067);
    PDAMenuEntry.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672068);
    PDAMenuEntry.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672069);
    PDAMenuEntry.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672070);
    PDAMenuEntry.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672071);
    PDAMenuEntry.NativeMethodInfoPtr_Scroll_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672072);
    PDAMenuEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, 100672073);
  }

  public unsafe string EntryName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 98052, RefRangeEnd = 98055, XrefRangeStart = 98046, XrefRangeEnd = 98052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_get_EntryName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe bool CanEnterSubmenu
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 98062, RefRangeEnd = 98064, XrefRangeStart = 98055, XrefRangeEnd = 98062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_get_CanEnterSubmenu_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 98089, RefRangeEnd = 98093, XrefRangeStart = 98064, XrefRangeEnd = 98089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateFromInventory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_UpdateFromInventory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 98100, RefRangeEnd = 98102, XrefRangeStart = 98093, XrefRangeEnd = 98100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateFromObjective(QuestProgress objective)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objective)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_UpdateFromObjective_Public_Void_QuestProgress_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98102, XrefRangeEnd = 98114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98114, XrefRangeEnd = 98115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerEnter(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98115, XrefRangeEnd = 98122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnMove(AxisEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_OnMove_Public_Virtual_Void_AxisEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98122, XrefRangeEnd = 98137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98137, XrefRangeEnd = 98144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98144, XrefRangeEnd = 98151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerDown(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAMenuEntry.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98151, XrefRangeEnd = 98159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSubmit(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98159, XrefRangeEnd = 98164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnCancel(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98164, XrefRangeEnd = 98167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Scroll(int titleCharactersCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &titleCharactersCount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr_Scroll_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98167, XrefRangeEnd = 98171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAMenuEntry()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Color orangeColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_orangeColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_orangeColor)) = value;
    }
  }

  public unsafe Color blackColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_blackColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_blackColor)) = value;
    }
  }

  public unsafe TMP_Text entryText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image entryIcon
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryIcon));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image newEntryIcon
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_newEntryIcon));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_newEntryIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image newEntryIconInner
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_newEntryIconInner));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_newEntryIconInner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string entryName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Sprite entrySprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entrySprite));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entrySprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite entrySpriteMissing
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entrySpriteMissing));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entrySpriteMissing), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference errorSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_errorSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_errorSound)) = value;
    }
  }

  public unsafe EventReference scrollSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_scrollSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_scrollSound)) = value;
    }
  }

  public unsafe PDAMenuEntry.SubmenuActions SubmenuAction
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_SubmenuAction));
      return num == System.IntPtr.Zero ? (PDAMenuEntry.SubmenuActions) null : Il2CppObjectPool.Get<PDAMenuEntry.SubmenuActions>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_SubmenuAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image background
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_background));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int entryCharactersLength
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryCharactersLength));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.NativeFieldInfoPtr_entryCharactersLength)) = value;
    }
  }

  [Serializable]
  public class SubmenuActions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SubmenuObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_SelectedItem;
    private static readonly System.IntPtr NativeFieldInfoPtr_ShowSeparators;
    private static readonly System.IntPtr NativeFieldInfoPtr_PdaEntryRef;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SubmenuActions()
    {
      Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PDAMenuEntry>.NativeClassPtr, nameof (SubmenuActions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr);
      PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SubmenuObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr, nameof (SubmenuObject));
      PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SelectedItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr, nameof (SelectedItem));
      PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_ShowSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr, nameof (ShowSeparators));
      PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_PdaEntryRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr, nameof (PdaEntryRef));
      PDAMenuEntry.SubmenuActions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr, 100672074);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SubmenuActions()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAMenuEntry.SubmenuActions>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PDAMenuEntry.SubmenuActions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe RectTransform SubmenuObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SubmenuObject));
        return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SubmenuObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Selectable SelectedItem
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SelectedItem));
        return num == System.IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_SelectedItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool ShowSeparators
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_ShowSeparators));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_ShowSeparators)) = value;
      }
    }

    public unsafe ArticyRef PdaEntryRef
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_PdaEntryRef));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAMenuEntry.SubmenuActions.NativeFieldInfoPtr_PdaEntryRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
