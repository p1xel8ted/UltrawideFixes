// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.SubtitleMixerBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Dialogs;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

public class SubtitleMixerBehavior(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ShowMarker;
  private static readonly System.IntPtr NativeFieldInfoPtr_speechController;
  private static readonly System.IntPtr NativeFieldInfoPtr_prevTotalWeight;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SubtitleMixerBehavior()
  {
    Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (SubtitleMixerBehavior));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr);
    SubtitleMixerBehavior.NativeFieldInfoPtr_ShowMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, nameof (ShowMarker));
    SubtitleMixerBehavior.NativeFieldInfoPtr_speechController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, nameof (speechController));
    SubtitleMixerBehavior.NativeFieldInfoPtr_prevTotalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, nameof (prevTotalWeight));
    SubtitleMixerBehavior.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, 100670805);
    SubtitleMixerBehavior.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, 100670806);
    SubtitleMixerBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr, 100670807);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88347, XrefRangeEnd = 88398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubtitleMixerBehavior.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88398, XrefRangeEnd = 88405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPlayableDestroy(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SubtitleMixerBehavior.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SubtitleMixerBehavior()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubtitleMixerBehavior>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitleMixerBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool ShowMarker
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_ShowMarker));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_ShowMarker)) = value;
    }
  }

  public unsafe SpeechController speechController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_speechController));
      return num == System.IntPtr.Zero ? (SpeechController) null : Il2CppObjectPool.Get<SpeechController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_speechController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float prevTotalWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_prevTotalWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleMixerBehavior.NativeFieldInfoPtr_prevTotalWeight)) = value;
    }
  }
}
