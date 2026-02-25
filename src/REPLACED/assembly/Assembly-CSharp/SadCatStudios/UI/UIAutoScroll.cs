// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIAutoScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class UIAutoScroll(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_scrollSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_templateViewportTransform;
  private static readonly IntPtr NativeFieldInfoPtr_contentRectTransform;
  private static readonly IntPtr NativeFieldInfoPtr_dropdown;
  private static readonly IntPtr NativeFieldInfoPtr_templateScrollRect;
  private static readonly IntPtr NativeFieldInfoPtr_selectedRectTransform;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIAutoScroll()
  {
    Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIAutoScroll));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr);
    UIAutoScroll.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (scrollSpeed));
    UIAutoScroll.NativeFieldInfoPtr_templateViewportTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (templateViewportTransform));
    UIAutoScroll.NativeFieldInfoPtr_contentRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (contentRectTransform));
    UIAutoScroll.NativeFieldInfoPtr_dropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (dropdown));
    UIAutoScroll.NativeFieldInfoPtr_templateScrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (templateScrollRect));
    UIAutoScroll.NativeFieldInfoPtr_selectedRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, nameof (selectedRectTransform));
    UIAutoScroll.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, 100672146);
    UIAutoScroll.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, 100672147);
    UIAutoScroll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr, 100672148);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98570, XrefRangeEnd = 98573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIAutoScroll.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98573, XrefRangeEnd = 98606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIAutoScroll.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98606, XrefRangeEnd = 98607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIAutoScroll()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIAutoScroll>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIAutoScroll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float scrollSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_scrollSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_scrollSpeed)) = value;
    }
  }

  public unsafe RectTransform templateViewportTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_templateViewportTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_templateViewportTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform contentRectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_contentRectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_contentRectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Dropdown dropdown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_dropdown));
      return num == IntPtr.Zero ? (TMP_Dropdown) null : Il2CppObjectPool.Get<TMP_Dropdown>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_dropdown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScrollRect templateScrollRect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_templateScrollRect));
      return num == IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_templateScrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform selectedRectTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_selectedRectTransform));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIAutoScroll.NativeFieldInfoPtr_selectedRectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
