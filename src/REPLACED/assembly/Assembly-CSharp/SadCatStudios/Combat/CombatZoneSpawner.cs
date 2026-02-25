// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatZoneSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatZoneSpawner(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_depthOffsetMin;
  private static readonly IntPtr NativeFieldInfoPtr_depthOffsetMax;
  private static readonly IntPtr NativeFieldInfoPtr_spawnerCooldown;
  private static readonly IntPtr NativeFieldInfoPtr_lastSpawnTime;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CanSpawn_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_DistanceToPlayer_Public_Single_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_Spawn_Public_GameObject_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatZoneSpawner()
  {
    Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatZoneSpawner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr);
    CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, nameof (depthOffsetMin));
    CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, nameof (depthOffsetMax));
    CombatZoneSpawner.NativeFieldInfoPtr_spawnerCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, nameof (spawnerCooldown));
    CombatZoneSpawner.NativeFieldInfoPtr_lastSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, nameof (lastSpawnTime));
    CombatZoneSpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, 100677041);
    CombatZoneSpawner.NativeMethodInfoPtr_get_CanSpawn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, 100677042);
    CombatZoneSpawner.NativeMethodInfoPtr_DistanceToPlayer_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, 100677043);
    CombatZoneSpawner.NativeMethodInfoPtr_Spawn_Public_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, 100677044);
    CombatZoneSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr, 100677045);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127872, XrefRangeEnd = 127883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZoneSpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool CanSpawn
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127883, XrefRangeEnd = 127884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneSpawner.NativeMethodInfoPtr_get_CanSpawn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127884, XrefRangeEnd = 127889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float DistanceToPlayer(Vector3 playerPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &playerPos
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneSpawner.NativeMethodInfoPtr_DistanceToPlayer_Public_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127889, XrefRangeEnd = 127907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject Spawn(GameObject toSpawn)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) toSpawn)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneSpawner.NativeMethodInfoPtr_Spawn_Public_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatZoneSpawner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatZoneSpawner>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZoneSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference depthOffsetMin
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMin));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference depthOffsetMax
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMax));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_depthOffsetMax), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float spawnerCooldown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_spawnerCooldown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_spawnerCooldown)) = value;
    }
  }

  public unsafe float lastSpawnTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_lastSpawnTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneSpawner.NativeFieldInfoPtr_lastSpawnTime)) = value;
    }
  }
}
