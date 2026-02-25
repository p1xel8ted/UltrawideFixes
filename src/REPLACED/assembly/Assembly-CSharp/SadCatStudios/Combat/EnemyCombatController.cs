// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.EnemyCombatController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.Foundation;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class EnemyCombatController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_enemyData;
  private static readonly System.IntPtr NativeFieldInfoPtr_defenceState;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthController;
  private static readonly System.IntPtr NativeFieldInfoPtr_poiseController;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathController;
  private static readonly System.IntPtr NativeFieldInfoPtr_aiController;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_basePhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_setuper;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AIController_Public_get_CharacterAIController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitCombatData_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Activate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToFrontline_Public_Void_CombatSequencerBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToBackline_Public_Void_CombatSequencerBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EnemyCombatController()
  {
    Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (EnemyCombatController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr);
    EnemyCombatController.NativeFieldInfoPtr_enemyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (enemyData));
    EnemyCombatController.NativeFieldInfoPtr_defenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (defenceState));
    EnemyCombatController.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (saveData));
    EnemyCombatController.NativeFieldInfoPtr_healthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (healthController));
    EnemyCombatController.NativeFieldInfoPtr_poiseController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (poiseController));
    EnemyCombatController.NativeFieldInfoPtr_deathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (deathController));
    EnemyCombatController.NativeFieldInfoPtr_aiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (aiController));
    EnemyCombatController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (sensorController));
    EnemyCombatController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (stateController));
    EnemyCombatController.NativeFieldInfoPtr_basePhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (basePhysics));
    EnemyCombatController.NativeFieldInfoPtr_setuper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (setuper));
    EnemyCombatController.NativeMethodInfoPtr_get_AIController_Public_get_CharacterAIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677597);
    EnemyCombatController.NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677598);
    EnemyCombatController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677599);
    EnemyCombatController.NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677600);
    EnemyCombatController.NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677601);
    EnemyCombatController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677602);
    EnemyCombatController.NativeMethodInfoPtr_InitCombatData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677603);
    EnemyCombatController.NativeMethodInfoPtr_Activate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677604);
    EnemyCombatController.NativeMethodInfoPtr_MoveToFrontline_Public_Void_CombatSequencerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677605);
    EnemyCombatController.NativeMethodInfoPtr_MoveToBackline_Public_Void_CombatSequencerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677606);
    EnemyCombatController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677607);
    EnemyCombatController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677608);
    EnemyCombatController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677609);
    EnemyCombatController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, 100677610);
  }

  public unsafe CharacterAIController AIController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_get_AIController_Public_get_CharacterAIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num3);
    }
  }

  public unsafe EnemyData EnemyData
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_get_EnemyData_Public_get_EnemyData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num3);
    }
  }

  public unsafe bool IsDead
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 130768, RefRangeEnd = 130769, XrefRangeStart = 130768, XrefRangeEnd = 130768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_get_IsDead_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool OutsideEnemy
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 130769, RefRangeEnd = 130773, XrefRangeStart = 130769, XrefRangeEnd = 130769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_get_OutsideEnemy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool OnFrontline
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 130773, RefRangeEnd = 130776, XrefRangeStart = 130773, XrefRangeEnd = 130773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_get_OnFrontline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130776, XrefRangeEnd = 130812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130812, XrefRangeEnd = 130824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitCombatData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_InitCombatData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 130833, RefRangeEnd = 130837, XrefRangeStart = 130824, XrefRangeEnd = 130833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Activate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_Activate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130852, RefRangeEnd = 130853, XrefRangeStart = 130837, XrefRangeEnd = 130852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToFrontline(CombatSequencerBase combatSequencer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatSequencer)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_MoveToFrontline_Public_Void_CombatSequencerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84913, RefRangeEnd = 84914, XrefRangeStart = 84913, XrefRangeEnd = 84914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToBackline(CombatSequencerBase combatSequencerBase)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatSequencerBase)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_MoveToBackline_Public_Void_CombatSequencerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130853, XrefRangeEnd = 130857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130857, XrefRangeEnd = 130859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130859, XrefRangeEnd = 130879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130879, XrefRangeEnd = 130884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnemyCombatController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EnemyData enemyData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_enemyData));
      return num == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_enemyData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.FSM.State defenceState
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_defenceState));
      return num == System.IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_defenceState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnemyCombatController.EnemySaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (EnemyCombatController.EnemySaveData) null : Il2CppObjectPool.Get<EnemyCombatController.EnemySaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHealthController healthController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_healthController));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_healthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterPoiseController poiseController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_poiseController));
      return num == System.IntPtr.Zero ? (CharacterPoiseController) null : Il2CppObjectPool.Get<CharacterPoiseController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_poiseController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterDeathController deathController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_deathController));
      return num == System.IntPtr.Zero ? (CharacterDeathController) null : Il2CppObjectPool.Get<CharacterDeathController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_deathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIController aiController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_aiController));
      return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_aiController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BasePhysics basePhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_basePhysics));
      return num == System.IntPtr.Zero ? (BasePhysics) null : Il2CppObjectPool.Get<BasePhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_basePhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe NPCSetuper setuper
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_setuper));
      return num == System.IntPtr.Zero ? (NPCSetuper) null : Il2CppObjectPool.Get<NPCSetuper>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.NativeFieldInfoPtr_setuper), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class EnemySaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static EnemySaveData()
    {
      Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnemyCombatController>.NativeClassPtr, nameof (EnemySaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr);
      EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr, nameof (Position));
      EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr, nameof (Rotation));
      EnemyCombatController.EnemySaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr, 100677611);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnemySaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnemyCombatController.EnemySaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnemyCombatController.EnemySaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe Quaternion Rotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnemyCombatController.EnemySaveData.NativeFieldInfoPtr_Rotation)) = value;
      }
    }
  }
}
