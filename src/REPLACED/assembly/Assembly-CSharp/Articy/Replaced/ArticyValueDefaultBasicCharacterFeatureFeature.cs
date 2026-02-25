// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueDefaultBasicCharacterFeatureFeature
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
public class ArticyValueDefaultBasicCharacterFeatureFeature(IntPtr pointer) : 
  ArticyValue<DefaultBasicCharacterFeatureFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueDefaultBasicCharacterFeatureFeature()
  {
    Il2CppClassPointerStore<ArticyValueDefaultBasicCharacterFeatureFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueDefaultBasicCharacterFeatureFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueDefaultBasicCharacterFeatureFeature>.NativeClassPtr);
    ArticyValueDefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueDefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100677987);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 132827, RefRangeEnd = 132833, XrefRangeStart = 132824, XrefRangeEnd = 132827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueDefaultBasicCharacterFeatureFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueDefaultBasicCharacterFeatureFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueDefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
