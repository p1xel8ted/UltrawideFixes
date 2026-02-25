// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CounterCastResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public sealed class CounterCastResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CounterReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterAttack;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsPerfect;

  static CounterCastResult()
  {
    Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CounterCastResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr);
    CounterCastResult.NativeFieldInfoPtr_CounterReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr, nameof (CounterReceiver));
    CounterCastResult.NativeFieldInfoPtr_CasterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr, nameof (CasterTransform));
    CounterCastResult.NativeFieldInfoPtr_CasterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr, nameof (CasterRotation));
    CounterCastResult.NativeFieldInfoPtr_CasterAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr, nameof (CasterAttack));
    CounterCastResult.NativeFieldInfoPtr_IsPerfect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr, nameof (IsPerfect));
  }

  public CounterCastResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CounterCastResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CounterCastResult>.NativeClassPtr))
  {
  }

  public unsafe ICounterReceiver CounterReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CounterReceiver));
      return num == System.IntPtr.Zero ? (ICounterReceiver) null : Il2CppObjectPool.Get<ICounterReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CounterReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform CasterTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float CasterRotation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterRotation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterRotation)) = value;
    }
  }

  public unsafe AttackObject CasterAttack
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterAttack));
      return num == System.IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_CasterAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool IsPerfect
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_IsPerfect));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CounterCastResult.NativeFieldInfoPtr_IsPerfect)) = value;
    }
  }
}
