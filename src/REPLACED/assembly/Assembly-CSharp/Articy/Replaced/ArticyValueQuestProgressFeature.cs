// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueQuestProgressFeature
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
public class ArticyValueQuestProgressFeature(IntPtr pointer) : ArticyValue<QuestProgressFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueQuestProgressFeature()
  {
    Il2CppClassPointerStore<ArticyValueQuestProgressFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueQuestProgressFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueQuestProgressFeature>.NativeClassPtr);
    ArticyValueQuestProgressFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueQuestProgressFeature>.NativeClassPtr, 100677981);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132802, RefRangeEnd = 132804, XrefRangeStart = 132799, XrefRangeEnd = 132802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueQuestProgressFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueQuestProgressFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueQuestProgressFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
