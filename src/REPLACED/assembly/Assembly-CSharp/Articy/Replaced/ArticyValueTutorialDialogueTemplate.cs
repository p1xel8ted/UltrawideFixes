// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueTutorialDialogueTemplate
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
public class ArticyValueTutorialDialogueTemplate(IntPtr pointer) : 
  ArticyValue<TutorialDialogueTemplate>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueTutorialDialogueTemplate()
  {
    Il2CppClassPointerStore<ArticyValueTutorialDialogueTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueTutorialDialogueTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueTutorialDialogueTemplate>.NativeClassPtr);
    ArticyValueTutorialDialogueTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueTutorialDialogueTemplate>.NativeClassPtr, 100677955);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132693, RefRangeEnd = 132694, XrefRangeStart = 132690, XrefRangeEnd = 132693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueTutorialDialogueTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueTutorialDialogueTemplate>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueTutorialDialogueTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
