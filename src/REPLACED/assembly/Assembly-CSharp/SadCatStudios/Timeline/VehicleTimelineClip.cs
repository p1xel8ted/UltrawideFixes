// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.VehicleTimelineClip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class VehicleTimelineClip(IntPtr pointer) : PlayableAsset(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_EntryPoint;
  private static readonly IntPtr NativeFieldInfoPtr__clipCaps_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VehicleTimelineClip()
  {
    Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (VehicleTimelineClip));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr);
    VehicleTimelineClip.NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr, nameof (EntryPoint));
    VehicleTimelineClip.NativeFieldInfoPtr__clipCaps_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr, "<clipCaps>k__BackingField");
    VehicleTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr, 100670828);
    VehicleTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr, 100670829);
    VehicleTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr, 100670830);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88585, XrefRangeEnd = 88594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VehicleTimelineClip.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe ClipCaps clipCaps
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VehicleTimelineClip.NativeMethodInfoPtr_get_clipCaps_Public_Virtual_Final_New_get_ClipCaps_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipCaps*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VehicleTimelineClip()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleTimelineClip>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VehicleTimelineClip.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 EntryPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleTimelineClip.NativeFieldInfoPtr_EntryPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleTimelineClip.NativeFieldInfoPtr_EntryPoint)) = value;
    }
  }

  public unsafe ClipCaps _clipCaps_k__BackingField
  {
    get
    {
      return *(ClipCaps*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleTimelineClip.NativeFieldInfoPtr__clipCaps_k__BackingField));
    }
    [param: In] set
    {
      *(ClipCaps*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VehicleTimelineClip.NativeFieldInfoPtr__clipCaps_k__BackingField)) = value;
    }
  }
}
