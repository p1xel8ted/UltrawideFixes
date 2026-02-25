// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValuePDAEntryMusicFeature
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
public class ArticyValuePDAEntryMusicFeature(IntPtr pointer) : ArticyValue<PDAEntryMusicFeature>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValuePDAEntryMusicFeature()
  {
    Il2CppClassPointerStore<ArticyValuePDAEntryMusicFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValuePDAEntryMusicFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValuePDAEntryMusicFeature>.NativeClassPtr);
    ArticyValuePDAEntryMusicFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValuePDAEntryMusicFeature>.NativeClassPtr, 100677996);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132862, RefRangeEnd = 132864 /*0x020700*/, XrefRangeStart = 132859, XrefRangeEnd = 132862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValuePDAEntryMusicFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValuePDAEntryMusicFeature>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValuePDAEntryMusicFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
