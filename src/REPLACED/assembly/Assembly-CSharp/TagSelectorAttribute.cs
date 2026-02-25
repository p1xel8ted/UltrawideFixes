// Decompiled with JetBrains decompiler
// Type: TagSelectorAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class TagSelectorAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_UseDefaultTagFieldDrawer;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TagSelectorAttribute()
  {
    Il2CppClassPointerStore<TagSelectorAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (TagSelectorAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TagSelectorAttribute>.NativeClassPtr);
    TagSelectorAttribute.NativeFieldInfoPtr_UseDefaultTagFieldDrawer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TagSelectorAttribute>.NativeClassPtr, nameof (UseDefaultTagFieldDrawer));
    TagSelectorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TagSelectorAttribute>.NativeClassPtr, 100663521 /*0x060000E1*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TagSelectorAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TagSelectorAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TagSelectorAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool UseDefaultTagFieldDrawer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagSelectorAttribute.NativeFieldInfoPtr_UseDefaultTagFieldDrawer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TagSelectorAttribute.NativeFieldInfoPtr_UseDefaultTagFieldDrawer)) = value;
    }
  }
}
