// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterDeflectReceiverHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterDeflectReceiverHandler(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_deflectState;
  private static readonly IntPtr NativeFieldInfoPtr_deflectShotData;
  private static readonly IntPtr NativeFieldInfoPtr_deflectCooldownTimer;
  private static readonly IntPtr NativeFieldInfoPtr_deflectCooldownCooldown;
  private static readonly IntPtr NativeFieldInfoPtr_connectGraph;
  private static readonly IntPtr NativeFieldInfoPtr_connectOverdriveGraph;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_animationController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_overdriveController;
  private static readonly IntPtr NativeFieldInfoPtr_deflectAttack;
  private static readonly IntPtr NativeFieldInfoPtr_sender;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_CanResolve_Private_Virtual_Final_New_Boolean_GunShot_0;
  private static readonly IntPtr NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_ResolveShot_Private_Virtual_Final_New_Void_GunShot_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterDeflectReceiverHandler()
  {
    Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterDeflectReceiverHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr);
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (deflectState));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectShotData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (deflectShotData));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (deflectCooldownTimer));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (deflectCooldownCooldown));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (connectGraph));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectOverdriveGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (connectOverdriveGraph));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (stateController));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (animationController));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (rotationController));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_overdriveController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (overdriveController));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectAttack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (deflectAttack));
    CharacterDeflectReceiverHandler.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, nameof (sender));
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677526);
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677527);
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_CanResolve_Private_Virtual_Final_New_Boolean_GunShot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677528);
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_ResolveShot_Private_Virtual_Final_New_Void_GunShot_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677529);
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677530);
    CharacterDeflectReceiverHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr, 100677531);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130435, XrefRangeEnd = 130454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130454, XrefRangeEnd = 130463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130463, XrefRangeEnd = 130470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool SadCatStudios_Combat_IShotResolveReceiveHandler_CanResolve(
    GunShot gunshot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gunshot)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_CanResolve_Private_Virtual_Final_New_Boolean_GunShot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130470, XrefRangeEnd = 130484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SadCatStudios_Combat_IShotResolveReceiveHandler_ResolveShot(
    GunShot gunshot,
    Transform senderTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gunshot);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) senderTransform);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr_SadCatStudios_Combat_IShotResolveReceiveHandler_ResolveShot_Private_Virtual_Final_New_Void_GunShot_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130484, XrefRangeEnd = 130486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterDeflectReceiverHandler()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDeflectReceiverHandler>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDeflectReceiverHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SadCatStudios.FSM.State deflectState
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectState));
      return num == IntPtr.Zero ? (SadCatStudios.FSM.State) null : Il2CppObjectPool.Get<SadCatStudios.FSM.State>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectState), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackData deflectShotData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectShotData));
      return num == IntPtr.Zero ? (AttackData) null : Il2CppObjectPool.Get<AttackData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectShotData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference deflectCooldownTimer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownTimer));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownTimer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference deflectCooldownCooldown
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownCooldown));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectCooldownCooldown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph connectGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph connectOverdriveGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectOverdriveGraph));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_connectOverdriveGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_animationController));
      return num == IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterOverdriveController overdriveController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_overdriveController));
      return num == IntPtr.Zero ? (CharacterOverdriveController) null : Il2CppObjectPool.Get<CharacterOverdriveController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_overdriveController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AttackObject deflectAttack
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectAttack));
      return num == IntPtr.Zero ? (AttackObject) null : Il2CppObjectPool.Get<AttackObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_deflectAttack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ICharacterHitSender sender
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_sender));
      return num == IntPtr.Zero ? (ICharacterHitSender) null : Il2CppObjectPool.Get<ICharacterHitSender>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDeflectReceiverHandler.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
