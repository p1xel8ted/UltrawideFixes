// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatSequencerPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatSequencerPool(System.IntPtr pointer) : CombatSequencerBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_frontlineEnemiesTargetCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_poolCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_onPoolKilledCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_EnemiesPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_waitForContinue;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContinueCombatSequence_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatSequencerPool()
  {
    Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatSequencerPool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr);
    CombatSequencerPool.NativeFieldInfoPtr_frontlineEnemiesTargetCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, nameof (frontlineEnemiesTargetCount));
    CombatSequencerPool.NativeFieldInfoPtr_poolCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, nameof (poolCount));
    CombatSequencerPool.NativeFieldInfoPtr_onPoolKilledCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, nameof (onPoolKilledCallback));
    CombatSequencerPool.NativeFieldInfoPtr_EnemiesPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, nameof (EnemiesPool));
    CombatSequencerPool.NativeFieldInfoPtr_waitForContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, nameof (waitForContinue));
    CombatSequencerPool.NativeMethodInfoPtr_ContinueCombatSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, 100676962);
    CombatSequencerPool.NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, 100676963);
    CombatSequencerPool.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, 100676964);
    CombatSequencerPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, 100676965);
  }

  [CallerCount(0)]
  public unsafe void ContinueCombatSequence()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool.NativeMethodInfoPtr_ContinueCombatSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127333, XrefRangeEnd = 127337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IEnumerator WaitForDefeat(CombatZone combatZone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) combatZone)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerPool.NativeMethodInfoPtr_WaitForDefeat_Protected_Virtual_IEnumerator_CombatZone_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127337, XrefRangeEnd = 127358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void VisibleBacklineEnemies(List<EnemyCombatController> result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CombatSequencerPool.NativeMethodInfoPtr_VisibleBacklineEnemies_Public_Virtual_Void_List_1_EnemyCombatController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127358, XrefRangeEnd = 127359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatSequencerPool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int frontlineEnemiesTargetCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_frontlineEnemiesTargetCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_frontlineEnemiesTargetCount)) = value;
    }
  }

  public unsafe int poolCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_poolCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_poolCount)) = value;
    }
  }

  public unsafe UnityEvent onPoolKilledCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_onPoolKilledCallback));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_onPoolKilledCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<EnemyCombatController> EnemiesPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_EnemiesPool));
      return num == System.IntPtr.Zero ? (List<EnemyCombatController>) null : Il2CppObjectPool.Get<List<EnemyCombatController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_EnemiesPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool waitForContinue
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_waitForContinue));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool.NativeFieldInfoPtr_waitForContinue)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatSequencerPool+<WaitForDefeat>d__6")]
  public sealed class _WaitForDefeat_d__6(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_combatZone;
    private static readonly System.IntPtr NativeFieldInfoPtr__targetCount_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__index_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForDefeat_d__6()
    {
      Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatSequencerPool>.NativeClassPtr, "<WaitForDefeat>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr);
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, "<>1__state");
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, "<>2__current");
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, "<>4__this");
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr_combatZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, nameof (combatZone));
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__targetCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, "<targetCount>5__2");
      CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__index_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, "<index>5__3");
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676966);
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676967);
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676968);
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676969);
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676970);
      CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr, 100676971);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForDefeat_d__6(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSequencerPool._WaitForDefeat_d__6>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127292, XrefRangeEnd = 127328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127328, XrefRangeEnd = 127333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSequencerPool._WaitForDefeat_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatSequencerPool __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatSequencerPool) null : Il2CppObjectPool.Get<CombatSequencerPool>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatZone combatZone
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr_combatZone));
        return num == System.IntPtr.Zero ? (CombatZone) null : Il2CppObjectPool.Get<CombatZone>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr_combatZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _targetCount_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__targetCount_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__targetCount_5__2)) = value;
      }
    }

    public unsafe int _index_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__index_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSequencerPool._WaitForDefeat_d__6.NativeFieldInfoPtr__index_5__3)) = value;
      }
    }
  }
}
