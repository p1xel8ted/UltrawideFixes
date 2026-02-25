// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.DecisionDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.FSM;
using System;

#nullable disable
namespace SadCatStudios.Character;

[Serializable]
public class DecisionDictionary(IntPtr pointer) : 
  UnitySerializedDictionary<CharacterAIController.AIDecision, FSMGraph>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DecisionDictionary()
  {
    Il2CppClassPointerStore<DecisionDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (DecisionDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecisionDictionary>.NativeClassPtr);
    DecisionDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecisionDictionary>.NativeClassPtr, 100674726);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113022, XrefRangeEnd = 113025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecisionDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecisionDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecisionDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
