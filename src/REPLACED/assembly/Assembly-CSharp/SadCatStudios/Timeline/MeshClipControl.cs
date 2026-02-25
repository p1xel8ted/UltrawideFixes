// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.MeshClipControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class MeshClipControl(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Clip;
  private static readonly System.IntPtr NativeFieldInfoPtr_InvertRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_clipTimeOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_clearAfterPlayback;
  private static readonly System.IntPtr NativeFieldInfoPtr_anim;
  private static readonly System.IntPtr NativeFieldInfoPtr_isContinue;
  private static readonly System.IntPtr NativeFieldInfoPtr_isFirstFrame;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshClipControl()
  {
    Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (MeshClipControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr);
    MeshClipControl.NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (Clip));
    MeshClipControl.NativeFieldInfoPtr_InvertRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (InvertRotation));
    MeshClipControl.NativeFieldInfoPtr_clipTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (clipTimeOffset));
    MeshClipControl.NativeFieldInfoPtr_clearAfterPlayback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (clearAfterPlayback));
    MeshClipControl.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (anim));
    MeshClipControl.NativeFieldInfoPtr_isContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (isContinue));
    MeshClipControl.NativeFieldInfoPtr_isFirstFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, nameof (isFirstFrame));
    MeshClipControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, 100670782);
    MeshClipControl.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, 100670783);
    MeshClipControl.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, 100670784);
    MeshClipControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr, 100670785);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88212, XrefRangeEnd = 88233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshClipControl.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void OnBehaviourPlay(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshClipControl.NativeMethodInfoPtr_OnBehaviourPlay_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88233, XrefRangeEnd = 88238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnBehaviourPause(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshClipControl.NativeMethodInfoPtr_OnBehaviourPause_Public_Virtual_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipControl>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClipControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MeshClip Clip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_Clip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool InvertRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_InvertRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_InvertRotation)) = value;
    }
  }

  public unsafe float clipTimeOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_clipTimeOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_clipTimeOffset)) = value;
    }
  }

  public unsafe bool clearAfterPlayback
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_clearAfterPlayback));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_clearAfterPlayback)) = value;
    }
  }

  public unsafe SpriteAnimator anim
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_anim));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isContinue
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_isContinue));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_isContinue)) = value;
    }
  }

  public unsafe bool isFirstFrame
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_isFirstFrame));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipControl.NativeFieldInfoPtr_isFirstFrame)) = value;
    }
  }
}
