// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.FinalPlayerController
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

public class FinalPlayerController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSprites;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveAnimationTiming;
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
  private static readonly System.IntPtr NativeFieldInfoPtr_rb;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerDeathInstance;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Movement_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Kill_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinalPlayerController()
  {
    Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (FinalPlayerController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr);
    FinalPlayerController.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (moveSpeed));
    FinalPlayerController.NativeFieldInfoPtr_moveSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (moveSprites));
    FinalPlayerController.NativeFieldInfoPtr_moveAnimationTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (moveAnimationTiming));
    FinalPlayerController.NativeFieldInfoPtr_deathSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (deathSprites));
    FinalPlayerController.NativeFieldInfoPtr_deathAnimationTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (deathAnimationTiming));
    FinalPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (deatTotalTimeSeconds));
    FinalPlayerController.NativeFieldInfoPtr_playerDeathSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (playerDeathSound));
    FinalPlayerController.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (spriteRenderer));
    FinalPlayerController.NativeFieldInfoPtr_defaultSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (defaultSprite));
    FinalPlayerController.NativeFieldInfoPtr_moveSpriteTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (moveSpriteTimer));
    FinalPlayerController.NativeFieldInfoPtr_moveSpriteIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (moveSpriteIndex));
    FinalPlayerController.NativeFieldInfoPtr_originPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (originPos));
    FinalPlayerController.NativeFieldInfoPtr_isDead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (isDead));
    FinalPlayerController.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (rb));
    FinalPlayerController.NativeFieldInfoPtr_playerDeathInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, nameof (playerDeathInstance));
    FinalPlayerController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676481);
    FinalPlayerController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676482);
    FinalPlayerController.NativeMethodInfoPtr_Movement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676483);
    FinalPlayerController.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676484);
    FinalPlayerController.NativeMethodInfoPtr_Kill_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676485);
    FinalPlayerController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676486);
    FinalPlayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676487);
    FinalPlayerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, 100676488);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123696, XrefRangeEnd = 123705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123705, XrefRangeEnd = 123706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123738, RefRangeEnd = 123739, XrefRangeStart = 123706, XrefRangeEnd = 123738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Movement()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_Movement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123739, XrefRangeEnd = 123742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123742, XrefRangeEnd = 123746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Kill()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_Kill_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123746, XrefRangeEnd = 123754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123754, XrefRangeEnd = 123755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalPlayerController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalPlayerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float moveSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> moveSprites
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSprites));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float moveAnimationTiming
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveAnimationTiming));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveAnimationTiming)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Sprite> deathSprites
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deathSprites));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Sprite>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deathSprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float deathAnimationTiming
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deathAnimationTiming));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deathAnimationTiming)) = value;
    }
  }

  public unsafe float deatTotalTimeSeconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_deatTotalTimeSeconds)) = value;
    }
  }

  public unsafe EventReference playerDeathSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_playerDeathSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_playerDeathSound)) = value;
    }
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_spriteRenderer));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sprite defaultSprite
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_defaultSprite));
      return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_defaultSprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float moveSpriteTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpriteTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpriteTimer)) = value;
    }
  }

  public unsafe int moveSpriteIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpriteIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_moveSpriteIndex)) = value;
    }
  }

  public unsafe Vector3 originPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_originPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_originPos)) = value;
    }
  }

  public unsafe bool isDead
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_isDead));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_isDead)) = value;
    }
  }

  public unsafe Rigidbody2D rb
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_rb));
      return num == System.IntPtr.Zero ? (Rigidbody2D) null : Il2CppObjectPool.Get<Rigidbody2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance playerDeathInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_playerDeathInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController.NativeFieldInfoPtr_playerDeathInstance)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.FinalPlayerController+<Kill>d__19")]
  public sealed class _Kill_d__19 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteIndex_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Kill_d__19()
    {
      Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinalPlayerController>.NativeClassPtr, "<Kill>d__19");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr);
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<>1__state");
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<>t__builder");
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<>4__this");
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<timer>5__2");
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__spriteIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<spriteIndex>5__3");
      FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, "<>u__1");
      FinalPlayerController._Kill_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, 100676489);
      FinalPlayerController._Kill_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr, 100676490);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123670, XrefRangeEnd = 123696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalPlayerController._Kill_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(FinalPlayerController._Kill_d__19.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Kill_d__19(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Kill_d__19()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalPlayerController._Kill_d__19>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FinalPlayerController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FinalPlayerController) null : Il2CppObjectPool.Get<FinalPlayerController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe int _spriteIndex_5__3
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__spriteIndex_5__3));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr__spriteIndex_5__3)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalPlayerController._Kill_d__19.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
