// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphOrTextBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

public class GlyphOrTextBase(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_textString_Protected_Abstract_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_textString_Protected_Abstract_Virtual_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowText_Public_Abstract_Virtual_New_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyph_Public_Abstract_Virtual_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Protected_Abstract_Virtual_New_Void_TypeFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static GlyphOrTextBase()
  {
    Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (GlyphOrTextBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr);
    GlyphOrTextBase.NativeMethodInfoPtr_get_textString_Protected_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668560);
    GlyphOrTextBase.NativeMethodInfoPtr_set_textString_Protected_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668561);
    GlyphOrTextBase.NativeMethodInfoPtr_ShowText_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668562);
    GlyphOrTextBase.NativeMethodInfoPtr_ShowGlyph_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668563);
    GlyphOrTextBase.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668564);
    GlyphOrTextBase.NativeMethodInfoPtr_Hide_Protected_Abstract_Virtual_New_Void_TypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668565);
    GlyphOrTextBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr, 100668566);
  }

  public virtual unsafe string textString
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_get_textString_Protected_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_set_textString_Protected_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void ShowText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_ShowText_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ShowGlyph(Il2CppSystem.Object glyph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyph)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_ShowGlyph_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Hide(GlyphOrTextBase.TypeFlags flags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase.NativeMethodInfoPtr_Hide_Protected_Abstract_Virtual_New_Void_TypeFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlyphOrTextBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphOrTextBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [Flags]
  public enum TypeFlags
  {
    None = 0,
    Glyph = 1,
    Text = 2,
    All = -1, // 0xFFFFFFFF
  }
}
