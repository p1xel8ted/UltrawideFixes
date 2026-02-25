// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineImpulseChannelPropertyAttribute
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

public sealed class CinemachineImpulseChannelPropertyAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineImpulseChannelPropertyAttribute()
  {
    Il2CppClassPointerStore<CinemachineImpulseChannelPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineImpulseChannelPropertyAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineImpulseChannelPropertyAttribute>.NativeClassPtr);
    CinemachineImpulseChannelPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineImpulseChannelPropertyAttribute>.NativeClassPtr, 100664271);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineImpulseChannelPropertyAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineImpulseChannelPropertyAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineImpulseChannelPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
