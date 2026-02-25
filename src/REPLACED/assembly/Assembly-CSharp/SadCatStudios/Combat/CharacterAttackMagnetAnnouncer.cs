// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterAttackMagnetAnnouncer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using Sirenix.OdinInspector;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterAttackMagnetAnnouncer(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_magnetMaxDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_inProgress;
  private static readonly System.IntPtr NativeFieldInfoPtr_distanceToTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InProgress_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InProgress_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceToTarget_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetType_Public_get_EnemyDataType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScanForTarget_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessMagnet_Public_Void_AttackObject_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MagnetToReceiver_Private_IEnumerator_AttackObject_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterAttackMagnetAnnouncer()
  {
    Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterAttackMagnetAnnouncer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr);
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (layerMask));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_magnetMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (magnetMaxDistance));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (Curve));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (animationController));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (rotationController));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (walkController));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_inProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (inProgress));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_distanceToTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (distanceToTarget));
    CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_targetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, nameof (targetType));
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_InProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677073);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_set_InProgress_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677074);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_DistanceToTarget_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677075);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_TargetType_Public_get_EnemyDataType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677076);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677077);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_ScanForTarget_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677078);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677079);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_ProcessMagnet_Public_Void_AttackObject_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677080);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677081);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_MagnetToReceiver_Private_IEnumerator_AttackObject_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677082);
    CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, 100677083);
  }

  public unsafe bool InProgress
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 67512, RefRangeEnd = 67513, XrefRangeStart = 67512, XrefRangeEnd = 67513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_InProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_set_InProgress_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float DistanceToTarget
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_DistanceToTarget_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EnemyData.EnemyDataType TargetType
  {
    [CallerCount(20), CachedScanResults(RefRangeStart = 74775, RefRangeEnd = 74795, XrefRangeStart = 74775, XrefRangeEnd = 74795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_get_TargetType_Public_get_EnemyDataType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EnemyData.EnemyDataType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128148, XrefRangeEnd = 128157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128179, RefRangeEnd = 128180, XrefRangeStart = 128157, XrefRangeEnd = 128179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScanForTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_ScanForTarget_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128180, XrefRangeEnd = 128206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SendAnnounce(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_SendAnnounce_Public_Virtual_Final_New_Void_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128206, XrefRangeEnd = 128211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessMagnet(AttackObject attack, Collider magnetTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) magnetTarget);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_ProcessMagnet_Public_Void_AttackObject_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128211, XrefRangeEnd = 128214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndAnnounce()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_EndAnnounce_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128214, XrefRangeEnd = 128218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator MagnetToReceiver(AttackObject attack, Collider magnetTarget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) magnetTarget);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr_MagnetToReceiver_Private_IEnumerator_AttackObject_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128218, XrefRangeEnd = 128220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterAttackMagnetAnnouncer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe float magnetMaxDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_magnetMaxDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_magnetMaxDistance)) = value;
    }
  }

  public unsafe AnimationCurve Curve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_Curve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool inProgress
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_inProgress));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_inProgress)) = value;
    }
  }

  public unsafe float distanceToTarget
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_distanceToTarget));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_distanceToTarget)) = value;
    }
  }

  public unsafe EnemyData.EnemyDataType targetType
  {
    get
    {
      return *(EnemyData.EnemyDataType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_targetType));
    }
    [param: In] set
    {
      *(EnemyData.EnemyDataType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer.NativeFieldInfoPtr_targetType)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterAttackMagnetAnnouncer+<MagnetToReceiver>d__21")]
  public sealed class _MagnetToReceiver_d__21(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_magnetTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_attack;
    private static readonly System.IntPtr NativeFieldInfoPtr__duration_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__rotation_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__start_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__target_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__prev_5__6;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__7;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _MagnetToReceiver_d__21()
    {
      Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer>.NativeClassPtr, "<MagnetToReceiver>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<>1__state");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<>2__current");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_magnetTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, nameof (magnetTarget));
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<>4__this");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, nameof (attack));
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__duration_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<duration>5__2");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__rotation_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<rotation>5__3");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__start_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<start>5__4");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__target_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<target>5__5");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__prev_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<prev>5__6");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__timer_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, "<timer>5__7");
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677084);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677085);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677086);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677087);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677088);
      CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr, 100677089);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _MagnetToReceiver_d__21(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128107, XrefRangeEnd = 128143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128143, XrefRangeEnd = 128148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Collider magnetTarget
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_magnetTarget));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_magnetTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CharacterAttackMagnetAnnouncer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterAttackMagnetAnnouncer) null : Il2CppObjectPool.Get<CharacterAttackMagnetAnnouncer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AttackObject attack
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_attack));
        return num == System.IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _duration_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__duration_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__duration_5__2)) = value;
      }
    }

    public unsafe int _rotation_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__rotation_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__rotation_5__3)) = value;
      }
    }

    public unsafe float _start_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__start_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__start_5__4)) = value;
      }
    }

    public unsafe float _target_5__5
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__target_5__5));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__target_5__5)) = value;
      }
    }

    public unsafe float _prev_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__prev_5__6));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__prev_5__6)) = value;
      }
    }

    public unsafe float _timer_5__7
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__timer_5__7));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterAttackMagnetAnnouncer._MagnetToReceiver_d__21.NativeFieldInfoPtr__timer_5__7)) = value;
      }
    }
  }
}
