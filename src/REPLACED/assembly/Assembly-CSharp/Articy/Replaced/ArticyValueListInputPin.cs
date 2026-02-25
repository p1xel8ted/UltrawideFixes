// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueListInputPin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class ArticyValueListInputPin(IntPtr pointer) : ArticyValue<List<InputPin>>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueListInputPin()
  {
    Il2CppClassPointerStore<ArticyValueListInputPin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueListInputPin));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueListInputPin>.NativeClassPtr);
    ArticyValueListInputPin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueListInputPin>.NativeClassPtr, 100678004);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132885, XrefRangeEnd = 132888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueListInputPin()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueListInputPin>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueListInputPin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
