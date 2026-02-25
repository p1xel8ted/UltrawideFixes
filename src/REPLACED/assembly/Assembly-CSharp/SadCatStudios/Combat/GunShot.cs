// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.GunShot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class GunShot(System.IntPtr pointer) : MovingProjectile(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_trailRenderers;
  private static readonly System.IntPtr NativeFieldInfoPtr_particles;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GunShot()
  {
    Il2CppClassPointerStore<GunShot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (GunShot));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunShot>.NativeClassPtr);
    GunShot.NativeFieldInfoPtr_trailRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunShot>.NativeClassPtr, nameof (trailRenderers));
    GunShot.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunShot>.NativeClassPtr, nameof (particles));
    GunShot.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot>.NativeClassPtr, 100677500);
    GunShot.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot>.NativeClassPtr, 100677501);
    GunShot.NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot>.NativeClassPtr, 100677502);
    GunShot.NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot>.NativeClassPtr, 100677503);
    GunShot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot>.NativeClassPtr, 100677504);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130289, XrefRangeEnd = 130292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GunShot.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130292, XrefRangeEnd = 130303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init(AttackObject attack)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attack)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GunShot.NativeMethodInfoPtr_Init_Public_Virtual_Void_AttackObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130303, XrefRangeEnd = 130320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessShotConnection(
    Transform collisionTransform,
    Vector3 collisionPoint,
    float collisionDistance,
    IHitReceiver receiver)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collisionTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &collisionDistance;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiver);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GunShot.NativeMethodInfoPtr_ProcessShotConnection_Protected_Virtual_Void_Transform_Vector3_Single_IHitReceiver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130320, XrefRangeEnd = 130327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ShotCollisionEffect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GunShot.NativeMethodInfoPtr_ShotCollisionEffect_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GunShot()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunShot>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GunShot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<TrailRenderer> trailRenderers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.NativeFieldInfoPtr_trailRenderers));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<TrailRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunShot.NativeFieldInfoPtr_trailRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem particles
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.NativeFieldInfoPtr_particles));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunShot.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.GunShot+<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_receiver;
    private static readonly System.IntPtr NativeFieldInfoPtr_hitCastResult;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ProcessShotConnection_b__0_Internal_Void_0;

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GunShot>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr);
      GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
      GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_receiver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr, nameof (receiver));
      GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_hitCastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr, nameof (hitCastResult));
      GunShot.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr, 100677505);
      GunShot.__c__DisplayClass4_0.NativeMethodInfoPtr__ProcessShotConnection_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr, 100677506);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GunShot.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GunShot.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130288, XrefRangeEnd = 130289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ProcessShotConnection_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GunShot.__c__DisplayClass4_0.NativeMethodInfoPtr__ProcessShotConnection_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GunShot __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (GunShot) null : Il2CppObjectPool.Get<GunShot>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IHitReceiver receiver
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_receiver));
        return num == System.IntPtr.Zero ? (IHitReceiver) null : Il2CppObjectPool.Get<IHitReceiver>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_receiver), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public HitCastResult hitCastResult
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_hitCastResult);
        return new HitCastResult(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GunShot.__c__DisplayClass4_0.NativeFieldInfoPtr_hitCastResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HitCastResult>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
