// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.FinisherCastResult
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

public sealed class FinisherCastResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FinisherSender;
  private static readonly System.IntPtr NativeFieldInfoPtr_FinisherReceive;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceiverTransform;

  static FinisherCastResult()
  {
    Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (FinisherCastResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr);
    FinisherCastResult.NativeFieldInfoPtr_FinisherSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr, nameof (FinisherSender));
    FinisherCastResult.NativeFieldInfoPtr_FinisherReceive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr, nameof (FinisherReceive));
    FinisherCastResult.NativeFieldInfoPtr_CasterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr, nameof (CasterTransform));
    FinisherCastResult.NativeFieldInfoPtr_ReceiverTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr, nameof (ReceiverTransform));
  }

  public FinisherCastResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public FinisherCastResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinisherCastResult>.NativeClassPtr))
  {
  }

  public unsafe IGunFinisherSender FinisherSender
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_FinisherSender));
      return num == System.IntPtr.Zero ? (IGunFinisherSender) null : Il2CppObjectPool.Get<IGunFinisherSender>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_FinisherSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IGunFinisherReceiver FinisherReceive
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_FinisherReceive));
      return num == System.IntPtr.Zero ? (IGunFinisherReceiver) null : Il2CppObjectPool.Get<IGunFinisherReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_FinisherReceive), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform CasterTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_CasterTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_CasterTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform ReceiverTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_ReceiverTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinisherCastResult.NativeFieldInfoPtr_ReceiverTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
