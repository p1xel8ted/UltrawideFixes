// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.VFXDictionary
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Effects;

[Serializable]
public class VFXDictionary(IntPtr pointer) : 
  UnitySerializedDictionary<PhysicsMaterial, AssetReferenceGameObject>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VFXDictionary()
  {
    Il2CppClassPointerStore<VFXDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (VFXDictionary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXDictionary>.NativeClassPtr);
    VFXDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXDictionary>.NativeClassPtr, 100675728 /*0x06003090*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119118, XrefRangeEnd = 119121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VFXDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXDictionary>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VFXDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
