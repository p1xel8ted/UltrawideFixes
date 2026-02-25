// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.ClipDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Animation;
using System;

#nullable disable
namespace SadCatStudios.Character;

[Serializable]
public class ClipDictionary(IntPtr pointer) : UnitySerializedDictionary<string, MeshClip>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClipDictionary()
  {
    Il2CppClassPointerStore<ClipDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (ClipDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipDictionary>.NativeClassPtr);
    ClipDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipDictionary>.NativeClassPtr, 100675258);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 116327, XrefRangeEnd = 116330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClipDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClipDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
