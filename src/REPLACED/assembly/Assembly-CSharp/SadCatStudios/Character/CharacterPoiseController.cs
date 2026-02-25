// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterPoiseController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Combat;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterPoiseController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_blockThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_effectThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_staggerThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_poiseStateValue;
  private static readonly IntPtr NativeFieldInfoPtr_defaultPoiseState;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_attackSender;
  private static readonly IntPtr NativeFieldInfoPtr_armorController;
  private static readonly IntPtr NativeFieldInfoPtr_enemyData;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_EnemyData_State_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResolveConnection_Public_PoiseResolveType_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Poise_Public_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterPoiseController()
  {
    Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterPoiseController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr);
    CharacterPoiseController.NativeFieldInfoPtr_blockThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (blockThreshold));
    CharacterPoiseController.NativeFieldInfoPtr_effectThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (effectThreshold));
    CharacterPoiseController.NativeFieldInfoPtr_staggerThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (staggerThreshold));
    CharacterPoiseController.NativeFieldInfoPtr_poiseStateValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (poiseStateValue));
    CharacterPoiseController.NativeFieldInfoPtr_defaultPoiseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (defaultPoiseState));
    CharacterPoiseController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (stateController));
    CharacterPoiseController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (animationController));
    CharacterPoiseController.NativeFieldInfoPtr_attackSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (attackSender));
    CharacterPoiseController.NativeFieldInfoPtr_armorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (armorController));
    CharacterPoiseController.NativeFieldInfoPtr_enemyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, nameof (enemyData));
    CharacterPoiseController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, 100675472);
    CharacterPoiseController.NativeMethodInfoPtr_Init_Public_Void_EnemyData_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, 100675473);
    CharacterPoiseController.NativeMethodInfoPtr_ResolveConnection_Public_PoiseResolveType_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, 100675474);
    CharacterPoiseController.NativeMethodInfoPtr_Poise_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, 100675475);
    CharacterPoiseController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr, 100675476);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117713, XrefRangeEnd = 117725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPoiseController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 117744, RefRangeEnd = 117746, XrefRangeStart = 117725, XrefRangeEnd = 117744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(EnemyData enemyData, SadCatStudios.FSM.State defenceState)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enemyData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) defenceState);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPoiseController.NativeMethodInfoPtr_Init_Public_Void_EnemyData_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117746, XrefRangeEnd = 117752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterPoiseController.PoiseResolveType ResolveConnection(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterPoiseController.NativeMethodInfoPtr_ResolveConnection_Public_PoiseResolveType_AttackObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CharacterPoiseController.PoiseResolveType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 117757, RefRangeEnd = 117759, XrefRangeStart = 117752, XrefRangeEnd = 117757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float Poise()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterPoiseController.NativeMethodInfoPtr_Poise_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterPoiseController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterPoiseController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterPoiseController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int blockThreshold
  {
    get
    {
      int blockThreshold;
      IL2CPP.il2cpp_field_static_get_value(CharacterPoiseController.NativeFieldInfoPtr_blockThreshold, (void*) &blockThreshold);
      return blockThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterPoiseController.NativeFieldInfoPtr_blockThreshold, (void*) &value);
    }
  }

  public static unsafe int effectThreshold
  {
    get
    {
      int effectThreshold;
      IL2CPP.il2cpp_field_static_get_value(CharacterPoiseController.NativeFieldInfoPtr_effectThreshold, (void*) &effectThreshold);
      return effectThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterPoiseController.NativeFieldInfoPtr_effectThreshold, (void*) &value);
    }
  }

  public static unsafe int staggerThreshold
  {
    get
    {
      int staggerThreshold;
      IL2CPP.il2cpp_field_static_get_value(CharacterPoiseController.NativeFieldInfoPtr_staggerThreshold, (void*) &staggerThreshold);
      return staggerThreshold;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CharacterPoiseController.NativeFieldInfoPtr_staggerThreshold, (void*) &value);
    }
  }

  public unsafe StateValueDictionary poiseStateValue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_poiseStateValue));
      return num == IntPtr.Zero ? (StateValueDictionary) null : Il2CppObjectPool.Get<StateValueDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_poiseStateValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State defaultPoiseState
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_defaultPoiseState));
      return num == IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_defaultPoiseState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAttackSender attackSender
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_attackSender));
      return num == IntPtr.Zero ? (CharacterAttackSender) null : Il2CppObjectPool.Get<CharacterAttackSender>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_attackSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterArmorController armorController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_armorController));
      return num == IntPtr.Zero ? (CharacterArmorController) null : Il2CppObjectPool.Get<CharacterArmorController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_armorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnemyData enemyData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_enemyData));
      return num == IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterPoiseController.NativeFieldInfoPtr_enemyData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum PoiseResolveType
  {
    None,
    NoEffect,
    Block,
    Stagger,
    Launch,
  }
}
