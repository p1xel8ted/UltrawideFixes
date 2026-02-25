// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueDefaultSupportingCharacterTemplateTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Templates;
using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class ArticyValueDefaultSupportingCharacterTemplateTemplate(IntPtr pointer) : 
  ArticyValue<DefaultSupportingCharacterTemplateTemplate>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueDefaultSupportingCharacterTemplateTemplate()
  {
    Il2CppClassPointerStore<ArticyValueDefaultSupportingCharacterTemplateTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueDefaultSupportingCharacterTemplateTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueDefaultSupportingCharacterTemplateTemplate>.NativeClassPtr);
    ArticyValueDefaultSupportingCharacterTemplateTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueDefaultSupportingCharacterTemplateTemplate>.NativeClassPtr, 100677986);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132823, RefRangeEnd = 132824, XrefRangeStart = 132820, XrefRangeEnd = 132823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueDefaultSupportingCharacterTemplateTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueDefaultSupportingCharacterTemplateTemplate>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueDefaultSupportingCharacterTemplateTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
