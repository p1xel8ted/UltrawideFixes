// Decompiled with JetBrains decompiler
// Type: AssetLabelReferenceNameRestriction
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
public class AssetLabelReferenceNameRestriction(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_StartsWith;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AssetLabelReferenceNameRestriction()
  {
    Il2CppClassPointerStore<AssetLabelReferenceNameRestriction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (AssetLabelReferenceNameRestriction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetLabelReferenceNameRestriction>.NativeClassPtr);
    AssetLabelReferenceNameRestriction.NativeFieldInfoPtr_StartsWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetLabelReferenceNameRestriction>.NativeClassPtr, nameof (StartsWith));
    AssetLabelReferenceNameRestriction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetLabelReferenceNameRestriction>.NativeClassPtr, 100663520 /*0x060000E0*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AssetLabelReferenceNameRestriction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetLabelReferenceNameRestriction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AssetLabelReferenceNameRestriction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string StartsWith
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetLabelReferenceNameRestriction.NativeFieldInfoPtr_StartsWith)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetLabelReferenceNameRestriction.NativeFieldInfoPtr_StartsWith), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
