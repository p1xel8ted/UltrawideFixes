// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.FloatsOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.FSM;

[Serializable]
public class FloatsOverride(IntPtr pointer) : 
  UnitySerializedDictionary<FloatVariable, FloatReference>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FloatsOverride()
  {
    Il2CppClassPointerStore<FloatsOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (FloatsOverride));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatsOverride>.NativeClassPtr);
    FloatsOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatsOverride>.NativeClassPtr, 100673206);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 106992, XrefRangeEnd = 106995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatsOverride()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatsOverride>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatsOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
