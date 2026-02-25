// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphOrTextBase`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

public class GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>(System.IntPtr pointer) : 
  GlyphOrTextBase(pointer)
  where TGlyphComponent : Behaviour
  where TGlyphGraphic : class
  where TTextComponent : Behaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr__textComponent;
  private static readonly System.IntPtr NativeFieldInfoPtr__glyphComponent;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_textComponent_Public_get_TTextComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_textComponent_Public_set_Void_TTextComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphComponent_Public_get_TGlyphComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphComponent_Public_set_Void_TGlyphComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphGraphic_Protected_Abstract_Virtual_New_get_TGlyphGraphic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphGraphic_Protected_Abstract_Virtual_New_set_Void_TGlyphGraphic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowText_Public_Virtual_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyph_Public_Virtual_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_TGlyphGraphic_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Protected_Virtual_Void_TypeFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static GlyphOrTextBase()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", "GlyphOrTextBase`3"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[3]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGlyphComponent>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGlyphGraphic>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTextComponent>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__textComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, nameof (_textComponent));
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__glyphComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, nameof (_glyphComponent));
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_textComponent_Public_get_TTextComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668567);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TTextComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668568);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_glyphComponent_Public_get_TGlyphComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668569);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_glyphComponent_Public_set_Void_TGlyphComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668570);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_glyphGraphic_Protected_Abstract_Virtual_New_get_TGlyphGraphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668571);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_glyphGraphic_Protected_Abstract_Virtual_New_set_Void_TGlyphGraphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668572);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowText_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668573);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668574);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_TGlyphGraphic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668575);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_Hide_Protected_Virtual_Void_TypeFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668576);
    GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr, 100668577);
  }

  public unsafe TTextComponent textComponent
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_textComponent_Public_get_TTextComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<TTextComponent>(num2, false, true);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      TTextComponent& local1;
      if (!typeof (TTextComponent).IsValueType)
      {
        __Boxed<TTextComponent> local2 = (object) value;
        local1 = local2 is string ? (TTextComponent&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TTextComponent&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_textComponent_Public_set_Void_TTextComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe TGlyphComponent glyphComponent
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_glyphComponent_Public_get_TGlyphComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<TGlyphComponent>(num2, false, true);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      TGlyphComponent& local1;
      if (!typeof (TGlyphComponent).IsValueType)
      {
        __Boxed<TGlyphComponent> local2 = (object) value;
        local1 = local2 is string ? (TGlyphComponent&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TGlyphComponent&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_glyphComponent_Public_set_Void_TGlyphComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe TGlyphGraphic glyphGraphic
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_get_glyphGraphic_Protected_Abstract_Virtual_New_get_TGlyphGraphic_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<TGlyphGraphic>(num2, false, true);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      TGlyphGraphic& local1;
      if (!typeof (TGlyphGraphic).IsValueType)
      {
        __Boxed<TGlyphGraphic> local2 = (object) value;
        local1 = local2 is string ? (TGlyphGraphic&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TGlyphGraphic&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref value;
      *numPtr2 = (System.IntPtr) ref local1;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_set_glyphGraphic_Protected_Abstract_Virtual_New_set_Void_TGlyphGraphic_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69190, XrefRangeEnd = 69203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ShowText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowText_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69203, XrefRangeEnd = 69222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ShowGlyph(Il2CppSystem.Object glyph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyph)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69222, XrefRangeEnd = 69234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ShowGlyph(TGlyphGraphic glyph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    // ISSUE: variable of a reference type
    TGlyphGraphic& local1;
    if (!typeof (TGlyphGraphic).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<TGlyphGraphic> local2 = (object) glyph;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (TGlyphGraphic&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TGlyphGraphic&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref glyph;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_TGlyphGraphic_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69234, XrefRangeEnd = 69261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Hide(GlyphOrTextBase.TypeFlags flags)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flags
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr_Hide_Protected_Virtual_Void_TypeFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlyphOrTextBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TTextComponent _textComponent
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<TTextComponent>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__textComponent), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__textComponent);
      System.Type type = typeof (TTextComponent);
      if (!type.IsValueType)
      {
        if (!string.Equals(type.FullName, "System.String"))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
          if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
          {
            System.IntPtr num2 = ptr;
            System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
            int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
            __memcpy(num1, num3, num4);
          }
          else
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
        }
        else
        {
          System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
        }
      }
      else
      {
        TTextComponent textComponent = value;
        *(TTextComponent*) num1 = textComponent;
      }
    }
  }

  public unsafe TGlyphComponent _glyphComponent
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<TGlyphComponent>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__glyphComponent), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlyphOrTextBase<TGlyphComponent, TGlyphGraphic, TTextComponent>.NativeFieldInfoPtr__glyphComponent);
      System.Type type = typeof (TGlyphComponent);
      if (!type.IsValueType)
      {
        if (!string.Equals(type.FullName, "System.String"))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
          if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
          {
            System.IntPtr num2 = ptr;
            System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
            int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
            __memcpy(num1, num3, num4);
          }
          else
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
        }
        else
        {
          System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
        }
      }
      else
      {
        TGlyphComponent glyphComponent = value;
        *(TGlyphComponent*) num1 = glyphComponent;
      }
    }
  }
}
