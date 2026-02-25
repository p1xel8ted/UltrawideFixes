// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.SeekerProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.Character;
using SadCatStudios.Combat;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Effects;

public class SeekerProjectile(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_targetReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapRadius;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_coverMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathType;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitParticle;
  private static readonly System.IntPtr NativeFieldInfoPtr_trails;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileTargetCollider;
  private static readonly System.IntPtr NativeFieldInfoPtr_particles;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetDeathController;
  private static readonly System.IntPtr NativeFieldInfoPtr_overlapBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SeekTarget_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShotCollisionEffect_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SeekerProjectile()
  {
    Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (SeekerProjectile));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr);
    SeekerProjectile.NativeFieldInfoPtr_targetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (targetReference));
    SeekerProjectile.NativeFieldInfoPtr_targetOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (targetOffset));
    SeekerProjectile.NativeFieldInfoPtr_projectileSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (projectileSpeed));
    SeekerProjectile.NativeFieldInfoPtr_overlapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (overlapRadius));
    SeekerProjectile.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (layerMask));
    SeekerProjectile.NativeFieldInfoPtr_coverMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (coverMask));
    SeekerProjectile.NativeFieldInfoPtr_deathType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (deathType));
    SeekerProjectile.NativeFieldInfoPtr_hitParticle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (hitParticle));
    SeekerProjectile.NativeFieldInfoPtr_trails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (trails));
    SeekerProjectile.NativeFieldInfoPtr_projectileTargetCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (projectileTargetCollider));
    SeekerProjectile.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (particles));
    SeekerProjectile.NativeFieldInfoPtr_targetDeathController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (targetDeathController));
    SeekerProjectile.NativeFieldInfoPtr_overlapBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, nameof (overlapBuffer));
    SeekerProjectile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675635);
    SeekerProjectile.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675636);
    SeekerProjectile.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675637);
    SeekerProjectile.NativeMethodInfoPtr_SeekTarget_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675638);
    SeekerProjectile.NativeMethodInfoPtr_ShotCollisionEffect_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675639);
    SeekerProjectile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, 100675640);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118547, XrefRangeEnd = 118550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118550, XrefRangeEnd = 118562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118562, XrefRangeEnd = 118564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118564, XrefRangeEnd = 118568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator SeekTarget()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr_SeekTarget_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118568, XrefRangeEnd = 118579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShotCollisionEffect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr_ShotCollisionEffect_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118579, XrefRangeEnd = 118583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SeekerProjectile()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SeekerProjectile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference targetReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 targetOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetOffset)) = value;
    }
  }

  public unsafe FloatReference projectileSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_projectileSpeed));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_projectileSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float overlapRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_overlapRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_overlapRadius)) = value;
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe LayerMask coverMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_coverMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_coverMask)) = value;
    }
  }

  public unsafe DeathType deathType
  {
    get
    {
      return *(DeathType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_deathType));
    }
    [param: In] set
    {
      *(DeathType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_deathType)) = value;
    }
  }

  public unsafe AssetReference hitParticle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_hitParticle));
      return num == System.IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_hitParticle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TrailRenderer> trails
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_trails));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<TrailRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TrailRenderer>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_trails), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider projectileTargetCollider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_projectileTargetCollider));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_projectileTargetCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem particles
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_particles));
      return num == System.IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterDeathController targetDeathController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetDeathController));
      return num == System.IntPtr.Zero ? (CharacterDeathController) null : Il2CppObjectPool.Get<CharacterDeathController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_targetDeathController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Collider> overlapBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_overlapBuffer));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile.NativeFieldInfoPtr_overlapBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Effects.SeekerProjectile+<SeekTarget>d__16")]
  public sealed class _SeekTarget_d__16(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _SeekTarget_d__16()
    {
      Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SeekerProjectile>.NativeClassPtr, "<SeekTarget>d__16");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr);
      SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, "<>1__state");
      SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, "<>2__current");
      SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, "<>4__this");
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675641);
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675642);
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675643);
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675644);
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675645);
      SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr, 100675646);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _SeekTarget_d__16(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SeekerProjectile._SeekTarget_d__16>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118540, XrefRangeEnd = 118542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118542, XrefRangeEnd = 118547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SeekerProjectile._SeekTarget_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SeekerProjectile __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SeekerProjectile) null : Il2CppObjectPool.Get<SeekerProjectile>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SeekerProjectile._SeekTarget_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
