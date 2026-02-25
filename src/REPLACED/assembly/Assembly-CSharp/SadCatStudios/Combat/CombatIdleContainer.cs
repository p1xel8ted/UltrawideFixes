// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatIdleContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatIdleContainer(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_idles;
  private static readonly IntPtr NativeMethodInfoPtr_get_Idles_Public_get_List_1_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatIdleContainer()
  {
    Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatIdleContainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr);
    CombatIdleContainer.NativeFieldInfoPtr_idles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr, nameof (idles));
    CombatIdleContainer.NativeMethodInfoPtr_get_Idles_Public_get_List_1_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr, 100676903);
    CombatIdleContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr, 100676904);
  }

  public unsafe List<FSMGraph> Idles
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatIdleContainer.NativeMethodInfoPtr_get_Idles_Public_get_List_1_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<FSMGraph>) null : Il2CppObjectPool.Get<List<FSMGraph>>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatIdleContainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatIdleContainer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatIdleContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<FSMGraph> idles
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatIdleContainer.NativeFieldInfoPtr_idles));
      return num == IntPtr.Zero ? (List<FSMGraph>) null : Il2CppObjectPool.Get<List<FSMGraph>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatIdleContainer.NativeFieldInfoPtr_idles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
