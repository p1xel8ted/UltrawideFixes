// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatSequencerBudget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Character;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatSequencerBudget(System.IntPtr pointer) : CombatSequencerBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Enemies;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxBudget;
  private static readonly System.IntPtr NativeFieldInfoPtr_combatBudget;
  private static readonly System.IntPtr NativeFieldInfoPtr_minBudget;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerHealthController;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrontlineCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BacklineCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CombatBudget_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrontlineBudget_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BacklineBudget_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasEnoughFrontlineAgents_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FrontlineCycle_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatSequencerBudget()
  {
    Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatSequencerBudget));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr);
    CombatSequencerBudget.NativeFieldInfoPtr_Enemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (Enemies));
    CombatSequencerBudget.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (playerReference));
    CombatSequencerBudget.NativeFieldInfoPtr_maxBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (maxBudget));
    CombatSequencerBudget.NativeFieldInfoPtr_combatBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (combatBudget));
    CombatSequencerBudget.NativeFieldInfoPtr_minBudget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (minBudget));
    CombatSequencerBudget.NativeFieldInfoPtr_playerHealthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, nameof (playerHealthController));
    CombatSequencerBudget.NativeMethodInfoPtr_get_FrontlineCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676935);
    CombatSequencerBudget.NativeMethodInfoPtr_get_BacklineCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676936);
    CombatSequencerBudget.NativeMethodInfoPtr_get_CombatBudget_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676937);
    CombatSequencerBudget.NativeMethodInfoPtr_get_FrontlineBudget_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676938);
    CombatSequencerBudget.NativeMethodInfoPtr_get_BacklineBudget_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676939);
    CombatSequencerBudget.NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676940);
    CombatSequencerBudget.NativeMethodInfoPtr_HasEnoughFrontlineAgents_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676941);
    CombatSequencerBudget.NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676942);
    CombatSequencerBudget.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676943);
    CombatSequencerBudget.NativeMethodInfoPtr_FrontlineCycle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676944);
    CombatSequencerBudget.NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676945);
    CombatSequencerBudget.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676946);
    CombatSequencerBudget.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, 100676947);
  }

  public unsafe int FrontlineCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127236, XrefRangeEnd = 127237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_get_FrontlineCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BacklineCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127237, XrefRangeEnd = 127238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_get_BacklineCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int CombatBudget
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_get_CombatBudget_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int FrontlineBudget
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127238, XrefRangeEnd = 127239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_get_FrontlineBudget_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int BacklineBudget
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127239, XrefRangeEnd = 127240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_get_BacklineBudget_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127240, XrefRangeEnd = 127244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnemyCombatController BacklineEnemy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127244, XrefRangeEnd = 127246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasEnoughFrontlineAgents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_HasEnoughFrontlineAgents_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127246, XrefRangeEnd = 127248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EnemyCombatController BacklineEnemy(int budget)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &budget
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_BacklineEnemy_Private_EnemyCombatController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (EnemyCombatController) null : Il2CppObjectPool.Get<EnemyCombatController>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127248, XrefRangeEnd = 127252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127252, XrefRangeEnd = 127262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FrontlineCycle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr_FrontlineCycle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127262, XrefRangeEnd = 127266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator WaitForDefeat(CombatZone combatZone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatZone)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerBudget.NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127266, XrefRangeEnd = 127288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void VisibleBacklineEnemies(List<EnemyCombatController> result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerBudget.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127288, XrefRangeEnd = 127289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatSequencerBudget()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EnemiesDictionary Enemies
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_Enemies));
      return num == System.IntPtr.Zero ? (EnemiesDictionary) null : Il2CppObjectPool.Get<EnemiesDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_Enemies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_playerReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int maxBudget
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_maxBudget));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_maxBudget)) = value;
    }
  }

  public unsafe int combatBudget
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_combatBudget));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_combatBudget)) = value;
    }
  }

  public unsafe int minBudget
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_minBudget));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_minBudget)) = value;
    }
  }

  public unsafe CharacterHealthController playerHealthController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_playerHealthController));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget.NativeFieldInfoPtr_playerHealthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatSequencerBudget+<Start>d__19")]
  public sealed class _Start_d__19(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Start_d__19()
    {
      Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, "<Start>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr);
      CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, "<>1__state");
      CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, "<>2__current");
      CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, "<>4__this");
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676948);
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676949);
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676950);
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676951);
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676952);
      CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr, 100676953);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__19(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerBudget._Start_d__19>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127169, XrefRangeEnd = 127175, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127175, XrefRangeEnd = 127180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._Start_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatSequencerBudget __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatSequencerBudget) null : Il2CppObjectPool.Get<CombatSequencerBudget>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._Start_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatSequencerBudget+<WaitForDefeat>d__21")]
  public sealed class _WaitForDefeat_d__21(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_combatZone;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForDefeat_d__21()
    {
      Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatSequencerBudget>.NativeClassPtr, "<WaitForDefeat>d__21");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, "<>1__state");
      CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, "<>2__current");
      CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, "<>4__this");
      CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr_combatZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, nameof (combatZone));
      CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, "<>7__wrap1");
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676954);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676955);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676956);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676957);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676958);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676959);
      CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr, 100676960);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForDefeat_d__21(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerBudget._WaitForDefeat_d__21>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 127185, RefRangeEnd = 127187, XrefRangeStart = 127180, XrefRangeEnd = 127185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127187, XrefRangeEnd = 127228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127228, XrefRangeEnd = 127231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void __m__Finally1()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127231, XrefRangeEnd = 127236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerBudget._WaitForDefeat_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatSequencerBudget __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatSequencerBudget) null : Il2CppObjectPool.Get<CombatSequencerBudget>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatZone combatZone
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr_combatZone));
        return num == System.IntPtr.Zero ? (CombatZone) null : Il2CppObjectPool.Get<CombatZone>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr_combatZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public Dictionary<EnemyCombatController, bool>.Enumerator __7__wrap1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___7__wrap1);
        return new Dictionary<EnemyCombatController, bool>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<EnemyCombatController, bool>.Enumerator>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerBudget._WaitForDefeat_d__21.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<EnemyCombatController, bool>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
