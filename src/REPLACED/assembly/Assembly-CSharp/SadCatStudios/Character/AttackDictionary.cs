// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.AttackDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Combat;
using System;

#nullable disable
namespace SadCatStudios.Character;

[Serializable]
public class AttackDictionary(IntPtr pointer) : 
  UnitySerializedDictionary<CharacterAIController.AIDecision, AttackData>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackDictionary()
  {
    Il2CppClassPointerStore<AttackDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (AttackDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackDictionary>.NativeClassPtr);
    AttackDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackDictionary>.NativeClassPtr, 100674725);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113019, XrefRangeEnd = 113022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
