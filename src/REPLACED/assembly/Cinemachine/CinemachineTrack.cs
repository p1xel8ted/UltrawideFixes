// Decompiled with JetBrains decompiler
// Type: CinemachineTrack
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
[Serializable]
public class CinemachineTrack(IntPtr pointer) : TrackAsset(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTrack()
  {
    Il2CppClassPointerStore<CinemachineTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineTrack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTrack>.NativeClassPtr);
    CinemachineTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrack>.NativeClassPtr, 100663317 /*0x06000015*/);
    CinemachineTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTrack>.NativeClassPtr, 100663318 /*0x06000016*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936740, XrefRangeEnd = 936752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CinemachineTrack.NativeMethodInfoPtr_CreateTrackMixer_Public_Virtual_Playable_PlayableGraph_GameObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936752, XrefRangeEnd = 936756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTrack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTrack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
