// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.AttackWeigths
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Character;
using System;

#nullable disable
namespace SadCatStudios.AI;

[Serializable]
public class AttackWeigths(IntPtr pointer) : 
  UnitySerializedDictionary<CharacterAIController.AIDecision, AttackWeight>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackWeigths()
  {
    Il2CppClassPointerStore<AttackWeigths>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (AttackWeigths));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackWeigths>.NativeClassPtr);
    AttackWeigths.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeigths>.NativeClassPtr, 100677864);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132233, XrefRangeEnd = 132236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackWeigths()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackWeigths>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeigths.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
