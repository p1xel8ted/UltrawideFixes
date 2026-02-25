// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterAttackSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterAttackSender(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_attack;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_body;
  private static readonly IntPtr NativeFieldInfoPtr_hitSendAnnouncers;
  private static readonly IntPtr NativeFieldInfoPtr_hitConnectAnnouncers;
  private static readonly IntPtr NativeFieldInfoPtr_hitInterruptibleAnnouncers;
  private static readonly IntPtr NativeFieldInfoPtr_hitHandlers;
  private static readonly IntPtr NativeFieldInfoPtr_hitCaster;
  private static readonly IntPtr NativeFieldInfoPtr_perfectHitTracker;
  private static readonly IntPtr NativeFieldInfoPtr_attackInProgress;
  private static readonly IntPtr NativeFieldInfoPtr_lastAttackConnected;
  private static readonly IntPtr NativeFieldInfoPtr_lastAttakBlocked;
  private static readonly IntPtr NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastAttackConnected_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastAttackBlocked_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AttackInProgress_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessAnnounce_Private_Void_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessConnection_Private_Void_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_SendAttack_Public_Virtual_Final_New_Void_AttackData_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveHitFeedback_Public_Virtual_Final_New_Void_HitCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveStateFeedback_Public_Virtual_Final_New_Void_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EndAttack_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAttackSender()
  {
    Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterAttackSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr);
    CharacterAttackSender.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (attack));
    CharacterAttackSender.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (rotationController));
    CharacterAttackSender.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (stateController));
    CharacterAttackSender.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (body));
    CharacterAttackSender.NativeFieldInfoPtr_hitSendAnnouncers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (hitSendAnnouncers));
    CharacterAttackSender.NativeFieldInfoPtr_hitConnectAnnouncers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (hitConnectAnnouncers));
    CharacterAttackSender.NativeFieldInfoPtr_hitInterruptibleAnnouncers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (hitInterruptibleAnnouncers));
    CharacterAttackSender.NativeFieldInfoPtr_hitHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (hitHandlers));
    CharacterAttackSender.NativeFieldInfoPtr_hitCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (hitCaster));
    CharacterAttackSender.NativeFieldInfoPtr_perfectHitTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (perfectHitTracker));
    CharacterAttackSender.NativeFieldInfoPtr_attackInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (attackInProgress));
    CharacterAttackSender.NativeFieldInfoPtr_lastAttackConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (lastAttackConnected));
    CharacterAttackSender.NativeFieldInfoPtr_lastAttakBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, nameof (lastAttakBlocked));
    CharacterAttackSender.NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677293);
    CharacterAttackSender.NativeMethodInfoPtr_get_LastAttackConnected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677294);
    CharacterAttackSender.NativeMethodInfoPtr_get_LastAttackBlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677295);
    CharacterAttackSender.NativeMethodInfoPtr_get_AttackInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677296);
    CharacterAttackSender.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677297);
    CharacterAttackSender.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677298);
    CharacterAttackSender.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677299);
    CharacterAttackSender.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677300);
    CharacterAttackSender.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677301);
    CharacterAttackSender.NativeMethodInfoPtr_ProcessAnnounce_Private_Void_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677302);
    CharacterAttackSender.NativeMethodInfoPtr_ProcessConnection_Private_Void_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677303);
    CharacterAttackSender.NativeMethodInfoPtr_SendAttack_Public_Virtual_Final_New_Void_AttackData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677304);
    CharacterAttackSender.NativeMethodInfoPtr_ReceiveHitFeedback_Public_Virtual_Final_New_Void_HitCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677305);
    CharacterAttackSender.NativeMethodInfoPtr_ReceiveStateFeedback_Public_Virtual_Final_New_Void_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677306);
    CharacterAttackSender.NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677307);
    CharacterAttackSender.NativeMethodInfoPtr_EndAttack_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677308);
    CharacterAttackSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr, 100677309);
  }

  public unsafe AttackObject Attack
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_Attack_Public_get_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num3);
    }
  }

  public unsafe bool LastAttackConnected
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_LastAttackConnected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool LastAttackBlocked
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_LastAttackBlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool AttackInProgress
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_AttackInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Vector3 ImpactPosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129251, XrefRangeEnd = 129253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_ImpactPosition_Public_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe int ImpactDirection
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129253, XrefRangeEnd = 129255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_ImpactDirection_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Transform ProviderTransform
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_ProviderTransform_Public_Virtual_Final_New_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
  }

  public virtual unsafe Rigidbody ProviderRigidbody
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_get_ProviderRigidbody_Public_Virtual_Final_New_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129255, XrefRangeEnd = 129286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129286, XrefRangeEnd = 129296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessAnnounce(HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_ProcessAnnounce_Private_Void_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129296, XrefRangeEnd = 129304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessConnection(HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_ProcessConnection_Private_Void_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129331, RefRangeEnd = 129332, XrefRangeStart = 129304, XrefRangeEnd = 129331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendAttack(AttackData attackData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attackData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_SendAttack_Public_Virtual_Final_New_Void_AttackData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129332, XrefRangeEnd = 129337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveHitFeedback(HitCastResult hitCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) hitCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_ReceiveHitFeedback_Public_Virtual_Final_New_Void_HitCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ReceiveStateFeedback(FSMGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) graph)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_ReceiveStateFeedback_Public_Virtual_Final_New_Void_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129337, XrefRangeEnd = 129341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReceiveBlockFeedback()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_ReceiveBlockFeedback_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129349, RefRangeEnd = 129350, XrefRangeStart = 129341, XrefRangeEnd = 129349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAttack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr_EndAttack_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAttackSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAttackSender>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttackObject attack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_attack));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody body
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_body));
      return num == IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IHitAnnounceSendHandler> hitSendAnnouncers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitSendAnnouncers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IHitAnnounceSendHandler>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IHitAnnounceSendHandler>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitSendAnnouncers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IHitAnnounceConnectHandler> hitConnectAnnouncers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitConnectAnnouncers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IHitAnnounceConnectHandler>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IHitAnnounceConnectHandler>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitConnectAnnouncers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IHitAnnounceInterruptible> hitInterruptibleAnnouncers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitInterruptibleAnnouncers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IHitAnnounceInterruptible>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IHitAnnounceInterruptible>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitInterruptibleAnnouncers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IHitFeedbackHandler> hitHandlers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitHandlers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<IHitFeedbackHandler>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IHitFeedbackHandler>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IHitCaster hitCaster
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitCaster));
      return num == IntPtr.Zero ? (IHitCaster) null : Il2CppObjectPool.Get<IHitCaster>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_hitCaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterPerfectHitTracker perfectHitTracker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_perfectHitTracker));
      return num == IntPtr.Zero ? (CharacterPerfectHitTracker) null : Il2CppObjectPool.Get<CharacterPerfectHitTracker>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_perfectHitTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool attackInProgress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_attackInProgress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_attackInProgress)) = value;
    }
  }

  public unsafe bool lastAttackConnected
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_lastAttackConnected));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_lastAttackConnected)) = value;
    }
  }

  public unsafe bool lastAttakBlocked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_lastAttakBlocked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackSender.NativeFieldInfoPtr_lastAttakBlocked)) = value;
    }
  }
}
