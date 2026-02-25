// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.PressAnyButtonToJoinExample_GamePlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class PressAnyButtonToJoinExample_GamePlayer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerId;
  private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_cc;
  private static readonly IntPtr NativeFieldInfoPtr_moveVector;
  private static readonly IntPtr NativeFieldInfoPtr_fire;
  private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PressAnyButtonToJoinExample_GamePlayer()
  {
    Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (PressAnyButtonToJoinExample_GamePlayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr);
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (playerId));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (moveSpeed));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (bulletSpeed));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (bulletPrefab));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (cc));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (moveVector));
    PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, nameof (fire));
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670388);
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670389);
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670390);
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670391);
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670392);
    PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr, 100670393);
  }

  public unsafe Player player
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 83982, RefRangeEnd = 83989, XrefRangeStart = 83971, XrefRangeEnd = 83982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83989, XrefRangeEnd = 83992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83992, XrefRangeEnd = 84013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84013, XrefRangeEnd = 84025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_GetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84045, RefRangeEnd = 84046, XrefRangeStart = 84025, XrefRangeEnd = 84045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PressAnyButtonToJoinExample_GamePlayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressAnyButtonToJoinExample_GamePlayer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressAnyButtonToJoinExample_GamePlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe float moveSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe float bulletSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletSpeed)) = value;
    }
  }

  public unsafe GameObject bulletPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterController cc
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc));
      return num == IntPtr.Zero ? (CharacterController) null : Il2CppObjectPool.Get<CharacterController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 moveVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_moveVector)) = value;
    }
  }

  public unsafe bool fire
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressAnyButtonToJoinExample_GamePlayer.NativeFieldInfoPtr_fire)) = value;
    }
  }
}
