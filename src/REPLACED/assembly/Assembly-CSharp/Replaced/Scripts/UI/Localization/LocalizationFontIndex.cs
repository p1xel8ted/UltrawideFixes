// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.Localization.LocalizationFontIndex
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace Replaced.Scripts.UI.Localization;

public class LocalizationFontIndex(IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_LocaFonts;
  private static readonly IntPtr NativeFieldInfoPtr_SimplifiedFonts;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalizationFontIndex()
  {
    Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI.Localization", nameof (LocalizationFontIndex));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr);
    LocalizationFontIndex.NativeFieldInfoPtr_LocaFonts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr, nameof (LocaFonts));
    LocalizationFontIndex.NativeFieldInfoPtr_SimplifiedFonts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr, nameof (SimplifiedFonts));
    LocalizationFontIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr, 100670736);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizationFontIndex()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationFontIndex>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationFontIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<string, TMP_FontAsset> LocaFonts
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationFontIndex.NativeFieldInfoPtr_LocaFonts));
      return num == IntPtr.Zero ? (Dictionary<string, TMP_FontAsset>) null : Il2CppObjectPool.Get<Dictionary<string, TMP_FontAsset>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationFontIndex.NativeFieldInfoPtr_LocaFonts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, TMP_FontAsset> SimplifiedFonts
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationFontIndex.NativeFieldInfoPtr_SimplifiedFonts));
      return num == IntPtr.Zero ? (Dictionary<string, TMP_FontAsset>) null : Il2CppObjectPool.Get<Dictionary<string, TMP_FontAsset>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationFontIndex.NativeFieldInfoPtr_SimplifiedFonts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
