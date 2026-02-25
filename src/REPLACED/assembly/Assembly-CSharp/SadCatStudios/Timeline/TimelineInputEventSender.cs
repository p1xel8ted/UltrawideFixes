// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.TimelineInputEventSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.PlayerInput;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

public class TimelineInputEventSender(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_freezeTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_timeline;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyTextRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowdownDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_slowdownCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_unfreezeDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_unfreezeCurve;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PauseAndWait_Public_Void_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForInput_Private_IEnumerator_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TimelineInputEventSender()
  {
    Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (TimelineInputEventSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr);
    TimelineInputEventSender.NativeFieldInfoPtr_freezeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (freezeTime));
    TimelineInputEventSender.NativeFieldInfoPtr_timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (timeline));
    TimelineInputEventSender.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (inputAction));
    TimelineInputEventSender.NativeFieldInfoPtr_articyTextRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (articyTextRef));
    TimelineInputEventSender.NativeFieldInfoPtr_slowdownDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (slowdownDuration));
    TimelineInputEventSender.NativeFieldInfoPtr_slowdownCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (slowdownCurve));
    TimelineInputEventSender.NativeFieldInfoPtr_unfreezeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (unfreezeDuration));
    TimelineInputEventSender.NativeFieldInfoPtr_unfreezeCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, nameof (unfreezeCurve));
    TimelineInputEventSender.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, 100670858);
    TimelineInputEventSender.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, 100670859);
    TimelineInputEventSender.NativeMethodInfoPtr_PauseAndWait_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, 100670860);
    TimelineInputEventSender.NativeMethodInfoPtr_WaitForInput_Private_IEnumerator_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, 100670861);
    TimelineInputEventSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, 100670862);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88994, XrefRangeEnd = 88999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88999, XrefRangeEnd = 89001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89001, XrefRangeEnd = 89006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PauseAndWait(InputAction inputAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputAction
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender.NativeMethodInfoPtr_PauseAndWait_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89006, XrefRangeEnd = 89010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForInput(InputAction inputAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputAction
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender.NativeMethodInfoPtr_WaitForInput_Private_IEnumerator_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89010, XrefRangeEnd = 89011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimelineInputEventSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool freezeTime
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_freezeTime));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_freezeTime)) = value;
    }
  }

  public unsafe PlayableDirector timeline
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_timeline));
      return num == System.IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_timeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InputAction inputAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_inputAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_inputAction)) = value;
    }
  }

  public unsafe ArticyRef articyTextRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_articyTextRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_articyTextRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float slowdownDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_slowdownDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_slowdownDuration)) = value;
    }
  }

  public unsafe AnimationCurve slowdownCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_slowdownCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_slowdownCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float unfreezeDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_unfreezeDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_unfreezeDuration)) = value;
    }
  }

  public unsafe AnimationCurve unfreezeCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_unfreezeCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender.NativeFieldInfoPtr_unfreezeCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Timeline.TimelineInputEventSender+<WaitForInput>d__11")]
  public sealed class _WaitForInput_d__11(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_inputAction;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__prompt_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForInput_d__11()
    {
      Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimelineInputEventSender>.NativeClassPtr, "<WaitForInput>d__11");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr);
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, "<>1__state");
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, "<>2__current");
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, "<>4__this");
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, nameof (inputAction));
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, "<timer>5__2");
      TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__prompt_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, "<prompt>5__3");
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670863);
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670864);
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670865);
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670866);
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670867);
      TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr, 100670868);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForInput_d__11(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimelineInputEventSender._WaitForInput_d__11>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88974, XrefRangeEnd = 88989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88989, XrefRangeEnd = 88994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TimelineInputEventSender._WaitForInput_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TimelineInputEventSender __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (TimelineInputEventSender) null : Il2CppObjectPool.Get<TimelineInputEventSender>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputAction inputAction
    {
      get
      {
        return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr_inputAction));
      }
      [param: In] set
      {
        *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr_inputAction)) = value;
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe UIButtonPrompt _prompt_5__3
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__prompt_5__3));
        return num == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimelineInputEventSender._WaitForInput_d__11.NativeFieldInfoPtr__prompt_5__3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
