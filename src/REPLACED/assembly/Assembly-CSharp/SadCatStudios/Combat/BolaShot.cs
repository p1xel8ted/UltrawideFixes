// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.BolaShot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class BolaShot(IntPtr pointer) : MovingProjectile(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_spriteAnimator;
  private static readonly IntPtr NativeFieldInfoPtr_particles;
  private static readonly IntPtr NativeFieldInfoPtr_localRot;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BolaShot()
  {
    Il2CppClassPointerStore<BolaShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (BolaShot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BolaShot>.NativeClassPtr);
    BolaShot.NativeFieldInfoPtr_spriteAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, nameof (spriteAnimator));
    BolaShot.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, nameof (particles));
    BolaShot.NativeFieldInfoPtr_localRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, nameof (localRot));
    BolaShot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, 100677462);
    BolaShot.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, 100677463);
    BolaShot.NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, 100677464);
    BolaShot.NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, 100677465);
    BolaShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BolaShot>.NativeClassPtr, 100677466);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130118, XrefRangeEnd = 130124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BolaShot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130124, XrefRangeEnd = 130142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BolaShot.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 84913, RefRangeEnd = 84914, XrefRangeStart = 84913, XrefRangeEnd = 84914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ShotCollisionEffect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BolaShot.NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130142, XrefRangeEnd = 130147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessShotConnection(
    Transform collisionTransform,
    Vector3 collisionPoint,
    float collisionDistance,
    IHitReceiver receiver)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collisionTransform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &collisionPoint;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &collisionDistance;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BolaShot.NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130147, XrefRangeEnd = 130151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BolaShot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BolaShot>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BolaShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteAnimator spriteAnimator
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_spriteAnimator));
      return num == IntPtr.Zero ? (SpriteAnimator) null : Il2CppObjectPool.Get<SpriteAnimator>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_spriteAnimator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem particles
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_particles));
      return num == IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 localRot
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_localRot));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BolaShot.NativeFieldInfoPtr_localRot)) = value;
    }
  }
}
