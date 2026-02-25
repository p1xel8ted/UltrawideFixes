// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class InvadersRow(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_invaderPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_invadersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_leadingRow;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectile;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectilesPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_invaders;
  private static readonly System.IntPtr NativeFieldInfoPtr_formationMovement;
  private static readonly System.IntPtr NativeFieldInfoPtr_leftmostIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_rightmostIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_LeftEdge_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RightEdge_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InvadersInRow_Public_get_List_1_InvadersEnemyController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InvadersActiveCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_InvadersWaveMovement_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RespawnRow_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AnimateRow_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveRow_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetAtPos_Public_Boolean_Vector3_byref_InvadersEnemyController_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unregister_Public_Void_InvadersEnemyController_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearRow_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersRow()
  {
    Il2CppClassPointerStore<InvadersRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersRow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr);
    InvadersRow.NativeFieldInfoPtr_invaderPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (invaderPrefab));
    InvadersRow.NativeFieldInfoPtr_invadersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (invadersCount));
    InvadersRow.NativeFieldInfoPtr_leadingRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (leadingRow));
    InvadersRow.NativeFieldInfoPtr_projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (projectile));
    InvadersRow.NativeFieldInfoPtr_projectilesPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (projectilesPool));
    InvadersRow.NativeFieldInfoPtr_invaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (invaders));
    InvadersRow.NativeFieldInfoPtr_formationMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (formationMovement));
    InvadersRow.NativeFieldInfoPtr_leftmostIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (leftmostIndex));
    InvadersRow.NativeFieldInfoPtr_rightmostIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, nameof (rightmostIndex));
    InvadersRow.NativeMethodInfoPtr_LeftEdge_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676640);
    InvadersRow.NativeMethodInfoPtr_RightEdge_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676641);
    InvadersRow.NativeMethodInfoPtr_get_InvadersInRow_Public_get_List_1_InvadersEnemyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676642);
    InvadersRow.NativeMethodInfoPtr_get_InvadersActiveCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676643);
    InvadersRow.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676644);
    InvadersRow.NativeMethodInfoPtr_Init_Public_Void_InvadersWaveMovement_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676645);
    InvadersRow.NativeMethodInfoPtr_RespawnRow_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676646);
    InvadersRow.NativeMethodInfoPtr_AnimateRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676647);
    InvadersRow.NativeMethodInfoPtr_MoveRow_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676648);
    InvadersRow.NativeMethodInfoPtr_Shoot_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676649);
    InvadersRow.NativeMethodInfoPtr_GetAtPos_Public_Boolean_Vector3_byref_InvadersEnemyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676650);
    InvadersRow.NativeMethodInfoPtr_Unregister_Public_Void_InvadersEnemyController_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676651);
    InvadersRow.NativeMethodInfoPtr_ClearRow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676652);
    InvadersRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, 100676653);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124993, RefRangeEnd = 124994, XrefRangeStart = 124991, XrefRangeEnd = 124993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool LeftEdge()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_LeftEdge_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124996, RefRangeEnd = 124997, XrefRangeStart = 124994, XrefRangeEnd = 124996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RightEdge()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_RightEdge_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe List<InvadersEnemyController> InvadersInRow
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_get_InvadersInRow_Public_get_List_1_InvadersEnemyController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<InvadersEnemyController>) null : Il2CppObjectPool.Get<List<InvadersEnemyController>>(num3);
    }
  }

  public unsafe int InvadersActiveCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_get_InvadersActiveCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124997, XrefRangeEnd = 124999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 125071, RefRangeEnd = 125073, XrefRangeStart = 124999, XrefRangeEnd = 125071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(InvadersWaveMovement formationMovement, int spriteIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formationMovement);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &spriteIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_Init_Public_Void_InvadersWaveMovement_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125073, XrefRangeEnd = 125077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RespawnRow(float verticalOffset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &verticalOffset
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_RespawnRow_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125077, XrefRangeEnd = 125083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AnimateRow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_AnimateRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 125091, RefRangeEnd = 125093, XrefRangeStart = 125083, XrefRangeEnd = 125091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveRow(Vector3 delta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &delta
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_MoveRow_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125093, XrefRangeEnd = 125095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shoot(Vector3 pos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pos
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_Shoot_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125095, XrefRangeEnd = 125113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetAtPos(Vector3 pos, out InvadersEnemyController result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = (System.IntPtr) &pos;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_GetAtPos_Public_Boolean_Vector3_byref_InvadersEnemyController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref InvadersEnemyController local = ref result;
    System.IntPtr pointer = zero;
    InvadersEnemyController invadersEnemyController = pointer == System.IntPtr.Zero ? (InvadersEnemyController) null : new InvadersEnemyController(pointer);
    local = invadersEnemyController;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 125129, RefRangeEnd = 125130, XrefRangeStart = 125113, XrefRangeEnd = 125129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unregister(
    InvadersEnemyController invadersEnemyController,
    bool isLeadingFormation)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) invadersEnemyController);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isLeadingFormation;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_Unregister_Public_Void_InvadersEnemyController_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 125146, RefRangeEnd = 125148, XrefRangeStart = 125130, XrefRangeEnd = 125146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearRow()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr_ClearRow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125148, XrefRangeEnd = 125153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersRow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject invaderPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invaderPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invaderPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int invadersCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invadersCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invadersCount)) = value;
    }
  }

  public unsafe bool leadingRow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_leadingRow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_leadingRow)) = value;
    }
  }

  public unsafe PoolableObject projectile
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_projectile));
      return num == System.IntPtr.Zero ? (PoolableObject) null : Il2CppObjectPool.Get<PoolableObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_projectile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool projectilesPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_projectilesPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_projectilesPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<InvadersEnemyController> invaders
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invaders));
      return num == System.IntPtr.Zero ? (List<InvadersEnemyController>) null : Il2CppObjectPool.Get<List<InvadersEnemyController>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_invaders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe InvadersWaveMovement formationMovement
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_formationMovement));
      return num == System.IntPtr.Zero ? (InvadersWaveMovement) null : Il2CppObjectPool.Get<InvadersWaveMovement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_formationMovement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int leftmostIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_leftmostIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_leftmostIndex)) = value;
    }
  }

  public unsafe int rightmostIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_rightmostIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.NativeFieldInfoPtr_rightmostIndex)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersRow+<>c__DisplayClass21_0")]
  public sealed class __c__DisplayClass21_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_pos;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetAtPos_b__0_Internal_Boolean_InvadersEnemyController_0;

    static __c__DisplayClass21_0()
    {
      Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, "<>c__DisplayClass21_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr);
      InvadersRow.__c__DisplayClass21_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr, nameof (pos));
      InvadersRow.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr, 100676654);
      InvadersRow.__c__DisplayClass21_0.NativeMethodInfoPtr__GetAtPos_b__0_Internal_Boolean_InvadersEnemyController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr, 100676655);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass21_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersRow.__c__DisplayClass21_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersRow.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124950, XrefRangeEnd = 124954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool _GetAtPos_b__0(InvadersEnemyController i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) i)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InvadersRow.__c__DisplayClass21_0.NativeMethodInfoPtr__GetAtPos_b__0_Internal_Boolean_InvadersEnemyController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe Vector3 pos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.__c__DisplayClass21_0.NativeFieldInfoPtr_pos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow.__c__DisplayClass21_0.NativeFieldInfoPtr_pos)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersRow+<RespawnRow>d__17")]
  public sealed class _RespawnRow_d__17 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_verticalOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RespawnRow_d__17()
    {
      Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersRow>.NativeClassPtr, "<RespawnRow>d__17");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr);
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, "<>1__state");
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, "<>t__builder");
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, "<>4__this");
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr_verticalOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, nameof (verticalOffset));
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, "<>7__wrap1");
      InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, "<>u__1");
      InvadersRow._RespawnRow_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, 100676656);
      InvadersRow._RespawnRow_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr, 100676657);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124954, XrefRangeEnd = 124991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersRow._RespawnRow_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersRow._RespawnRow_d__17.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RespawnRow_d__17(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RespawnRow_d__17()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersRow._RespawnRow_d__17>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InvadersRow __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InvadersRow) null : Il2CppObjectPool.Get<InvadersRow>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float verticalOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr_verticalOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr_verticalOffset)) = value;
      }
    }

    public List<InvadersEnemyController>.Enumerator __7__wrap1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___7__wrap1);
        return new List<InvadersEnemyController>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<InvadersEnemyController>.Enumerator>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<InvadersEnemyController>.Enumerator>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersRow._RespawnRow_d__17.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
