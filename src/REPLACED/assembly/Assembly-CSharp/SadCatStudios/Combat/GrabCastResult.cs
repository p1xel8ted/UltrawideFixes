// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GrabCastResult
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

public sealed class GrabCastResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_GrabReceiver;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_GrabbedTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_CasterRotation;

  static GrabCastResult()
  {
    Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GrabCastResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr);
    GrabCastResult.NativeFieldInfoPtr_GrabReceiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr, nameof (GrabReceiver));
    GrabCastResult.NativeFieldInfoPtr_CasterTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr, nameof (CasterTransform));
    GrabCastResult.NativeFieldInfoPtr_GrabbedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr, nameof (GrabbedTransform));
    GrabCastResult.NativeFieldInfoPtr_CasterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr, nameof (CasterRotation));
  }

  public GrabCastResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public GrabCastResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrabCastResult>.NativeClassPtr))
  {
  }

  public unsafe IGrabReceiver GrabReceiver
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_GrabReceiver));
      return num == System.IntPtr.Zero ? (IGrabReceiver) null : Il2CppObjectPool.Get<IGrabReceiver>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_GrabReceiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform CasterTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_CasterTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_CasterTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform GrabbedTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_GrabbedTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_GrabbedTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float CasterRotation
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_CasterRotation));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrabCastResult.NativeFieldInfoPtr_CasterRotation)) = value;
    }
  }
}
