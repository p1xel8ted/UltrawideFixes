// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GrenadeCountdownAnnouncer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class GrenadeCountdownAnnouncer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_attackDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_blinkingDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitingSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_blinkingSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_indicator;
  private static readonly System.IntPtr NativeFieldInfoPtr_speedId;
  private static readonly System.IntPtr NativeFieldInfoPtr_indicatorRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_indicatorMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountdownEffect_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GrenadeCountdownAnnouncer()
  {
    Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GrenadeCountdownAnnouncer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr);
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_attackDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (attackDelay));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (blinkingDuration));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_waitingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (waitingSpeed));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (blinkingSpeed));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (indicator));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_speedId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (speedId));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (indicatorRenderer));
    GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, nameof (indicatorMaterial));
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677112);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677113);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677114);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677115);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677116);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677117);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr_CountdownEffect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677118);
    GrenadeCountdownAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, 100677119);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128322, XrefRangeEnd = 128326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128326, XrefRangeEnd = 128328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128328, XrefRangeEnd = 128339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128339, XrefRangeEnd = 128340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128340, XrefRangeEnd = 128345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 116304, RefRangeEnd = 116305, XrefRangeStart = 116304, XrefRangeEnd = 116305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128345, XrefRangeEnd = 128349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator CountdownEffect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr_CountdownEffect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GrenadeCountdownAnnouncer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference attackDelay
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_attackDelay));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_attackDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference blinkingDuration
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingDuration));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference waitingSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_waitingSpeed));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_waitingSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference blinkingSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingSpeed));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_blinkingSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform indicator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicator));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int speedId
  {
    get
    {
      int speedId;
      IL2CPP.il2cpp_field_static_get_value(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_speedId, (void*) &speedId);
      return speedId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_speedId, (void*) &value);
    }
  }

  public unsafe MeshRenderer indicatorRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorRenderer));
      return num == System.IntPtr.Zero ? (MeshRenderer) null : Il2CppObjectPool.Get<MeshRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material indicatorMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer.NativeFieldInfoPtr_indicatorMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.GrenadeCountdownAnnouncer+<CountdownEffect>d__14")]
  public sealed class _CountdownEffect_d__14(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__waitTime_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _CountdownEffect_d__14()
    {
      Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrenadeCountdownAnnouncer>.NativeClassPtr, "<CountdownEffect>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, "<>1__state");
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, "<>2__current");
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, "<>4__this");
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, "<timer>5__2");
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__waitTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, "<waitTime>5__3");
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677121);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677122);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677123);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677124);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677125);
      GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr, 100677126);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _CountdownEffect_d__14(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrenadeCountdownAnnouncer._CountdownEffect_d__14>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128297, XrefRangeEnd = 128317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128317, XrefRangeEnd = 128322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GrenadeCountdownAnnouncer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GrenadeCountdownAnnouncer) null : Il2CppObjectPool.Get<GrenadeCountdownAnnouncer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe float _waitTime_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__waitTime_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeCountdownAnnouncer._CountdownEffect_d__14.NativeFieldInfoPtr__waitTime_5__3)) = value;
      }
    }
  }
}
