// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.PressStartToJoinExample_Assigner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class PressStartToJoinExample_Assigner(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerIdCounter;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PressStartToJoinExample_Assigner()
  {
    Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (PressStartToJoinExample_Assigner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr);
    PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, nameof (instance));
    PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, nameof (maxPlayers));
    PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, nameof (playerMap));
    PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, nameof (gamePlayerIdCounter));
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670394);
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670395);
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670396);
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670397);
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670398);
    PressStartToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, 100670399);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 84079, RefRangeEnd = 84087, XrefRangeStart = 84046, XrefRangeEnd = 84079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Player GetRewiredPlayer(int gamePlayerId)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &gamePlayerId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetRewiredPlayer_Public_Static_Player_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84087, XrefRangeEnd = 84095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84095, XrefRangeEnd = 84109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84141, RefRangeEnd = 84142, XrefRangeStart = 84109, XrefRangeEnd = 84141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignNextPlayer(int rewiredPlayerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rewiredPlayerId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_AssignNextPlayer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe int GetNextGamePlayerId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr_GetNextGamePlayerId_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84142, XrefRangeEnd = 84143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PressStartToJoinExample_Assigner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe PressStartToJoinExample_Assigner instance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (PressStartToJoinExample_Assigner) null : Il2CppObjectPool.Get<PressStartToJoinExample_Assigner>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int maxPlayers
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_maxPlayers)) = value;
    }
  }

  public unsafe List<PressStartToJoinExample_Assigner.PlayerMap> playerMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap));
      return num == System.IntPtr.Zero ? (List<PressStartToJoinExample_Assigner.PlayerMap>) null : Il2CppObjectPool.Get<List<PressStartToJoinExample_Assigner.PlayerMap>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_playerMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int gamePlayerIdCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.NativeFieldInfoPtr_gamePlayerIdCounter)) = value;
    }
  }

  public class PlayerMap(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rewiredPlayerId;
    private static readonly System.IntPtr NativeFieldInfoPtr_gamePlayerId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

    static PlayerMap()
    {
      Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PressStartToJoinExample_Assigner>.NativeClassPtr, nameof (PlayerMap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr);
      PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, nameof (rewiredPlayerId));
      PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, nameof (gamePlayerId));
      PressStartToJoinExample_Assigner.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr, 100670400);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerMap(int rewiredPlayerId, int gamePlayerId)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PressStartToJoinExample_Assigner.PlayerMap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rewiredPlayerId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &gamePlayerId;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PressStartToJoinExample_Assigner.PlayerMap.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int rewiredPlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_rewiredPlayerId)) = value;
      }
    }

    public unsafe int gamePlayerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PressStartToJoinExample_Assigner.PlayerMap.NativeFieldInfoPtr_gamePlayerId)) = value;
      }
    }
  }
}
