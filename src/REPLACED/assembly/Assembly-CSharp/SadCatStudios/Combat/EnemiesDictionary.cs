// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.EnemiesDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

[Serializable]
public class EnemiesDictionary(IntPtr pointer) : 
  UnitySerializedDictionary<EnemyCombatController, bool>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnemiesDictionary()
  {
    Il2CppClassPointerStore<EnemiesDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (EnemiesDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemiesDictionary>.NativeClassPtr);
    EnemiesDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemiesDictionary>.NativeClassPtr, 100676961);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127289, XrefRangeEnd = 127292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnemiesDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemiesDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemiesDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
