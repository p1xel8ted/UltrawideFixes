// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GrenadeDrop
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
namespace SadCatStudios.Combat;

public class GrenadeDrop(IntPtr pointer) : ProjectileBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_dropForce;
  private static readonly IntPtr NativeFieldInfoPtr_explodeOnCollision;
  private static readonly IntPtr NativeFieldInfoPtr_attackSender;
  private static readonly IntPtr NativeFieldInfoPtr_attackObject;
  private static readonly IntPtr NativeFieldInfoPtr_rb;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GrenadeDrop()
  {
    Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GrenadeDrop));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr);
    GrenadeDrop.NativeFieldInfoPtr_dropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, nameof (dropForce));
    GrenadeDrop.NativeFieldInfoPtr_explodeOnCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, nameof (explodeOnCollision));
    GrenadeDrop.NativeFieldInfoPtr_attackSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, nameof (attackSender));
    GrenadeDrop.NativeFieldInfoPtr_attackObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, nameof (attackObject));
    GrenadeDrop.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, nameof (rb));
    GrenadeDrop.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, 100677472);
    GrenadeDrop.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, 100677473);
    GrenadeDrop.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, 100677474);
    GrenadeDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr, 100677475);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130176, XrefRangeEnd = 130182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeDrop.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130182, XrefRangeEnd = 130190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GrenadeDrop.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130190, XrefRangeEnd = 130195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeDrop.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130195, XrefRangeEnd = 130196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GrenadeDrop()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrenadeDrop>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GrenadeDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float dropForce
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_dropForce));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_dropForce)) = value;
    }
  }

  public unsafe bool explodeOnCollision
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_explodeOnCollision));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_explodeOnCollision)) = value;
    }
  }

  public unsafe AreaAttackSender attackSender
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_attackSender));
      return num == IntPtr.Zero ? (AreaAttackSender) null : Il2CppObjectPool.Get<AreaAttackSender>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_attackSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject attackObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_attackObject));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_attackObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Rigidbody rb
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_rb));
      return num == IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GrenadeDrop.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
