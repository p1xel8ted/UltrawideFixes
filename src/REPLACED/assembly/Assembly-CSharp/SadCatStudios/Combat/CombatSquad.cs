// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatSquad
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatSquad(System.IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pools;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Pools_Public_get_Il2CppReferenceArray_1_EnemyPoolConfig_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatSquad()
  {
    Il2CppClassPointerStore<CombatSquad>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatSquad));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr);
    CombatSquad.NativeFieldInfoPtr_pools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr, nameof (pools));
    CombatSquad.NativeMethodInfoPtr_get_Pools_Public_get_Il2CppReferenceArray_1_EnemyPoolConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr, 100677007);
    CombatSquad.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr, 100677008);
  }

  public unsafe Il2CppReferenceArray<CombatSquad.EnemyPoolConfig> Pools
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatSquad.NativeMethodInfoPtr_get_Pools_Public_get_Il2CppReferenceArray_1_EnemyPoolConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<CombatSquad.EnemyPoolConfig>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CombatSquad.EnemyPoolConfig>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatSquad()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatSquad.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<CombatSquad.EnemyPoolConfig> pools
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.NativeFieldInfoPtr_pools));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<CombatSquad.EnemyPoolConfig>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<CombatSquad.EnemyPoolConfig>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.NativeFieldInfoPtr_pools), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class EnemyPoolConfig(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Enemy;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalInPool;
    private static readonly System.IntPtr NativeFieldInfoPtr_AdditionalOutside;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnemyData;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static EnemyPoolConfig()
    {
      Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatSquad>.NativeClassPtr, nameof (EnemyPoolConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr);
      CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_Enemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr, nameof (Enemy));
      CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_TotalInPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr, nameof (TotalInPool));
      CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_AdditionalOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr, nameof (AdditionalOutside));
      CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_EnemyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr, nameof (EnemyData));
      CombatSquad.EnemyPoolConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr, 100677009);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnemyPoolConfig()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatSquad.EnemyPoolConfig>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatSquad.EnemyPoolConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject Enemy
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_Enemy));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_Enemy), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int TotalInPool
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_TotalInPool));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_TotalInPool)) = value;
      }
    }

    public unsafe int AdditionalOutside
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_AdditionalOutside));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_AdditionalOutside)) = value;
      }
    }

    public unsafe EnemyData EnemyData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_EnemyData));
        return num == System.IntPtr.Zero ? (EnemyData) null : Il2CppObjectPool.Get<EnemyData>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatSquad.EnemyPoolConfig.NativeFieldInfoPtr_EnemyData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
