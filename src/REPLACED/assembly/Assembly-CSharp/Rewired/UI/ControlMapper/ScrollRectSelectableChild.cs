// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.ScrollRectSelectableChild
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
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class ScrollRectSelectableChild(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_useCustomEdgePadding;
  private static readonly IntPtr NativeFieldInfoPtr_customEdgePadding;
  private static readonly IntPtr NativeFieldInfoPtr_parentScrollRect;
  private static readonly IntPtr NativeFieldInfoPtr__selectable;
  private static readonly IntPtr NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScrollRectSelectableChild()
  {
    Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (ScrollRectSelectableChild));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr);
    ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, nameof (useCustomEdgePadding));
    ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, nameof (customEdgePadding));
    ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, nameof (parentScrollRect));
    ScrollRectSelectableChild.NativeFieldInfoPtr__selectable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, nameof (_selectable));
    ScrollRectSelectableChild.NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669937);
    ScrollRectSelectableChild.NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669938);
    ScrollRectSelectableChild.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669939);
    ScrollRectSelectableChild.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669940);
    ScrollRectSelectableChild.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669941);
    ScrollRectSelectableChild.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr, 100669942);
  }

  public unsafe RectTransform parentScrollRectContentTransform
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_parentScrollRectContentTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num3);
    }
  }

  public unsafe Selectable selectable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79414, XrefRangeEnd = 79417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_selectable_Private_get_Selectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num3);
    }
  }

  public unsafe RectTransform rectTransform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79417, XrefRangeEnd = 79419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_get_rectTransform_Private_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79419, XrefRangeEnd = 79433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79433, XrefRangeEnd = 79461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79461, XrefRangeEnd = 79462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScrollRectSelectableChild()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectSelectableChild>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScrollRectSelectableChild.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool useCustomEdgePadding
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_useCustomEdgePadding)) = value;
    }
  }

  public unsafe float customEdgePadding
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_customEdgePadding)) = value;
    }
  }

  public unsafe ScrollRect parentScrollRect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect));
      return num == IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr_parentScrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Selectable _selectable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr__selectable));
      return num == IntPtr.Zero ? (Selectable) null : Il2CppObjectPool.Get<Selectable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScrollRectSelectableChild.NativeFieldInfoPtr__selectable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
