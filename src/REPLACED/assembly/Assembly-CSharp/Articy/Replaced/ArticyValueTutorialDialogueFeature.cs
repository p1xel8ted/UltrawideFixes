// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueTutorialDialogueFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class ArticyValueTutorialDialogueFeature(IntPtr pointer) : 
  ArticyValue<TutorialDialogueFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueTutorialDialogueFeature()
  {
    Il2CppClassPointerStore<ArticyValueTutorialDialogueFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueTutorialDialogueFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueTutorialDialogueFeature>.NativeClassPtr);
    ArticyValueTutorialDialogueFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueTutorialDialogueFeature>.NativeClassPtr, 100677956);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132697, RefRangeEnd = 132699, XrefRangeStart = 132694, XrefRangeEnd = 132697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueTutorialDialogueFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueTutorialDialogueFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueTutorialDialogueFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
