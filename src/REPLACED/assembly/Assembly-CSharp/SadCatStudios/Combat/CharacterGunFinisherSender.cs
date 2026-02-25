// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterGunFinisherSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterGunFinisherSender(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_gunFinisherTimelineTest;
  private static readonly IntPtr NativeFieldInfoPtr_finisherData;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_manaController;
  private static readonly IntPtr NativeFieldInfoPtr_magnetAnnouncer;
  private static readonly IntPtr NativeFieldInfoPtr_caster;
  private static readonly IntPtr NativeFieldInfoPtr_finisherObject;
  private static readonly IntPtr NativeMethodInfoPtr_get_SenderRotation_Public_Virtual_Final_New_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CastFinisher_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SendFinisher_Public_Void_IGunFinisherReceiver_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessFinisherConnection_Public_Virtual_Final_New_Void_Transform_FinisherVariant_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindTrack_Private_TrackAsset_PlayableDirector_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__CastFinisher_b__11_0_Private_Void_FinisherCastResult_0;

  static CharacterGunFinisherSender()
  {
    Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterGunFinisherSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr);
    CharacterGunFinisherSender.NativeFieldInfoPtr_gunFinisherTimelineTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (gunFinisherTimelineTest));
    CharacterGunFinisherSender.NativeFieldInfoPtr_finisherData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (finisherData));
    CharacterGunFinisherSender.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (stateController));
    CharacterGunFinisherSender.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (rotationController));
    CharacterGunFinisherSender.NativeFieldInfoPtr_manaController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (manaController));
    CharacterGunFinisherSender.NativeFieldInfoPtr_magnetAnnouncer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (magnetAnnouncer));
    CharacterGunFinisherSender.NativeFieldInfoPtr_caster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (caster));
    CharacterGunFinisherSender.NativeFieldInfoPtr_finisherObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, nameof (finisherObject));
    CharacterGunFinisherSender.NativeMethodInfoPtr_get_SenderRotation_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677335);
    CharacterGunFinisherSender.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677336);
    CharacterGunFinisherSender.NativeMethodInfoPtr_CastFinisher_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677337);
    CharacterGunFinisherSender.NativeMethodInfoPtr_SendFinisher_Public_Void_IGunFinisherReceiver_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677338);
    CharacterGunFinisherSender.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Virtual_Final_New_Void_Transform_FinisherVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677339);
    CharacterGunFinisherSender.NativeMethodInfoPtr_FindTrack_Private_TrackAsset_PlayableDirector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677340);
    CharacterGunFinisherSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677341);
    CharacterGunFinisherSender.NativeMethodInfoPtr__CastFinisher_b__11_0_Private_Void_FinisherCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr, 100677342);
  }

  public virtual unsafe int SenderRotation
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129501, XrefRangeEnd = 129503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_get_SenderRotation_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129503, XrefRangeEnd = 129522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129533, RefRangeEnd = 129534, XrefRangeStart = 129522, XrefRangeEnd = 129533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CastFinisher()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_CastFinisher_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129534, XrefRangeEnd = 129541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SendFinisher(
    IGunFinisherReceiver finisherReceiver,
    Transform receiverTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherReceiver);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiverTransform);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_SendFinisher_Public_Void_IGunFinisherReceiver_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129541, XrefRangeEnd = 129574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessFinisherConnection(
    Transform receiverTransform,
    FinisherVariant finisherVariant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiverTransform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherVariant);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Virtual_Final_New_Void_Transform_FinisherVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129600, RefRangeEnd = 129601, XrefRangeStart = 129574, XrefRangeEnd = 129600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TrackAsset FindTrack(PlayableDirector timeline)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) timeline)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr_FindTrack_Private_TrackAsset_PlayableDirector_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (TrackAsset) null : Il2CppObjectPool.Get<TrackAsset>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterGunFinisherSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGunFinisherSender>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129601, XrefRangeEnd = 129607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _CastFinisher_b__11_0(FinisherCastResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) result))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGunFinisherSender.NativeMethodInfoPtr__CastFinisher_b__11_0_Private_Void_FinisherCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PlayableDirector gunFinisherTimelineTest
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_gunFinisherTimelineTest));
      return num == IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_gunFinisherTimelineTest), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData finisherData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_finisherData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_finisherData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterManaController manaController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_manaController));
      return num == IntPtr.Zero ? (CharacterManaController) null : Il2CppObjectPool.Get<CharacterManaController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_manaController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAttackMagnetAnnouncer magnetAnnouncer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_magnetAnnouncer));
      return num == IntPtr.Zero ? (CharacterAttackMagnetAnnouncer) null : Il2CppObjectPool.Get<CharacterAttackMagnetAnnouncer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_magnetAnnouncer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IGunFinisherCaster caster
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_caster));
      return num == IntPtr.Zero ? (IGunFinisherCaster) null : Il2CppObjectPool.Get<IGunFinisherCaster>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_caster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject finisherObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_finisherObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGunFinisherSender.NativeFieldInfoPtr_finisherObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
