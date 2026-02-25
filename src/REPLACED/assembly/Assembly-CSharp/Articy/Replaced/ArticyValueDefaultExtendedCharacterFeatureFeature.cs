// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueDefaultExtendedCharacterFeatureFeature
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
public class ArticyValueDefaultExtendedCharacterFeatureFeature(IntPtr pointer) : 
  ArticyValue<DefaultExtendedCharacterFeatureFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueDefaultExtendedCharacterFeatureFeature()
  {
    Il2CppClassPointerStore<ArticyValueDefaultExtendedCharacterFeatureFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueDefaultExtendedCharacterFeatureFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueDefaultExtendedCharacterFeatureFeature>.NativeClassPtr);
    ArticyValueDefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueDefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100677990);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132839, XrefRangeEnd = 132842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueDefaultExtendedCharacterFeatureFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueDefaultExtendedCharacterFeatureFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueDefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
