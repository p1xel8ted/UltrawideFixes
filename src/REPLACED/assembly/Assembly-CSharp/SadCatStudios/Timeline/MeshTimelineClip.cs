// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.MeshTimelineClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class MeshTimelineClip(IntPtr pointer) : PlayableAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_template;
  private static readonly IntPtr NativeMethodInfoPtr_get_Template_Public_get_MeshClipControl_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshTimelineClip()
  {
    Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (MeshTimelineClip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr);
    MeshTimelineClip.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, nameof (template));
    MeshTimelineClip.NativeMethodInfoPtr_get_Template_Public_get_MeshClipControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, 100670787);
    MeshTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, 100670788);
    MeshTimelineClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, 100670789);
    MeshTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, 100670790);
    MeshTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr, 100670791);
  }

  public unsafe MeshClipControl Template
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshTimelineClip.NativeMethodInfoPtr_get_Template_Public_get_MeshClipControl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClipControl) null : Il2CppObjectPool.Get<MeshClipControl>(num3);
    }
  }

  public virtual unsafe ClipCaps clipCaps
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipCaps*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public override unsafe double duration
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88242, XrefRangeEnd = 88247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshTimelineClip.NativeMethodInfoPtr_get_duration_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88247, XrefRangeEnd = 88256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshTimelineClip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTimelineClip>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MeshClipControl template
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshTimelineClip.NativeFieldInfoPtr_template));
      return num == IntPtr.Zero ? (MeshClipControl) null : Il2CppObjectPool.Get<MeshClipControl>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshTimelineClip.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
