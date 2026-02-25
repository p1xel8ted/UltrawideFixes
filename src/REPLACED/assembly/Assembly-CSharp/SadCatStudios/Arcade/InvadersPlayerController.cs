// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.InvadersPlayerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class InvadersPlayerController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveAnimationTiming;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectile;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileSpawnPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectileSpawnSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathAnimationTiming;
  private static readonly System.IntPtr NativeFieldInfoPtr_deatTotalTimeSeconds;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDeathSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultSprite;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSpriteTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSpriteIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_originPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_isDead;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDeathInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Movement_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shooting_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InvadersPlayerController()
  {
    Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (InvadersPlayerController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr);
    InvadersPlayerController.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (moveSpeed));
    InvadersPlayerController.NativeFieldInfoPtr_moveSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (moveSprites));
    InvadersPlayerController.NativeFieldInfoPtr_moveAnimationTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (moveAnimationTiming));
    InvadersPlayerController.NativeFieldInfoPtr_projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (projectile));
    InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (projectileSpawnPoint));
    InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (projectileSpawnSound));
    InvadersPlayerController.NativeFieldInfoPtr_deathSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (deathSprites));
    InvadersPlayerController.NativeFieldInfoPtr_deathAnimationTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (deathAnimationTiming));
    InvadersPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (deatTotalTimeSeconds));
    InvadersPlayerController.NativeFieldInfoPtr_playerDeathSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (playerDeathSound));
    InvadersPlayerController.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (spriteRenderer));
    InvadersPlayerController.NativeFieldInfoPtr_defaultSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (defaultSprite));
    InvadersPlayerController.NativeFieldInfoPtr_moveSpriteTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (moveSpriteTimer));
    InvadersPlayerController.NativeFieldInfoPtr_moveSpriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (moveSpriteIndex));
    InvadersPlayerController.NativeFieldInfoPtr_originPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (originPos));
    InvadersPlayerController.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (isDead));
    InvadersPlayerController.NativeFieldInfoPtr_playerDeathInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, nameof (playerDeathInstance));
    InvadersPlayerController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676623);
    InvadersPlayerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676624);
    InvadersPlayerController.NativeMethodInfoPtr_Movement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676625);
    InvadersPlayerController.NativeMethodInfoPtr_Shooting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676626);
    InvadersPlayerController.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676627);
    InvadersPlayerController.NativeMethodInfoPtr_Kill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676628);
    InvadersPlayerController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676629);
    InvadersPlayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676630);
    InvadersPlayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, 100676631);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124855, XrefRangeEnd = 124865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124865, XrefRangeEnd = 124867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124891, RefRangeEnd = 124892, XrefRangeStart = 124867, XrefRangeEnd = 124891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Movement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Movement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 124910, RefRangeEnd = 124911, XrefRangeStart = 124892, XrefRangeEnd = 124910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shooting()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Shooting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124911, XrefRangeEnd = 124917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124917, XrefRangeEnd = 124921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Kill()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_Kill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124921, XrefRangeEnd = 124925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124925, XrefRangeEnd = 124926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124926, XrefRangeEnd = 124927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InvadersPlayerController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float moveSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> moveSprites
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSprites));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float moveAnimationTiming
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveAnimationTiming));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveAnimationTiming)) = value;
    }
  }

  public unsafe InvadersProjectile projectile
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectile));
      return num == System.IntPtr.Zero ? (InvadersProjectile) null : Il2CppObjectPool.Get<InvadersProjectile>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform projectileSpawnPoint
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnPoint));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnPoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference projectileSpawnSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_projectileSpawnSound)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> deathSprites
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deathSprites));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deathSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float deathAnimationTiming
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deathAnimationTiming));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deathAnimationTiming)) = value;
    }
  }

  public unsafe float deatTotalTimeSeconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds)) = value;
    }
  }

  public unsafe EventReference playerDeathSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_playerDeathSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_playerDeathSound)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_spriteRenderer));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite defaultSprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_defaultSprite));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_defaultSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float moveSpriteTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpriteTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpriteTimer)) = value;
    }
  }

  public unsafe int moveSpriteIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpriteIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_moveSpriteIndex)) = value;
    }
  }

  public unsafe Vector3 originPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_originPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_originPos)) = value;
    }
  }

  public unsafe bool isDead
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_isDead));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_isDead)) = value;
    }
  }

  public unsafe EventInstance playerDeathInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_playerDeathInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController.NativeFieldInfoPtr_playerDeathInstance)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.InvadersPlayerController+<Kill>d__22")]
  public sealed class _Kill_d__22 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteIndex_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Kill_d__22()
    {
      Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InvadersPlayerController>.NativeClassPtr, "<Kill>d__22");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr);
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<>1__state");
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<>t__builder");
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<>4__this");
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<timer>5__2");
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__spriteIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<spriteIndex>5__3");
      InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, "<>u__1");
      InvadersPlayerController._Kill_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, 100676632);
      InvadersPlayerController._Kill_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr, 100676633);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124822, XrefRangeEnd = 124855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController._Kill_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InvadersPlayerController._Kill_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Kill_d__22(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Kill_d__22()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvadersPlayerController._Kill_d__22>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe InvadersPlayerController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (InvadersPlayerController) null : Il2CppObjectPool.Get<InvadersPlayerController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe int _spriteIndex_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__spriteIndex_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr__spriteIndex_5__3)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InvadersPlayerController._Kill_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
