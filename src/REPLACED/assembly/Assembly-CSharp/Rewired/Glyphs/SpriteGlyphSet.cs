// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.SpriteGlyphSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class SpriteGlyphSet(IntPtr pointer) : GlyphSet(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__glyphs;
  private static readonly IntPtr NativeMethodInfoPtr_get_glyphs_Public_get_List_1_Entry_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_glyphs_Public_set_Void_List_1_Entry_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_glyphCount_Public_Virtual_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Virtual_EntryBase_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpriteGlyphSet()
  {
    Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (SpriteGlyphSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr);
    SpriteGlyphSet.NativeFieldInfoPtr__glyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, nameof (_glyphs));
    SpriteGlyphSet.NativeMethodInfoPtr_get_glyphs_Public_get_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, 100668627);
    SpriteGlyphSet.NativeMethodInfoPtr_set_glyphs_Public_set_Void_List_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, 100668628);
    SpriteGlyphSet.NativeMethodInfoPtr_get_glyphCount_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, 100668629);
    SpriteGlyphSet.NativeMethodInfoPtr_GetEntry_Public_Virtual_EntryBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, 100668630);
    SpriteGlyphSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, 100668631);
  }

  public unsafe List<SpriteGlyphSet.Entry> glyphs
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteGlyphSet.NativeMethodInfoPtr_get_glyphs_Public_get_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<SpriteGlyphSet.Entry>) null : Il2CppObjectPool.Get<List<SpriteGlyphSet.Entry>>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteGlyphSet.NativeMethodInfoPtr_set_glyphs_Public_set_Void_List_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe int glyphCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69724, XrefRangeEnd = 69725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpriteGlyphSet.NativeMethodInfoPtr_get_glyphCount_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69725, XrefRangeEnd = 69729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe GlyphSet.EntryBase GetEntry(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpriteGlyphSet.NativeMethodInfoPtr_GetEntry_Public_Virtual_EntryBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GlyphSet.EntryBase) null : Il2CppObjectPool.Get<GlyphSet.EntryBase>(num3);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpriteGlyphSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteGlyphSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<SpriteGlyphSet.Entry> _glyphs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteGlyphSet.NativeFieldInfoPtr__glyphs));
      return num == IntPtr.Zero ? (List<SpriteGlyphSet.Entry>) null : Il2CppObjectPool.Get<List<SpriteGlyphSet.Entry>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteGlyphSet.NativeFieldInfoPtr__glyphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class Entry(IntPtr pointer) : GlyphSet.EntryBase<Sprite>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Entry()
    {
      Il2CppClassPointerStore<SpriteGlyphSet.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpriteGlyphSet>.NativeClassPtr, nameof (Entry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteGlyphSet.Entry>.NativeClassPtr);
      SpriteGlyphSet.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteGlyphSet.Entry>.NativeClassPtr, 100668632);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69721, XrefRangeEnd = 69724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Entry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteGlyphSet.Entry>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteGlyphSet.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
