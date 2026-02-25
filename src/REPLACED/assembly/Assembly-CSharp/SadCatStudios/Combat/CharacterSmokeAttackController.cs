// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterSmokeAttackController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterSmokeAttackController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_grenade;
  private static readonly System.IntPtr NativeFieldInfoPtr_grenadeFake;
  private static readonly System.IntPtr NativeFieldInfoPtr_heightSpawnOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_areaIndicator;
  private static readonly System.IntPtr NativeFieldInfoPtr_grenadesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_startAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_angleOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_throwDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_hitboxController;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Disappear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowGrenade_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Appear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterSmokeAttackController()
  {
    Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterSmokeAttackController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr);
    CharacterSmokeAttackController.NativeFieldInfoPtr_grenade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (grenade));
    CharacterSmokeAttackController.NativeFieldInfoPtr_grenadeFake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (grenadeFake));
    CharacterSmokeAttackController.NativeFieldInfoPtr_heightSpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (heightSpawnOffset));
    CharacterSmokeAttackController.NativeFieldInfoPtr_areaIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (areaIndicator));
    CharacterSmokeAttackController.NativeFieldInfoPtr_grenadesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (grenadesCount));
    CharacterSmokeAttackController.NativeFieldInfoPtr_startAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (startAngle));
    CharacterSmokeAttackController.NativeFieldInfoPtr_angleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (angleOffset));
    CharacterSmokeAttackController.NativeFieldInfoPtr_throwDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (throwDelay));
    CharacterSmokeAttackController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (sensorController));
    CharacterSmokeAttackController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (animationController));
    CharacterSmokeAttackController.NativeFieldInfoPtr_hitboxController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (hitboxController));
    CharacterSmokeAttackController.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, nameof (target));
    CharacterSmokeAttackController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, 100677809);
    CharacterSmokeAttackController.NativeMethodInfoPtr_Disappear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, 100677810);
    CharacterSmokeAttackController.NativeMethodInfoPtr_ThrowGrenade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, 100677811);
    CharacterSmokeAttackController.NativeMethodInfoPtr_Appear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, 100677812);
    CharacterSmokeAttackController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, 100677813);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131638, XrefRangeEnd = 131647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131650, RefRangeEnd = 131651, XrefRangeStart = 131647, XrefRangeEnd = 131650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Disappear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController.NativeMethodInfoPtr_Disappear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131655, RefRangeEnd = 131656, XrefRangeStart = 131651, XrefRangeEnd = 131655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ThrowGrenade()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController.NativeMethodInfoPtr_ThrowGrenade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 131667, RefRangeEnd = 131668, XrefRangeStart = 131656, XrefRangeEnd = 131667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Appear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController.NativeMethodInfoPtr_Appear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131668, XrefRangeEnd = 131669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterSmokeAttackController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GunData grenade
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenade));
      return num == System.IntPtr.Zero ? (GunData) null : Il2CppObjectPool.Get<GunData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference grenadeFake
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenadeFake));
      return num == System.IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenadeFake), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float heightSpawnOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_heightSpawnOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_heightSpawnOffset)) = value;
    }
  }

  public unsafe GameObject areaIndicator
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_areaIndicator));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_areaIndicator), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int grenadesCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenadesCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_grenadesCount)) = value;
    }
  }

  public unsafe float startAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_startAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_startAngle)) = value;
    }
  }

  public unsafe float angleOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_angleOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_angleOffset)) = value;
    }
  }

  public unsafe float throwDelay
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_throwDelay));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_throwDelay)) = value;
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHitboxController hitboxController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_hitboxController));
      return num == System.IntPtr.Zero ? (CharacterHitboxController) null : Il2CppObjectPool.Get<CharacterHitboxController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_hitboxController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 target
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_target));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController.NativeFieldInfoPtr_target)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.CharacterSmokeAttackController+<ThrowGrenade>d__14")]
  public sealed class _ThrowGrenade_d__14 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _ThrowGrenade_d__14()
    {
      Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterSmokeAttackController>.NativeClassPtr, "<ThrowGrenade>d__14");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr);
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, "<>1__state");
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, "<>t__builder");
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, "<>4__this");
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, "<>u__1");
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, 100677814);
      CharacterSmokeAttackController._ThrowGrenade_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr, 100677815);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131584 /*0x020200*/, XrefRangeEnd = 131638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _ThrowGrenade_d__14(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _ThrowGrenade_d__14()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterSmokeAttackController._ThrowGrenade_d__14>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder);
        return new AsyncVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe CharacterSmokeAttackController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CharacterSmokeAttackController) null : Il2CppObjectPool.Get<CharacterSmokeAttackController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterSmokeAttackController._ThrowGrenade_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
