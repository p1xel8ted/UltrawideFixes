// Decompiled with JetBrains decompiler
// Type: GameSets.AssetsSet
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace GameSets;

public class AssetsSet(IntPtr pointer) : RuntimeSet<AddressableVariable>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AssetsSet()
  {
    Il2CppClassPointerStore<AssetsSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameSets", nameof (AssetsSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetsSet>.NativeClassPtr);
    AssetsSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetsSet>.NativeClassPtr, 100663733);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 363994, XrefRangeEnd = 363997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AssetsSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetsSet>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AssetsSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
