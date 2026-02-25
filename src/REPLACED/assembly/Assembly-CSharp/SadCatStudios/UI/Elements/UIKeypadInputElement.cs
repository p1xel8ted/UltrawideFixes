// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIKeypadInputElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIKeypadInputElement(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_textMesh;
  private static readonly IntPtr NativeFieldInfoPtr_shadowTextMesh;
  private static readonly IntPtr NativeFieldInfoPtr_emptySymbol;
  private static readonly IntPtr NativeFieldInfoPtr_offsetMaxEmpty;
  private static readonly IntPtr NativeFieldInfoPtr_offsetMaxFilled;
  private static readonly IntPtr NativeFieldInfoPtr_offsetMin;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TypeIn_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_TypeIn_Private_Void_String_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIKeypadInputElement()
  {
    Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIKeypadInputElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr);
    UIKeypadInputElement.NativeFieldInfoPtr_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (textMesh));
    UIKeypadInputElement.NativeFieldInfoPtr_shadowTextMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (shadowTextMesh));
    UIKeypadInputElement.NativeFieldInfoPtr_emptySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (emptySymbol));
    UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (offsetMaxEmpty));
    UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxFilled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (offsetMaxFilled));
    UIKeypadInputElement.NativeFieldInfoPtr_offsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, nameof (offsetMin));
    UIKeypadInputElement.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, 100672359);
    UIKeypadInputElement.NativeMethodInfoPtr_TypeIn_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, 100672360);
    UIKeypadInputElement.NativeMethodInfoPtr_TypeIn_Private_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, 100672361);
    UIKeypadInputElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr, 100672362);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100819, XrefRangeEnd = 100822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIKeypadInputElement.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100822, XrefRangeEnd = 100823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TypeIn(string symbol)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(symbol)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIKeypadInputElement.NativeMethodInfoPtr_TypeIn_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 100835, RefRangeEnd = 100840, XrefRangeStart = 100823, XrefRangeEnd = 100835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TypeIn(string symbol, bool empty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(symbol);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &empty;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIKeypadInputElement.NativeMethodInfoPtr_TypeIn_Private_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100840, XrefRangeEnd = 100841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIKeypadInputElement()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIKeypadInputElement>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIKeypadInputElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TextMeshProUGUI textMesh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_textMesh));
      return num == IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_textMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextMeshProUGUI shadowTextMesh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_shadowTextMesh));
      return num == IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_shadowTextMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringVariable emptySymbol
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_emptySymbol));
      return num == IntPtr.Zero ? (StringVariable) null : Il2CppObjectPool.Get<StringVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_emptySymbol), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 offsetMaxEmpty
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxEmpty));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxEmpty)) = value;
    }
  }

  public unsafe Vector2 offsetMaxFilled
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxFilled));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMaxFilled)) = value;
    }
  }

  public unsafe Vector2 offsetMin
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMin));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIKeypadInputElement.NativeFieldInfoPtr_offsetMin)) = value;
    }
  }
}
