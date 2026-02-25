// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueCollectedItemsAchievementTemplate
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
public class ArticyValueCollectedItemsAchievementTemplate(IntPtr pointer) : 
  ArticyValue<CollectedItemsAchievementTemplate>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueCollectedItemsAchievementTemplate()
  {
    Il2CppClassPointerStore<ArticyValueCollectedItemsAchievementTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueCollectedItemsAchievementTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueCollectedItemsAchievementTemplate>.NativeClassPtr);
    ArticyValueCollectedItemsAchievementTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueCollectedItemsAchievementTemplate>.NativeClassPtr, 100677983);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132810, RefRangeEnd = 132811, XrefRangeStart = 132807, XrefRangeEnd = 132810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueCollectedItemsAchievementTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueCollectedItemsAchievementTemplate>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueCollectedItemsAchievementTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
