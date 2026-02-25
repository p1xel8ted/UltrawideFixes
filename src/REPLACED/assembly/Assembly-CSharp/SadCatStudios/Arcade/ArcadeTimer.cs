// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeTimer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_timeSlide;
  private static readonly System.IntPtr NativeFieldInfoPtr_timerLoca;
  private static readonly System.IntPtr NativeFieldInfoPtr_timerText;
  private static readonly System.IntPtr NativeFieldInfoPtr_localizedFormatting;
  private static readonly System.IntPtr NativeFieldInfoPtr_time;
  private static readonly System.IntPtr NativeFieldInfoPtr_cancelSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_Timeout;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_Timeout_Public_add_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_Timeout_Public_rem_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTimerText_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartTimer_Public_UniTaskVoid_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddTimer_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopTimer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeTimer()
  {
    Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeTimer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr);
    ArcadeTimer.NativeFieldInfoPtr_timeSlide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (timeSlide));
    ArcadeTimer.NativeFieldInfoPtr_timerLoca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (timerLoca));
    ArcadeTimer.NativeFieldInfoPtr_timerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (timerText));
    ArcadeTimer.NativeFieldInfoPtr_localizedFormatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (localizedFormatting));
    ArcadeTimer.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (time));
    ArcadeTimer.NativeFieldInfoPtr_cancelSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (cancelSource));
    ArcadeTimer.NativeFieldInfoPtr_Timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, nameof (Timeout));
    ArcadeTimer.NativeMethodInfoPtr_add_Timeout_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676749);
    ArcadeTimer.NativeMethodInfoPtr_remove_Timeout_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676750);
    ArcadeTimer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676751);
    ArcadeTimer.NativeMethodInfoPtr_UpdateTimerText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676752);
    ArcadeTimer.NativeMethodInfoPtr_StartTimer_Public_UniTaskVoid_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676753);
    ArcadeTimer.NativeMethodInfoPtr_AddTimer_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676754);
    ArcadeTimer.NativeMethodInfoPtr_StopTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676755);
    ArcadeTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, 100676756);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126200, RefRangeEnd = 126203, XrefRangeStart = 126196, XrefRangeEnd = 126200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_Timeout(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_add_Timeout_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 126207, RefRangeEnd = 126210, XrefRangeStart = 126203, XrefRangeEnd = 126207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_Timeout(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_remove_Timeout_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126210, XrefRangeEnd = 126217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 126220, RefRangeEnd = 126228, XrefRangeStart = 126217, XrefRangeEnd = 126220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateTimerText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_UpdateTimerText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 126231, RefRangeEnd = 126237, XrefRangeStart = 126228, XrefRangeEnd = 126231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid StartTimer(int seconds)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &seconds
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_StartTimer_Public_UniTaskVoid_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126237, XrefRangeEnd = 126239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddTimer(int delta, int maxTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &delta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxTime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_AddTimer_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126239, XrefRangeEnd = 126241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopTimer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr_StopTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeTimer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Slider timeSlide
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timeSlide));
      return num == System.IntPtr.Zero ? (Slider) null : Il2CppObjectPool.Get<Slider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timeSlide), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef timerLoca
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timerLoca));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timerLoca), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text timerText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timerText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_timerText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string localizedFormatting
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_localizedFormatting)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_localizedFormatting), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int time
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_time));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_time)) = value;
    }
  }

  public unsafe CancellationTokenSource cancelSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_cancelSource));
      return num == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_cancelSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action Timeout
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_Timeout));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer.NativeFieldInfoPtr_Timeout), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.ArcadeTimer+<StartTimer>d__11")]
  public sealed class _StartTimer_d__11 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_seconds;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _StartTimer_d__11()
    {
      Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcadeTimer>.NativeClassPtr, "<StartTimer>d__11");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr);
      ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, "<>1__state");
      ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, "<>t__builder");
      ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, "<>4__this");
      ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, nameof (seconds));
      ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, "<>u__1");
      ArcadeTimer._StartTimer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, 100676757);
      ArcadeTimer._StartTimer_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr, 100676758);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126156, XrefRangeEnd = 126196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeTimer._StartTimer_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeTimer._StartTimer_d__11.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _StartTimer_d__11(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _StartTimer_d__11()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeTimer._StartTimer_d__11>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArcadeTimer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArcadeTimer) null : Il2CppObjectPool.Get<ArcadeTimer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int seconds
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr_seconds));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr_seconds)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeTimer._StartTimer_d__11.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
