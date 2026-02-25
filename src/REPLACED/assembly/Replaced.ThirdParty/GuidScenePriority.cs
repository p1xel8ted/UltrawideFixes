// Decompiled with JetBrains decompiler
// Type: GuidScenePriority
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
public class GuidScenePriority(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GuidScenePriority()
  {
    Il2CppClassPointerStore<GuidScenePriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "", nameof (GuidScenePriority));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidScenePriority>.NativeClassPtr);
    GuidScenePriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidScenePriority>.NativeClassPtr, 100663341 /*0x0600002D*/);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GuidScenePriority()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidScenePriority>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidScenePriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
