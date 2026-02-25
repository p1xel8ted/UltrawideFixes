// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.StunVariantsDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.FSM;
using System;

#nullable disable
namespace SadCatStudios.Combat;

[Serializable]
public class StunVariantsDictionary(IntPtr pointer) : UnitySerializedDictionary<AttackData, FSMGraph>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StunVariantsDictionary()
  {
    Il2CppClassPointerStore<StunVariantsDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (StunVariantsDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StunVariantsDictionary>.NativeClassPtr);
    StunVariantsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StunVariantsDictionary>.NativeClassPtr, 100677214);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128909, XrefRangeEnd = 128912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StunVariantsDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StunVariantsDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StunVariantsDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
