// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.Localization.LocalizationTMPFontChange
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using RTLTMPro;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI.Localization;

public class LocalizationTMPFontChange(IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_fontIndex;
  private static readonly IntPtr NativeFieldInfoPtr_fontSizeChanges;
  private static readonly IntPtr NativeFieldInfoPtr_text;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly IntPtr NativeMethodInfoPtr_LocalizationTextAssign_Public_Void_Component_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalizationTMPFontChange()
  {
    Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI.Localization", nameof (LocalizationTMPFontChange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr);
    LocalizationTMPFontChange.NativeFieldInfoPtr_fontIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, nameof (fontIndex));
    LocalizationTMPFontChange.NativeFieldInfoPtr_fontSizeChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, nameof (fontSizeChanges));
    LocalizationTMPFontChange.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, nameof (text));
    LocalizationTMPFontChange.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, 100670737);
    LocalizationTMPFontChange.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, 100670738);
    LocalizationTMPFontChange.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, 100670739);
    LocalizationTMPFontChange.NativeMethodInfoPtr_LocalizationTextAssign_Public_Void_Component_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, 100670740);
    LocalizationTMPFontChange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr, 100670741);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87818, XrefRangeEnd = 87842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationTMPFontChange.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87842, XrefRangeEnd = 87854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationTMPFontChange.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87878, RefRangeEnd = 87879, XrefRangeStart = 87854, XrefRangeEnd = 87878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LanguageChanged(ArticyLanguage _old, ArticyLanguage newLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _old);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newLanguage);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationTMPFontChange.NativeMethodInfoPtr_LanguageChanged_Private_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87879, XrefRangeEnd = 87883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LocalizationTextAssign(Component component, string txt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) component);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(txt);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationTMPFontChange.NativeMethodInfoPtr_LocalizationTextAssign_Public_Void_Component_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizationTMPFontChange()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationTMPFontChange>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizationTMPFontChange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LocalizationFontIndex fontIndex
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_fontIndex));
      return num == IntPtr.Zero ? (LocalizationFontIndex) null : Il2CppObjectPool.Get<LocalizationFontIndex>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_fontIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, float> fontSizeChanges
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_fontSizeChanges));
      return num == IntPtr.Zero ? (Dictionary<string, float>) null : Il2CppObjectPool.Get<Dictionary<string, float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_fontSizeChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RTLTextMeshPro text
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_text));
      return num == IntPtr.Zero ? (RTLTextMeshPro) null : Il2CppObjectPool.Get<RTLTextMeshPro>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTMPFontChange.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
