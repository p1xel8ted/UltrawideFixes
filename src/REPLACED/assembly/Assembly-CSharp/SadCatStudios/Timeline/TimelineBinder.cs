// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.TimelineBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

public class TimelineBinder(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_playOnAwake;
  private static readonly System.IntPtr NativeFieldInfoPtr_keepPlayerBeforeImposter;
  private static readonly System.IntPtr NativeFieldInfoPtr_checkpoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_onTimelineStarted;
  private static readonly System.IntPtr NativeFieldInfoPtr_onTimelineEnded;
  private static readonly System.IntPtr NativeFieldInfoPtr_guids;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerImposter;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitForUnlock;
  private static readonly System.IntPtr NativeFieldInfoPtr_imposters;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipper;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unlock_Private_Void_PlayableDirector_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SkipToEnd_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindAndPlay_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindAndPlay_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LockInput_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindTimelines_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PauseTimeline_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResumeTimeline_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForTimer_Private_IEnumerator_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveAfterCutscene_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TimelineBinder()
  {
    Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (TimelineBinder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr);
    TimelineBinder.NativeFieldInfoPtr_playOnAwake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (playOnAwake));
    TimelineBinder.NativeFieldInfoPtr_keepPlayerBeforeImposter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (keepPlayerBeforeImposter));
    TimelineBinder.NativeFieldInfoPtr_checkpoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (checkpoint));
    TimelineBinder.NativeFieldInfoPtr_onTimelineStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (onTimelineStarted));
    TimelineBinder.NativeFieldInfoPtr_onTimelineEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (onTimelineEnded));
    TimelineBinder.NativeFieldInfoPtr_guids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (guids));
    TimelineBinder.NativeFieldInfoPtr_playerImposter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (playerImposter));
    TimelineBinder.NativeFieldInfoPtr_timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (timeline));
    TimelineBinder.NativeFieldInfoPtr_waitForUnlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (waitForUnlock));
    TimelineBinder.NativeFieldInfoPtr_imposters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (imposters));
    TimelineBinder.NativeFieldInfoPtr_skipper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (skipper));
    TimelineBinder.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, nameof (stateController));
    TimelineBinder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670837);
    TimelineBinder.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670838);
    TimelineBinder.NativeMethodInfoPtr_Unlock_Private_Void_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670839);
    TimelineBinder.NativeMethodInfoPtr_SkipToEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670840);
    TimelineBinder.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670841);
    TimelineBinder.NativeMethodInfoPtr_BindAndPlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670842);
    TimelineBinder.NativeMethodInfoPtr_BindAndPlay_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670843);
    TimelineBinder.NativeMethodInfoPtr_LockInput_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670844);
    TimelineBinder.NativeMethodInfoPtr_BindTimelines_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670845);
    TimelineBinder.NativeMethodInfoPtr_PauseTimeline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670846);
    TimelineBinder.NativeMethodInfoPtr_ResumeTimeline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670847);
    TimelineBinder.NativeMethodInfoPtr_WaitForTimer_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670848);
    TimelineBinder.NativeMethodInfoPtr_SaveAfterCutscene_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670849);
    TimelineBinder.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670850);
    TimelineBinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, 100670851);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88679, XrefRangeEnd = 88700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88700, XrefRangeEnd = 88705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88705, XrefRangeEnd = 88751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unlock(PlayableDirector playableDirector)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playableDirector)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_Unlock_Private_Void_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 88754, RefRangeEnd = 88755, XrefRangeStart = 88751, XrefRangeEnd = 88754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SkipToEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_SkipToEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 88779, RefRangeEnd = 88781, XrefRangeStart = 88755, XrefRangeEnd = 88779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Play()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 88783, RefRangeEnd = 88785, XrefRangeStart = 88781, XrefRangeEnd = 88783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindAndPlay()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_BindAndPlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88785, XrefRangeEnd = 88791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindAndPlay(float timer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &timer
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_BindAndPlay_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88791, XrefRangeEnd = 88795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LockInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_LockInput_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 88919, RefRangeEnd = 88922, XrefRangeStart = 88795, XrefRangeEnd = 88919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindTimelines()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_BindTimelines_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88922, XrefRangeEnd = 88927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PauseTimeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_PauseTimeline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88927, XrefRangeEnd = 88932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResumeTimeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_ResumeTimeline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88932, XrefRangeEnd = 88936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForTimer(float targetTimer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &targetTimer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_WaitForTimer_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88936, XrefRangeEnd = 88941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveAfterCutscene()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_SaveAfterCutscene_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88941, XrefRangeEnd = 88961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnNotify(Playable origin, INotification notification, Il2CppSystem.Object context)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notification);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) context);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr_OnNotify_Public_Virtual_Final_New_Void_Playable_INotification_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88961, XrefRangeEnd = 88974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimelineBinder()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineBinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool playOnAwake
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_playOnAwake));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_playOnAwake)) = value;
    }
  }

  public unsafe bool keepPlayerBeforeImposter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_keepPlayerBeforeImposter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_keepPlayerBeforeImposter)) = value;
    }
  }

  public unsafe bool checkpoint
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_checkpoint));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_checkpoint)) = value;
    }
  }

  public unsafe UnityEvent onTimelineStarted
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_onTimelineStarted));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_onTimelineStarted), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEvent onTimelineEnded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_onTimelineEnded));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_onTimelineEnded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GuidReference> guids
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_guids));
      return num == System.IntPtr.Zero ? (List<GuidReference>) null : Il2CppObjectPool.Get<List<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_guids), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterImposter playerImposter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_playerImposter));
      return num == System.IntPtr.Zero ? (CharacterImposter) null : Il2CppObjectPool.Get<CharacterImposter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_playerImposter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector timeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_timeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_timeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool waitForUnlock
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_waitForUnlock));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_waitForUnlock)) = value;
    }
  }

  public unsafe List<CharacterImposter> imposters
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_imposters));
      return num == System.IntPtr.Zero ? (List<CharacterImposter>) null : Il2CppObjectPool.Get<List<CharacterImposter>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_imposters), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TimelineSkipper skipper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_skipper));
      return num == System.IntPtr.Zero ? (TimelineSkipper) null : Il2CppObjectPool.Get<TimelineSkipper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_skipper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Timeline.TimelineBinder+<WaitForTimer>d__23")]
  public sealed class _WaitForTimer_d__23(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_targetTimer;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForTimer_d__23()
    {
      Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineBinder>.NativeClassPtr, "<WaitForTimer>d__23");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr);
      TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, "<>1__state");
      TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, "<>2__current");
      TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr_targetTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, nameof (targetTimer));
      TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, "<>4__this");
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670852);
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670853);
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670854);
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670855);
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670856);
      TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr, 100670857);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForTimer_d__23(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineBinder._WaitForTimer_d__23>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88670, XrefRangeEnd = 88674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88674, XrefRangeEnd = 88679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineBinder._WaitForTimer_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float targetTimer
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr_targetTimer));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr_targetTimer)) = value;
      }
    }

    public unsafe TimelineBinder __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TimelineBinder) null : Il2CppObjectPool.Get<TimelineBinder>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineBinder._WaitForTimer_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
