// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueLore_ItemTemplate
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
public class ArticyValueLore_ItemTemplate(IntPtr pointer) : ArticyValue<Lore_ItemTemplate>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueLore_ItemTemplate()
  {
    Il2CppClassPointerStore<ArticyValueLore_ItemTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueLore_ItemTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueLore_ItemTemplate>.NativeClassPtr);
    ArticyValueLore_ItemTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueLore_ItemTemplate>.NativeClassPtr, 100677962);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 132717, RefRangeEnd = 132718, XrefRangeStart = 132714, XrefRangeEnd = 132717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueLore_ItemTemplate()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueLore_ItemTemplate>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueLore_ItemTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
