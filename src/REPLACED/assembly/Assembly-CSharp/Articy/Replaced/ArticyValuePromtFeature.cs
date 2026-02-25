// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValuePromtFeature
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
public class ArticyValuePromtFeature(IntPtr pointer) : ArticyValue<PromtFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValuePromtFeature()
  {
    Il2CppClassPointerStore<ArticyValuePromtFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValuePromtFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValuePromtFeature>.NativeClassPtr);
    ArticyValuePromtFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValuePromtFeature>.NativeClassPtr, 100677978);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 132789, RefRangeEnd = 132792, XrefRangeStart = 132786, XrefRangeEnd = 132789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValuePromtFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValuePromtFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValuePromtFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
