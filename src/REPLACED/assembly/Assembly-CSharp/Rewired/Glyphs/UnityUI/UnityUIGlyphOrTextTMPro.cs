// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIGlyphOrTextTMPro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIGlyphOrTextTMPro(IntPtr pointer) : GlyphOrTextBase<Image, Sprite, TMP_Text>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_textString_Protected_Virtual_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_textString_Protected_Virtual_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_glyphGraphic_Protected_Virtual_get_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_glyphGraphic_Protected_Virtual_set_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnityUIGlyphOrTextTMPro()
  {
    Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIGlyphOrTextTMPro));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr);
    UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_get_textString_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr, 100668652);
    UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_set_textString_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr, 100668653);
    UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_get_glyphGraphic_Protected_Virtual_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr, 100668654);
    UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_set_glyphGraphic_Protected_Virtual_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr, 100668655);
    UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr, 100668656);
  }

  public override unsafe string textString
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69894, XrefRangeEnd = 69900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_get_textString_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69900, XrefRangeEnd = 69905 /*0x011111*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_set_textString_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe Sprite glyphGraphic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69905 /*0x011111*/, XrefRangeEnd = 69910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_get_glyphGraphic_Protected_Virtual_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69910, XrefRangeEnd = 69916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr_set_glyphGraphic_Protected_Virtual_set_Void_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69916, XrefRangeEnd = 69919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIGlyphOrTextTMPro()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIGlyphOrTextTMPro>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIGlyphOrTextTMPro.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
