// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.PDAPlayerButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class PDAPlayerButton(IntPtr pointer) : Selectable(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_iconImage;
  private static readonly IntPtr NativeFieldInfoPtr_player;
  private static readonly IntPtr NativeFieldInfoPtr_onClick;
  private static readonly IntPtr NativeFieldInfoPtr_orangeColor;
  private static readonly IntPtr NativeFieldInfoPtr_blackColor;
  private static readonly IntPtr NativeFieldInfoPtr_background;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAPlayerButton()
  {
    Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (PDAPlayerButton));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr);
    PDAPlayerButton.NativeFieldInfoPtr_iconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (iconImage));
    PDAPlayerButton.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (player));
    PDAPlayerButton.NativeFieldInfoPtr_onClick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (onClick));
    PDAPlayerButton.NativeFieldInfoPtr_orangeColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (orangeColor));
    PDAPlayerButton.NativeFieldInfoPtr_blackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (blackColor));
    PDAPlayerButton.NativeFieldInfoPtr_background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, nameof (background));
    PDAPlayerButton.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672119);
    PDAPlayerButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672120);
    PDAPlayerButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672121);
    PDAPlayerButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672122);
    PDAPlayerButton.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672123);
    PDAPlayerButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672124);
    PDAPlayerButton.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672125);
    PDAPlayerButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr, 100672126);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98398, XrefRangeEnd = 98406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAPlayerButton.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerEnter(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAPlayerButton.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98406, XrefRangeEnd = 98408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAPlayerButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98408, XrefRangeEnd = 98410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeselect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAPlayerButton.NativeMethodInfoPtr_OnDeselect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98410, XrefRangeEnd = 98412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPointerDown(PointerEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAPlayerButton.NativeMethodInfoPtr_OnPointerDown_Public_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98412, XrefRangeEnd = 98414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSubmit(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAPlayerButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98414, XrefRangeEnd = 98420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnCancel(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAPlayerButton.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98420, XrefRangeEnd = 98424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAPlayerButton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAPlayerButton>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAPlayerButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Image iconImage
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_iconImage));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_iconImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PDAMusicPlayer player
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_player));
      return num == IntPtr.Zero ? (PDAMusicPlayer) null : Il2CppObjectPool.Get<PDAMusicPlayer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onClick
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_onClick));
      return num == IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_onClick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color orangeColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_orangeColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_orangeColor)) = value;
    }
  }

  public unsafe Color blackColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_blackColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_blackColor)) = value;
    }
  }

  public unsafe Image background
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_background));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAPlayerButton.NativeFieldInfoPtr_background), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
