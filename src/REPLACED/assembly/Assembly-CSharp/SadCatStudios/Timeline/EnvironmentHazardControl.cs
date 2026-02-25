// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.EnvironmentHazardControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class EnvironmentHazardControl(IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnvironmentHazardControl()
  {
    Il2CppClassPointerStore<EnvironmentHazardControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (EnvironmentHazardControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentHazardControl>.NativeClassPtr);
    EnvironmentHazardControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardControl>.NativeClassPtr, 100670773);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnvironmentHazardControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentHazardControl>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnvironmentHazardControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
