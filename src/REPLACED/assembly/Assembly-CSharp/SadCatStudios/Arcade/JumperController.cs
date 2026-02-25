// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.JumperController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class JumperController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldownTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathCarSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathSeagullSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpInWaterSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_idleHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_deathHash;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpCancellationTokenSource;
  private static readonly System.IntPtr NativeFieldInfoPtr_animator;
  private static readonly System.IntPtr NativeFieldInfoPtr_originPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_state;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnDeath;
  private static readonly System.IntPtr NativeFieldInfoPtr_lockVerticalInput;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIdleState_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetJumpState_Private_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Jump_Private_UniTaskVoid_Vector3_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Death_Public_Void_DeathReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JumperController()
  {
    Il2CppClassPointerStore<JumperController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (JumperController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumperController>.NativeClassPtr);
    JumperController.NativeFieldInfoPtr_jumpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (jumpTime));
    JumperController.NativeFieldInfoPtr_cooldownTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (cooldownTime));
    JumperController.NativeFieldInfoPtr_deathCarSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (deathCarSound));
    JumperController.NativeFieldInfoPtr_deathSeagullSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (deathSeagullSound));
    JumperController.NativeFieldInfoPtr_jumpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (jumpSound));
    JumperController.NativeFieldInfoPtr_jumpInWaterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (jumpInWaterSound));
    JumperController.NativeFieldInfoPtr_idleHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (idleHash));
    JumperController.NativeFieldInfoPtr_jumpHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (jumpHash));
    JumperController.NativeFieldInfoPtr_deathHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (deathHash));
    JumperController.NativeFieldInfoPtr_jumpCancellationTokenSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (jumpCancellationTokenSource));
    JumperController.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (animator));
    JumperController.NativeFieldInfoPtr_originPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (originPos));
    JumperController.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (state));
    JumperController.NativeFieldInfoPtr_OnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (OnDeath));
    JumperController.NativeFieldInfoPtr_lockVerticalInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController>.NativeClassPtr, nameof (lockVerticalInput));
    JumperController.NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676683);
    JumperController.NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676684);
    JumperController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676685);
    JumperController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676686);
    JumperController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676687);
    JumperController.NativeMethodInfoPtr_SetIdleState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676688);
    JumperController.NativeMethodInfoPtr_SetJumpState_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676689);
    JumperController.NativeMethodInfoPtr_Jump_Private_UniTaskVoid_Vector3_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676690);
    JumperController.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676691);
    JumperController.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676692);
    JumperController.NativeMethodInfoPtr_Death_Public_Void_DeathReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676693);
    JumperController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController>.NativeClassPtr, 100676694);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125657, XrefRangeEnd = 125661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnDeath(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_add_OnDeath_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125661, XrefRangeEnd = 125665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnDeath(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_remove_OnDeath_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125665, XrefRangeEnd = 125670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125670, XrefRangeEnd = 125672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125672, XrefRangeEnd = 125715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 125721, RefRangeEnd = 125724, XrefRangeStart = 125715, XrefRangeEnd = 125721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetIdleState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_SetIdleState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125724, XrefRangeEnd = 125740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetJumpState(Vector3 moveDir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &moveDir
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_SetJumpState_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125740, XrefRangeEnd = 125743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid Jump(Vector3 moveDir, CancellationToken cancellationToken)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &moveDir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancellationToken));
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_Jump_Private_UniTaskVoid_Vector3_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125743, XrefRangeEnd = 125774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter2D(Collider2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 125780, RefRangeEnd = 125783, XrefRangeStart = 125774, XrefRangeEnd = 125780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 125798, RefRangeEnd = 125799, XrefRangeStart = 125783, XrefRangeEnd = 125798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Death(JumperController.DeathReason reason)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &reason
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr_Death_Public_Void_DeathReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JumperController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumperController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumperController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float jumpTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpTime)) = value;
    }
  }

  public unsafe float cooldownTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_cooldownTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_cooldownTime)) = value;
    }
  }

  public unsafe EventReference deathCarSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_deathCarSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_deathCarSound)) = value;
    }
  }

  public unsafe EventReference deathSeagullSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_deathSeagullSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_deathSeagullSound)) = value;
    }
  }

  public unsafe EventReference jumpSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpSound)) = value;
    }
  }

  public unsafe EventReference jumpInWaterSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpInWaterSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpInWaterSound)) = value;
    }
  }

  public static unsafe int idleHash
  {
    get
    {
      int idleHash;
      IL2CPP.il2cpp_field_static_get_value(JumperController.NativeFieldInfoPtr_idleHash, (void*) &idleHash);
      return idleHash;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JumperController.NativeFieldInfoPtr_idleHash, (void*) &value);
    }
  }

  public static unsafe int jumpHash
  {
    get
    {
      int jumpHash;
      IL2CPP.il2cpp_field_static_get_value(JumperController.NativeFieldInfoPtr_jumpHash, (void*) &jumpHash);
      return jumpHash;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JumperController.NativeFieldInfoPtr_jumpHash, (void*) &value);
    }
  }

  public static unsafe int deathHash
  {
    get
    {
      int deathHash;
      IL2CPP.il2cpp_field_static_get_value(JumperController.NativeFieldInfoPtr_deathHash, (void*) &deathHash);
      return deathHash;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(JumperController.NativeFieldInfoPtr_deathHash, (void*) &value);
    }
  }

  public unsafe CancellationTokenSource jumpCancellationTokenSource
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpCancellationTokenSource));
      return num == System.IntPtr.Zero ? (CancellationTokenSource) null : Il2CppObjectPool.Get<CancellationTokenSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_jumpCancellationTokenSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Animator animator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_animator));
      return num == System.IntPtr.Zero ? (Animator) null : Il2CppObjectPool.Get<Animator>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 originPos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_originPos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_originPos)) = value;
    }
  }

  public unsafe JumperController.State state
  {
    get
    {
      return *(JumperController.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_state));
    }
    [param: In] set
    {
      *(JumperController.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_state)) = value;
    }
  }

  public unsafe Il2CppSystem.Action OnDeath
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_OnDeath));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_OnDeath), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool lockVerticalInput
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_lockVerticalInput));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController.NativeFieldInfoPtr_lockVerticalInput)) = value;
    }
  }

  public enum State
  {
    Idle,
    Jump,
    Death,
  }

  public enum DeathReason
  {
    Car,
    Seagull,
  }

  [ObfuscatedName("SadCatStudios.Arcade.JumperController+<Jump>d__24")]
  public sealed class _Jump_d__24 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_moveDir;
    private static readonly System.IntPtr NativeFieldInfoPtr_cancellationToken;
    private static readonly System.IntPtr NativeFieldInfoPtr__targetPos_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _Jump_d__24()
    {
      Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JumperController>.NativeClassPtr, "<Jump>d__24");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr);
      JumperController._Jump_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<>1__state");
      JumperController._Jump_d__24.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<>t__builder");
      JumperController._Jump_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<>4__this");
      JumperController._Jump_d__24.NativeFieldInfoPtr_moveDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, nameof (moveDir));
      JumperController._Jump_d__24.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, nameof (cancellationToken));
      JumperController._Jump_d__24.NativeFieldInfoPtr__targetPos_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<targetPos>5__2");
      JumperController._Jump_d__24.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<timer>5__3");
      JumperController._Jump_d__24.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, "<>u__1");
      JumperController._Jump_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, 100676696);
      JumperController._Jump_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr, 100676697);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125609, XrefRangeEnd = 125657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperController._Jump_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(Il2CppSystem.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(JumperController._Jump_d__24.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _Jump_d__24(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _Jump_d__24()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumperController._Jump_d__24>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe JumperController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (JumperController) null : Il2CppObjectPool.Get<JumperController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 moveDir
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr_moveDir));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr_moveDir)) = value;
      }
    }

    public CancellationToken cancellationToken
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr_cancellationToken);
        return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Vector3 _targetPos_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr__targetPos_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr__targetPos_5__2)) = value;
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumperController._Jump_d__24.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
