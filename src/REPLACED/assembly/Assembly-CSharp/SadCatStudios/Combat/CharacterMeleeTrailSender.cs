// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterMeleeTrailSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Animation;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterMeleeTrailSender(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_trailAnimator;
  private static readonly System.IntPtr NativeFieldInfoPtr_trails;
  private static readonly System.IntPtr NativeFieldInfoPtr_trailParents;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastTrailN;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastTrailParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_targets;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendTrail_Public_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendTrail_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndTrail_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForActiveFrame_Private_IEnumerator_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FollowTrailAnchor_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterMeleeTrailSender()
  {
    Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterMeleeTrailSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr);
    CharacterMeleeTrailSender.NativeFieldInfoPtr_trailAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (trailAnimator));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_trails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (trails));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_trailParents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (trailParents));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (lastTrailN));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (lastTrailParent));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (animationController));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (hitboxController));
    CharacterMeleeTrailSender.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (targets));
    CharacterMeleeTrailSender.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677343);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677344);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677345);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_SendTrail_Public_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677346);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_SendTrail_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677347);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_EndTrail_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677348);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_WaitForActiveFrame_Private_IEnumerator_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677349);
    CharacterMeleeTrailSender.NativeMethodInfoPtr_FollowTrailAnchor_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677350);
    CharacterMeleeTrailSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, 100677351);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129672, XrefRangeEnd = 129685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129685, XrefRangeEnd = 129686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129686, XrefRangeEnd = 129691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendTrail(MeshClip trailClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trailClip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_SendTrail_Public_Void_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129696, RefRangeEnd = 129697, XrefRangeStart = 129691, XrefRangeEnd = 129696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendTrail()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_SendTrail_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 129719, RefRangeEnd = 129722, XrefRangeStart = 129697, XrefRangeEnd = 129719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EndTrail()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_EndTrail_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129722, XrefRangeEnd = 129726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForActiveFrame(MeshClip trailClip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) trailClip)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_WaitForActiveFrame_Private_IEnumerator_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129726, XrefRangeEnd = 129730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator FollowTrailAnchor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr_FollowTrailAnchor_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129730, XrefRangeEnd = 129737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterMeleeTrailSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator trailAnimator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trailAnimator));
      return num == System.IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trailAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TrailRenderer> trails
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trails));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<TrailRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trails), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> trailParents
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trailParents));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_trailParents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int lastTrailN
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailN));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailN)) = value;
    }
  }

  public unsafe Transform lastTrailParent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailParent));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_lastTrailParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<CharacterMeleeTrailSender.Target> targets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_targets));
      return num == System.IntPtr.Zero ? (List<CharacterMeleeTrailSender.Target>) null : Il2CppObjectPool.Get<List<CharacterMeleeTrailSender.Target>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Target
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_ControlPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndPos;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    [FieldOffset(0)]
    public Vector3 StartPos;
    [FieldOffset(12)]
    public Vector3 ControlPos;
    [FieldOffset(24)]
    public Vector3 EndPos;
    [FieldOffset(36)]
    public float Duration;

    static Target()
    {
      Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, nameof (Target));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr);
      CharacterMeleeTrailSender.Target.NativeFieldInfoPtr_StartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr, nameof (StartPos));
      CharacterMeleeTrailSender.Target.NativeFieldInfoPtr_ControlPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr, nameof (ControlPos));
      CharacterMeleeTrailSender.Target.NativeFieldInfoPtr_EndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr, nameof (EndPos));
      CharacterMeleeTrailSender.Target.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr, nameof (Duration));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterMeleeTrailSender.Target>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterMeleeTrailSender+<FollowTrailAnchor>d__16")]
  public sealed class _FollowTrailAnchor_d__16(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__trailEvent_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__targetIndex_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__trailRoot_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__trailStartPos_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__parent_5__7;
    private static readonly System.IntPtr NativeFieldInfoPtr__positionLastFrame_5__8;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _FollowTrailAnchor_d__16()
    {
      Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, "<FollowTrailAnchor>d__16");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<>1__state");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<>2__current");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<>4__this");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailEvent_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<trailEvent>5__2");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<timer>5__3");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__targetIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<targetIndex>5__4");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailRoot_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<trailRoot>5__5");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailStartPos_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<trailStartPos>5__6");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__parent_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<parent>5__7");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__positionLastFrame_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, "<positionLastFrame>5__8");
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677352);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677353);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677354);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677355);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677356);
      CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr, 100677357);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _FollowTrailAnchor_d__16(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMeleeTrailSender._FollowTrailAnchor_d__16>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129607, XrefRangeEnd = 129661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129661, XrefRangeEnd = 129666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterMeleeTrailSender __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterMeleeTrailSender) null : Il2CppObjectPool.Get<CharacterMeleeTrailSender>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshTrailEvent _trailEvent_5__2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailEvent_5__2));
        return num == System.IntPtr.Zero ? (MeshTrailEvent) null : Il2CppObjectPool.Get<MeshTrailEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailEvent_5__2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }

    public unsafe int _targetIndex_5__4
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__targetIndex_5__4));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__targetIndex_5__4)) = value;
      }
    }

    public unsafe Transform _trailRoot_5__5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailRoot_5__5));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailRoot_5__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _trailStartPos_5__6
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailStartPos_5__6));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__trailStartPos_5__6)) = value;
      }
    }

    public unsafe Transform _parent_5__7
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__parent_5__7));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__parent_5__7), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _positionLastFrame_5__8
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__positionLastFrame_5__8));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._FollowTrailAnchor_d__16.NativeFieldInfoPtr__positionLastFrame_5__8)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterMeleeTrailSender+<WaitForActiveFrame>d__13")]
  public sealed class _WaitForActiveFrame_d__13(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_trailClip;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForActiveFrame_d__13()
    {
      Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterMeleeTrailSender>.NativeClassPtr, "<WaitForActiveFrame>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, "<>1__state");
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, "<>2__current");
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, "<>4__this");
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr_trailClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, nameof (trailClip));
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677358);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677359);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677360);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677361);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677362);
      CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr, 100677363);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForActiveFrame_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMeleeTrailSender._WaitForActiveFrame_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129666, XrefRangeEnd = 129667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129667, XrefRangeEnd = 129672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterMeleeTrailSender __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterMeleeTrailSender) null : Il2CppObjectPool.Get<CharacterMeleeTrailSender>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshClip trailClip
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr_trailClip));
        return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMeleeTrailSender._WaitForActiveFrame_d__13.NativeFieldInfoPtr_trailClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
