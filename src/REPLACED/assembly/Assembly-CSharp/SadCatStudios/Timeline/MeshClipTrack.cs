// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.MeshClipTrack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class MeshClipTrack(IntPtr pointer) : TrackAsset(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshClipTrack()
  {
    Il2CppClassPointerStore<MeshClipTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (MeshClipTrack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipTrack>.NativeClassPtr);
    MeshClipTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipTrack>.NativeClassPtr, 100670786);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88238, XrefRangeEnd = 88242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipTrack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipTrack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClipTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
