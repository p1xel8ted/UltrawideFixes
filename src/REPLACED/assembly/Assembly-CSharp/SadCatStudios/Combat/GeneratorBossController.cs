// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GeneratorBossController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.Timeline;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Combat;

public class GeneratorBossController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_combatZone;
  private static readonly IntPtr NativeFieldInfoPtr_hiddenDelay;
  private static readonly IntPtr NativeFieldInfoPtr_lifetime;
  private static readonly IntPtr NativeFieldInfoPtr_maxDamagePerAppearance;
  private static readonly IntPtr NativeFieldInfoPtr_commissionerController;
  private static readonly IntPtr NativeFieldInfoPtr_commissionerAppearanceHealthPercentage;
  private static readonly IntPtr NativeFieldInfoPtr_openTimeline;
  private static readonly IntPtr NativeFieldInfoPtr_closeTimeline;
  private static readonly IntPtr NativeFieldInfoPtr_attackCycle;
  private static readonly IntPtr NativeFieldInfoPtr_appearAttack;
  private static readonly IntPtr NativeFieldInfoPtr_areaAttack;
  private static readonly IntPtr NativeFieldInfoPtr_deathZone;
  private static readonly IntPtr NativeFieldInfoPtr_exitTimelineBinder;
  private static readonly IntPtr NativeFieldInfoPtr_deathController;
  private static readonly IntPtr NativeFieldInfoPtr_healthController;
  private static readonly IntPtr NativeFieldInfoPtr_aiController;
  private static readonly IntPtr NativeFieldInfoPtr_healthTracker;
  private static readonly IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly IntPtr NativeFieldInfoPtr_boundariesController;
  private static readonly IntPtr NativeFieldInfoPtr_timer;
  private static readonly IntPtr NativeFieldInfoPtr_attackTimer;
  private static readonly IntPtr NativeFieldInfoPtr_healthThisAppearance;
  private static readonly IntPtr NativeFieldInfoPtr_attack;
  private static readonly IntPtr NativeFieldInfoPtr_isActive;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetCommissioner_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_EnableCommissioner_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GeneratorBossController()
  {
    Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GeneratorBossController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr);
    GeneratorBossController.NativeFieldInfoPtr_combatZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (combatZone));
    GeneratorBossController.NativeFieldInfoPtr_hiddenDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (hiddenDelay));
    GeneratorBossController.NativeFieldInfoPtr_lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (lifetime));
    GeneratorBossController.NativeFieldInfoPtr_maxDamagePerAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (maxDamagePerAppearance));
    GeneratorBossController.NativeFieldInfoPtr_commissionerController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (commissionerController));
    GeneratorBossController.NativeFieldInfoPtr_commissionerAppearanceHealthPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (commissionerAppearanceHealthPercentage));
    GeneratorBossController.NativeFieldInfoPtr_openTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (openTimeline));
    GeneratorBossController.NativeFieldInfoPtr_closeTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (closeTimeline));
    GeneratorBossController.NativeFieldInfoPtr_attackCycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (attackCycle));
    GeneratorBossController.NativeFieldInfoPtr_appearAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (appearAttack));
    GeneratorBossController.NativeFieldInfoPtr_areaAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (areaAttack));
    GeneratorBossController.NativeFieldInfoPtr_deathZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (deathZone));
    GeneratorBossController.NativeFieldInfoPtr_exitTimelineBinder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (exitTimelineBinder));
    GeneratorBossController.NativeFieldInfoPtr_deathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (deathController));
    GeneratorBossController.NativeFieldInfoPtr_healthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (healthController));
    GeneratorBossController.NativeFieldInfoPtr_aiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (aiController));
    GeneratorBossController.NativeFieldInfoPtr_healthTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (healthTracker));
    GeneratorBossController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (hitboxController));
    GeneratorBossController.NativeFieldInfoPtr_boundariesController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (boundariesController));
    GeneratorBossController.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (timer));
    GeneratorBossController.NativeFieldInfoPtr_attackTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (attackTimer));
    GeneratorBossController.NativeFieldInfoPtr_healthThisAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (healthThisAppearance));
    GeneratorBossController.NativeFieldInfoPtr_attack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (attack));
    GeneratorBossController.NativeFieldInfoPtr_isActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, nameof (isActive));
    GeneratorBossController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676895);
    GeneratorBossController.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676896);
    GeneratorBossController.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676897);
    GeneratorBossController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676898);
    GeneratorBossController.NativeMethodInfoPtr_ResetCommissioner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676899);
    GeneratorBossController.NativeMethodInfoPtr_EnableCommissioner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676900);
    GeneratorBossController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676901);
    GeneratorBossController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr, 100676902);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126681, XrefRangeEnd = 126703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126703, XrefRangeEnd = 126709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Open()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126717, RefRangeEnd = 126718, XrefRangeStart = 126709, XrefRangeEnd = 126717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Close(bool quick = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &quick
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126718, XrefRangeEnd = 126738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126738, XrefRangeEnd = 126741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetCommissioner()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_ResetCommissioner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126741, XrefRangeEnd = 126751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableCommissioner()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_EnableCommissioner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126751, XrefRangeEnd = 126758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126758, XrefRangeEnd = 126759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GeneratorBossController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GeneratorBossController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GeneratorBossController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CombatSequencerPool combatZone
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_combatZone));
      return num == IntPtr.Zero ? (CombatSequencerPool) null : Il2CppObjectPool.Get<CombatSequencerPool>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_combatZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float hiddenDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_hiddenDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_hiddenDelay)) = value;
    }
  }

  public unsafe float lifetime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_lifetime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_lifetime)) = value;
    }
  }

  public unsafe int maxDamagePerAppearance
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_maxDamagePerAppearance));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_maxDamagePerAppearance)) = value;
    }
  }

  public unsafe GeneratorBossCommissionerController commissionerController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_commissionerController));
      return num == IntPtr.Zero ? (GeneratorBossCommissionerController) null : Il2CppObjectPool.Get<GeneratorBossCommissionerController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_commissionerController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int commissionerAppearanceHealthPercentage
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_commissionerAppearanceHealthPercentage));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_commissionerAppearanceHealthPercentage)) = value;
    }
  }

  public unsafe PlayableDirector openTimeline
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_openTimeline));
      return num == IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_openTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableDirector closeTimeline
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_closeTimeline));
      return num == IntPtr.Zero ? (PlayableDirector) null : Il2CppObjectPool.Get<PlayableDirector>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_closeTimeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float attackCycle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attackCycle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attackCycle)) = value;
    }
  }

  public unsafe GunData appearAttack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_appearAttack));
      return num == IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_appearAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GunData areaAttack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_areaAttack));
      return num == IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_areaAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject deathZone
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_deathZone));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_deathZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TimelineBinder exitTimelineBinder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_exitTimelineBinder));
      return num == IntPtr.Zero ? (TimelineBinder) null : Il2CppObjectPool.Get<TimelineBinder>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_exitTimelineBinder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterDeathController deathController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_deathController));
      return num == IntPtr.Zero ? (CharacterDeathController) null : Il2CppObjectPool.Get<CharacterDeathController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_deathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHealthController healthController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthController));
      return num == IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController aiController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_aiController));
      return num == IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_aiController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BossHealthTracker healthTracker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthTracker));
      return num == IntPtr.Zero ? (BossHealthTracker) null : Il2CppObjectPool.Get<BossHealthTracker>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthTracker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_hitboxController));
      return num == IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterBoundariesController boundariesController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_boundariesController));
      return num == IntPtr.Zero ? (CharacterBoundariesController) null : Il2CppObjectPool.Get<CharacterBoundariesController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_boundariesController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe float attackTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attackTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attackTimer)) = value;
    }
  }

  public unsafe float healthThisAppearance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthThisAppearance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_healthThisAppearance)) = value;
    }
  }

  public unsafe AttackObject attack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attack));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_attack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_isActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GeneratorBossController.NativeFieldInfoPtr_isActive)) = value;
    }
  }
}
