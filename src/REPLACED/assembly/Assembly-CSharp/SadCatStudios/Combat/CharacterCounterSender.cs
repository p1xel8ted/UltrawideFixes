// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterCounterSender
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

public class CharacterCounterSender(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_counterAttackData;
  private static readonly IntPtr NativeFieldInfoPtr_perfectAttackData;
  private static readonly IntPtr NativeFieldInfoPtr_dodgeAttackData;
  private static readonly IntPtr NativeFieldInfoPtr_counterFallback;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_counterCaster;
  private static readonly IntPtr NativeFieldInfoPtr_feedbackHandler;
  private static readonly IntPtr NativeFieldInfoPtr_statsControllers;
  private static readonly IntPtr NativeFieldInfoPtr_counterAttackObject;
  private static readonly IntPtr NativeFieldInfoPtr_dodgeAttackObject;
  private static readonly IntPtr NativeFieldInfoPtr_perfectAttackObject;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectCounter_Private_Void_CounterCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_CounterScan_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterCounterSender()
  {
    Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterCounterSender));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr);
    CharacterCounterSender.NativeFieldInfoPtr_counterAttackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (counterAttackData));
    CharacterCounterSender.NativeFieldInfoPtr_perfectAttackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (perfectAttackData));
    CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (dodgeAttackData));
    CharacterCounterSender.NativeFieldInfoPtr_counterFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (counterFallback));
    CharacterCounterSender.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (stateController));
    CharacterCounterSender.NativeFieldInfoPtr_counterCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (counterCaster));
    CharacterCounterSender.NativeFieldInfoPtr_feedbackHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (feedbackHandler));
    CharacterCounterSender.NativeFieldInfoPtr_statsControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (statsControllers));
    CharacterCounterSender.NativeFieldInfoPtr_counterAttackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (counterAttackObject));
    CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (dodgeAttackObject));
    CharacterCounterSender.NativeFieldInfoPtr_perfectAttackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, nameof (perfectAttackObject));
    CharacterCounterSender.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, 100677310);
    CharacterCounterSender.NativeMethodInfoPtr_ConnectCounter_Private_Void_CounterCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, 100677311);
    CharacterCounterSender.NativeMethodInfoPtr_CounterScan_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, 100677312);
    CharacterCounterSender.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr, 100677313);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129350, XrefRangeEnd = 129372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCounterSender.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129372, XrefRangeEnd = 129383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ConnectCounter(CounterCastResult counterCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) counterCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCounterSender.NativeMethodInfoPtr_ConnectCounter_Private_Void_CounterCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 129396, RefRangeEnd = 129397, XrefRangeStart = 129383, XrefRangeEnd = 129396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CounterScan()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCounterSender.NativeMethodInfoPtr_CounterScan_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterCounterSender()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCounterSender>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCounterSender.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AttackData counterAttackData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterAttackData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterAttackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData perfectAttackData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_perfectAttackData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_perfectAttackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData dodgeAttackData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph counterFallback
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterFallback));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterFallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICounterCaster counterCaster
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterCaster));
      return num == IntPtr.Zero ? (ICounterCaster) null : Il2CppObjectPool.Get<ICounterCaster>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterCaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICounterFeedbackHandler feedbackHandler
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_feedbackHandler));
      return num == IntPtr.Zero ? (ICounterFeedbackHandler) null : Il2CppObjectPool.Get<ICounterFeedbackHandler>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_feedbackHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ICombatStatsController> statsControllers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_statsControllers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ICombatStatsController>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ICombatStatsController>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_statsControllers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject counterAttackObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterAttackObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_counterAttackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject dodgeAttackObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_dodgeAttackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject perfectAttackObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_perfectAttackObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCounterSender.NativeFieldInfoPtr_perfectAttackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
