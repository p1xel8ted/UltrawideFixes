// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.EnvironmentHazardTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class EnvironmentHazardTrack(IntPtr pointer) : TrackAsset(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnvironmentHazardTrack()
  {
    Il2CppClassPointerStore<EnvironmentHazardTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (EnvironmentHazardTrack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentHazardTrack>.NativeClassPtr);
    EnvironmentHazardTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardTrack>.NativeClassPtr, 100670780);
    EnvironmentHazardTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardTrack>.NativeClassPtr, 100670781);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88199, XrefRangeEnd = 88208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreateTrackMixer(
    PlayableGraph graph,
    GameObject go,
    int inputCount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &inputCount;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EnvironmentHazardTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88208, XrefRangeEnd = 88212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnvironmentHazardTrack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentHazardTrack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnvironmentHazardTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
