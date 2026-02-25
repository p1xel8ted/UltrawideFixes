// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterHitCounter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterHitCounter(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_resetTimerDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitSpeedIncrement;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitSpeedMax;
  private static readonly System.IntPtr NativeFieldInfoPtr_currMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_sender;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrMultiplier_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DropMultiplierTimer_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetTimer_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterHitCounter()
  {
    Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterHitCounter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr);
    CharacterHitCounter.NativeFieldInfoPtr_resetTimerDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, nameof (resetTimerDuration));
    CharacterHitCounter.NativeFieldInfoPtr_hitSpeedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, nameof (hitSpeedIncrement));
    CharacterHitCounter.NativeFieldInfoPtr_hitSpeedMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, nameof (hitSpeedMax));
    CharacterHitCounter.NativeFieldInfoPtr_currMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, nameof (currMultiplier));
    CharacterHitCounter.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, nameof (sender));
    CharacterHitCounter.NativeMethodInfoPtr_get_CurrMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677540);
    CharacterHitCounter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677541);
    CharacterHitCounter.NativeMethodInfoPtr_DropMultiplierTimer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677542);
    CharacterHitCounter.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677543);
    CharacterHitCounter.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677544);
    CharacterHitCounter.NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677545);
    CharacterHitCounter.NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677546);
    CharacterHitCounter.NativeMethodInfoPtr_ResetTimer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677547);
    CharacterHitCounter.NativeMethodInfoPtr_GetId_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677548);
    CharacterHitCounter.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677549);
    CharacterHitCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, 100677550);
  }

  public unsafe float CurrMultiplier
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_get_CurrMultiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130570, XrefRangeEnd = 130573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130573, XrefRangeEnd = 130574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DropMultiplierTimer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_DropMultiplierTimer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130574, XrefRangeEnd = 130575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 67746, RefRangeEnd = 67757, XrefRangeStart = 67746, XrefRangeEnd = 67757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool NeedResponce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_NeedResponce_Public_Virtual_Final_New_Boolean_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130575, XrefRangeEnd = 130581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection(
    AttackObject attack,
    HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_SadCatStudios_Combat_IHitFeedbackHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection(
    AttackObject attack,
    HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_SadCatStudios_Combat_IHitReceiveHandler_ProcessConnection_Private_Virtual_Final_New_Void_AttackObject_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130581, XrefRangeEnd = 130585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator ResetTimer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_ResetTimer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 89593, RefRangeEnd = 89608, XrefRangeStart = 89593, XrefRangeEnd = 89608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_GetId_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130585, XrefRangeEnd = 130586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterHitCounter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float resetTimerDuration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_resetTimerDuration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_resetTimerDuration)) = value;
    }
  }

  public unsafe float hitSpeedIncrement
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_hitSpeedIncrement));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_hitSpeedIncrement)) = value;
    }
  }

  public unsafe float hitSpeedMax
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_hitSpeedMax));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_hitSpeedMax)) = value;
    }
  }

  public unsafe float currMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_currMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_currMultiplier)) = value;
    }
  }

  public unsafe CharacterAttackSender sender
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_sender));
      return num == System.IntPtr.Zero ? (CharacterAttackSender) null : Il2CppObjectPool.Get<CharacterAttackSender>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterHitCounter+<ResetTimer>d__13")]
  public sealed class _ResetTimer_d__13(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _ResetTimer_d__13()
    {
      Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHitCounter>.NativeClassPtr, "<ResetTimer>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr);
      CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, "<>1__state");
      CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, "<>2__current");
      CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, "<>4__this");
      CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, "<timer>5__2");
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677551);
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677552);
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677553);
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677554);
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677555);
      CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr, 100677556);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _ResetTimer_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHitCounter._ResetTimer_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130559, XrefRangeEnd = 130565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130565, XrefRangeEnd = 130570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterHitCounter._ResetTimer_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterHitCounter __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterHitCounter) null : Il2CppObjectPool.Get<CharacterHitCounter>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHitCounter._ResetTimer_d__13.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }
}
