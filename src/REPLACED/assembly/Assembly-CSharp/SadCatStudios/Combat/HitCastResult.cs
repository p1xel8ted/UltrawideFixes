// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.HitCastResult
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

public sealed class HitCastResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_HitReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_ReceiverTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_CastIntersectionPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_CastIntersectionPointDistance;

  static HitCastResult()
  {
    Il2CppClassPointerStore<HitCastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (HitCastResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr);
    HitCastResult.NativeFieldInfoPtr_HitReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, nameof (HitReceiver));
    HitCastResult.NativeFieldInfoPtr_ReceiverTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, nameof (ReceiverTransform));
    HitCastResult.NativeFieldInfoPtr_CastIntersectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, nameof (CastIntersectionPoint));
    HitCastResult.NativeFieldInfoPtr_CastIntersectionPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, nameof (CastIntersectionPointDistance));
  }

  public HitCastResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public HitCastResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr))
  {
  }

  public unsafe IHitReceiver HitReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_HitReceiver));
      return num == System.IntPtr.Zero ? (IHitReceiver) null : Il2CppObjectPool.Get<IHitReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_HitReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform ReceiverTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_ReceiverTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_ReceiverTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 CastIntersectionPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_CastIntersectionPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_CastIntersectionPoint)) = value;
    }
  }

  public unsafe float CastIntersectionPointDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_CastIntersectionPointDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HitCastResult.NativeFieldInfoPtr_CastIntersectionPointDistance)) = value;
    }
  }
}
