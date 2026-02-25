// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.PlayerStateSwitcher
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

public class PlayerStateSwitcher(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly IntPtr NativeFieldInfoPtr_graphFSM;
  private static readonly IntPtr NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerStateSwitcher()
  {
    Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (PlayerStateSwitcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr);
    PlayerStateSwitcher.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr, nameof (playerReference));
    PlayerStateSwitcher.NativeFieldInfoPtr_graphFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr, nameof (graphFSM));
    PlayerStateSwitcher.NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr, 100671277);
    PlayerStateSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr, 100671278);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92677, XrefRangeEnd = 92686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SwitchDefaultState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStateSwitcher.NativeMethodInfoPtr_SwitchDefaultState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerStateSwitcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerStateSwitcher>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStateSwitcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateSwitcher.NativeFieldInfoPtr_playerReference));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateSwitcher.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph graphFSM
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateSwitcher.NativeFieldInfoPtr_graphFSM));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerStateSwitcher.NativeFieldInfoPtr_graphFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
