// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.PlayerStateConditionSwitcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

public class PlayerStateConditionSwitcher(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly IntPtr NativeFieldInfoPtr_ifInFSM;
  private static readonly IntPtr NativeFieldInfoPtr_switchToFSM;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerStateConditionSwitcher()
  {
    Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (PlayerStateConditionSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr);
    PlayerStateConditionSwitcher.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr, nameof (playerReference));
    PlayerStateConditionSwitcher.NativeFieldInfoPtr_ifInFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr, nameof (ifInFSM));
    PlayerStateConditionSwitcher.NativeFieldInfoPtr_switchToFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr, nameof (switchToFSM));
    PlayerStateConditionSwitcher.NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr, 100671275);
    PlayerStateConditionSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr, 100671276);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92666, XrefRangeEnd = 92677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchDefaultState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStateConditionSwitcher.NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerStateConditionSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStateConditionSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStateConditionSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_playerReference));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph ifInFSM
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_ifInFSM));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_ifInFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph switchToFSM
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_switchToFSM));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateConditionSwitcher.NativeFieldInfoPtr_switchToFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
