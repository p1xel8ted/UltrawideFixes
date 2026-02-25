// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachinePixelPerfect
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

public class CinemachinePixelPerfect(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachinePixelPerfect()
  {
    Il2CppClassPointerStore<CinemachinePixelPerfect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachinePixelPerfect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachinePixelPerfect>.NativeClassPtr);
    CinemachinePixelPerfect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachinePixelPerfect>.NativeClassPtr, 100663585);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachinePixelPerfect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachinePixelPerfect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachinePixelPerfect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
