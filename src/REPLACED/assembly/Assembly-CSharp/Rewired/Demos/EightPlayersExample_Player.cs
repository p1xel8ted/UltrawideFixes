// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.EightPlayersExample_Player
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

public class EightPlayersExample_Player(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerId;
  private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_bulletSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_bulletPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_player;
  private static readonly IntPtr NativeFieldInfoPtr_cc;
  private static readonly IntPtr NativeFieldInfoPtr_moveVector;
  private static readonly IntPtr NativeFieldInfoPtr_fire;
  private static readonly IntPtr NativeFieldInfoPtr_initialized;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInput_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessInput_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EightPlayersExample_Player()
  {
    Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (EightPlayersExample_Player));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr);
    EightPlayersExample_Player.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (playerId));
    EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (moveSpeed));
    EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (bulletSpeed));
    EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (bulletPrefab));
    EightPlayersExample_Player.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (player));
    EightPlayersExample_Player.NativeFieldInfoPtr_cc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (cc));
    EightPlayersExample_Player.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (moveVector));
    EightPlayersExample_Player.NativeFieldInfoPtr_fire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (fire));
    EightPlayersExample_Player.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, nameof (initialized));
    EightPlayersExample_Player.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670340);
    EightPlayersExample_Player.NativeMethodInfoPtr_Initialize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670341);
    EightPlayersExample_Player.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670342);
    EightPlayersExample_Player.NativeMethodInfoPtr_GetInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670343);
    EightPlayersExample_Player.NativeMethodInfoPtr_ProcessInput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670344);
    EightPlayersExample_Player.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr, 100670345);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83352, XrefRangeEnd = 83355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83355, XrefRangeEnd = 83360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Initialize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83360, XrefRangeEnd = 83382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83382, XrefRangeEnd = 83391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_GetInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 83411, RefRangeEnd = 83412, XrefRangeStart = 83391, XrefRangeEnd = 83411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessInput()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr_ProcessInput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83412, XrefRangeEnd = 83413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EightPlayersExample_Player()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EightPlayersExample_Player>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EightPlayersExample_Player.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe float moveSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe float bulletSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletSpeed)) = value;
    }
  }

  public unsafe GameObject bulletPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_bulletPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Player player
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_player));
      return num == IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterController cc
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_cc));
      return num == IntPtr.Zero ? (CharacterController) null : Il2CppObjectPool.Get<CharacterController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_cc), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 moveVector
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveVector));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_moveVector)) = value;
    }
  }

  public unsafe bool fire
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_fire));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_fire)) = value;
    }
  }

  public unsafe bool initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EightPlayersExample_Player.NativeFieldInfoPtr_initialized)) = value;
    }
  }
}
