// Decompiled with JetBrains decompiler
// Type: Cinemachine.NoiseSettingsPropertyAttribute
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public sealed class NoiseSettingsPropertyAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NoiseSettingsPropertyAttribute()
  {
    Il2CppClassPointerStore<NoiseSettingsPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (NoiseSettingsPropertyAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseSettingsPropertyAttribute>.NativeClassPtr);
    NoiseSettingsPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseSettingsPropertyAttribute>.NativeClassPtr, 100664046);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NoiseSettingsPropertyAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoiseSettingsPropertyAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NoiseSettingsPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
