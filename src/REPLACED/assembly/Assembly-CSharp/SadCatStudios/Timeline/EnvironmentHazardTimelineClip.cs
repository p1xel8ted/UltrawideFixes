// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.EnvironmentHazardTimelineClip
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
public class EnvironmentHazardTimelineClip(IntPtr pointer) : PlayableAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_template;
  private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnvironmentHazardTimelineClip()
  {
    Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (EnvironmentHazardTimelineClip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr);
    EnvironmentHazardTimelineClip.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr, nameof (template));
    EnvironmentHazardTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr, 100670777);
    EnvironmentHazardTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr, 100670778);
    EnvironmentHazardTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr, 100670779);
  }

  public virtual unsafe ClipCaps clipCaps
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnvironmentHazardTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipCaps*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88190, XrefRangeEnd = 88199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EnvironmentHazardTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnvironmentHazardTimelineClip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvironmentHazardTimelineClip>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnvironmentHazardTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EnvironmentHazardControl template
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnvironmentHazardTimelineClip.NativeFieldInfoPtr_template));
      return num == IntPtr.Zero ? (EnvironmentHazardControl) null : Il2CppObjectPool.Get<EnvironmentHazardControl>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnvironmentHazardTimelineClip.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
