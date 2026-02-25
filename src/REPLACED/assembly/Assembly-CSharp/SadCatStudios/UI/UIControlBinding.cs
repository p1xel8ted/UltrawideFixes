// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIControlBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired;
using RTLTMPro;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UIControlBinding(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ActionName;
  private static readonly IntPtr NativeFieldInfoPtr_KeyName;
  private static readonly IntPtr NativeFieldInfoPtr_Button;
  private static readonly IntPtr NativeFieldInfoPtr_CategoryId;
  private static readonly IntPtr NativeFieldInfoPtr_ActionId;
  private static readonly IntPtr NativeFieldInfoPtr_IsNegative;
  private static readonly IntPtr NativeFieldInfoPtr_ElementMap;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIControlBinding()
  {
    Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIControlBinding));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr);
    UIControlBinding.NativeFieldInfoPtr_ActionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (ActionName));
    UIControlBinding.NativeFieldInfoPtr_KeyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (KeyName));
    UIControlBinding.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (Button));
    UIControlBinding.NativeFieldInfoPtr_CategoryId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (CategoryId));
    UIControlBinding.NativeFieldInfoPtr_ActionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (ActionId));
    UIControlBinding.NativeFieldInfoPtr_IsNegative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (IsNegative));
    UIControlBinding.NativeFieldInfoPtr_ElementMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, nameof (ElementMap));
    UIControlBinding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr, 100671991);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIControlBinding()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControlBinding>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControlBinding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe RTLTextMeshPro ActionName
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ActionName));
      return num == IntPtr.Zero ? (RTLTextMeshPro) null : Il2CppObjectPool.Get<RTLTextMeshPro>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ActionName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text KeyName
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_KeyName));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_KeyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEngine.UI.Button Button
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_Button));
      return num == IntPtr.Zero ? (UnityEngine.UI.Button) null : Il2CppObjectPool.Get<UnityEngine.UI.Button>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int CategoryId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_CategoryId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_CategoryId)) = value;
    }
  }

  public unsafe int ActionId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ActionId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ActionId)) = value;
    }
  }

  public unsafe bool IsNegative
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_IsNegative));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_IsNegative)) = value;
    }
  }

  public unsafe ActionElementMap ElementMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ElementMap));
      return num == IntPtr.Zero ? (ActionElementMap) null : Il2CppObjectPool.Get<ActionElementMap>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControlBinding.NativeFieldInfoPtr_ElementMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
