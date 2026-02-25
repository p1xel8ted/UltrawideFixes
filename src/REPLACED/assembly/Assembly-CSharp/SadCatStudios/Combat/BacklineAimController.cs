// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.BacklineAimController
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
using SadCatStudios.Animation;
using SadCatStudios.Character;
using SadCatStudios.FSM;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class BacklineAimController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_returnGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_shootingAnchor;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_obstructionLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_projectile;
  private static readonly System.IntPtr NativeFieldInfoPtr_startupAimDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeAimDuration;
  private static readonly System.IntPtr NativeFieldInfoPtr_shotsCountTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_lazerAims;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimIdleClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_aimShotClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpDiagonalClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointFallClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_pointLandingClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_jumpUpClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallGraph;
  private static readonly System.IntPtr NativeFieldInfoPtr_climbPoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_linePoints;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_sensorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_armorController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_defenceController;
  private static readonly System.IntPtr NativeFieldInfoPtr_timer;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AimEndPosition_Private_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JumpToShootingPosition_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JumpBackToFrontline_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToPosition_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AimAtPlayer_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_JumpBack_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BacklineAimController()
  {
    Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (BacklineAimController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr);
    BacklineAimController.NativeFieldInfoPtr_returnGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (returnGraph));
    BacklineAimController.NativeFieldInfoPtr_shootingAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (shootingAnchor));
    BacklineAimController.NativeFieldInfoPtr_targetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (targetReference));
    BacklineAimController.NativeFieldInfoPtr_obstructionLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (obstructionLayer));
    BacklineAimController.NativeFieldInfoPtr_projectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (projectile));
    BacklineAimController.NativeFieldInfoPtr_startupAimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (startupAimDuration));
    BacklineAimController.NativeFieldInfoPtr_activeAimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (activeAimDuration));
    BacklineAimController.NativeFieldInfoPtr_shotsCountTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (shotsCountTarget));
    BacklineAimController.NativeFieldInfoPtr_lazerAims = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (lazerAims));
    BacklineAimController.NativeFieldInfoPtr_aimIdleClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (aimIdleClip));
    BacklineAimController.NativeFieldInfoPtr_aimShotClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (aimShotClip));
    BacklineAimController.NativeFieldInfoPtr_climbClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (climbClip));
    BacklineAimController.NativeFieldInfoPtr_climbDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (climbDistance));
    BacklineAimController.NativeFieldInfoPtr_climbSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (climbSpeed));
    BacklineAimController.NativeFieldInfoPtr_jumpDiagonalClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (jumpDiagonalClip));
    BacklineAimController.NativeFieldInfoPtr_jumpCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (jumpCurve));
    BacklineAimController.NativeFieldInfoPtr_pointFallClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (pointFallClip));
    BacklineAimController.NativeFieldInfoPtr_pointLandingClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (pointLandingClip));
    BacklineAimController.NativeFieldInfoPtr_jumpUpClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (jumpUpClip));
    BacklineAimController.NativeFieldInfoPtr_fallGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (fallGraph));
    BacklineAimController.NativeFieldInfoPtr_climbPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (climbPoints));
    BacklineAimController.NativeFieldInfoPtr_linePoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (linePoints));
    BacklineAimController.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (targetTransform));
    BacklineAimController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (personPhysics));
    BacklineAimController.NativeFieldInfoPtr_sensorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (sensorController));
    BacklineAimController.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (animationController));
    BacklineAimController.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (walkController));
    BacklineAimController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (stateController));
    BacklineAimController.NativeFieldInfoPtr_armorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (armorController));
    BacklineAimController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (rotationController));
    BacklineAimController.NativeFieldInfoPtr_defenceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (defenceController));
    BacklineAimController.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (timer));
    BacklineAimController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677425);
    BacklineAimController.NativeMethodInfoPtr_AimEndPosition_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677426);
    BacklineAimController.NativeMethodInfoPtr_JumpToShootingPosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677427);
    BacklineAimController.NativeMethodInfoPtr_JumpBackToFrontline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677428);
    BacklineAimController.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677429);
    BacklineAimController.NativeMethodInfoPtr_MoveToPosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677430);
    BacklineAimController.NativeMethodInfoPtr_AimAtPlayer_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677431);
    BacklineAimController.NativeMethodInfoPtr_JumpBack_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677432);
    BacklineAimController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677433);
    BacklineAimController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, 100677434);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130028, XrefRangeEnd = 130055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130055, XrefRangeEnd = 130067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 AimEndPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_AimEndPosition_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130074, RefRangeEnd = 130075, XrefRangeStart = 130067, XrefRangeEnd = 130074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JumpToShootingPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_JumpToShootingPosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130075, XrefRangeEnd = 130081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void JumpBackToFrontline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_JumpBackToFrontline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130081, XrefRangeEnd = 130095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shoot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130095, XrefRangeEnd = 130099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator MoveToPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_MoveToPosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130099, XrefRangeEnd = 130103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator AimAtPlayer()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_AimAtPlayer_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130103, XrefRangeEnd = 130107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator JumpBack()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_JumpBack_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130107, XrefRangeEnd = 130113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130113, XrefRangeEnd = 130118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BacklineAimController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BacklineAimController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FSMGraph returnGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_returnGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_returnGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform shootingAnchor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_shootingAnchor));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_shootingAnchor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference targetReference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_targetReference));
      return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_targetReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask obstructionLayer
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_obstructionLayer));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_obstructionLayer)) = value;
    }
  }

  public unsafe SeekerProjectileWithDamage projectile
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_projectile));
      return num == System.IntPtr.Zero ? (SeekerProjectileWithDamage) null : Il2CppObjectPool.Get<SeekerProjectileWithDamage>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_projectile), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference startupAimDuration
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_startupAimDuration));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_startupAimDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference activeAimDuration
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_activeAimDuration));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_activeAimDuration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int shotsCountTarget
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_shotsCountTarget));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_shotsCountTarget)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<BacklineAimController.LazerAim> lazerAims
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_lazerAims));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<BacklineAimController.LazerAim>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<BacklineAimController.LazerAim>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_lazerAims), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip aimIdleClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_aimIdleClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_aimIdleClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip aimShotClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_aimShotClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_aimShotClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip climbClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float climbDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbDistance)) = value;
    }
  }

  public unsafe float climbSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbSpeed)) = value;
    }
  }

  public unsafe MeshClip jumpDiagonalClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpDiagonalClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpDiagonalClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve jumpCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip pointFallClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_pointFallClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_pointFallClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip pointLandingClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_pointLandingClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_pointLandingClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip jumpUpClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpUpClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_jumpUpClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FSMGraph fallGraph
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_fallGraph));
      return num == System.IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_fallGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Transform> climbPoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbPoints));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Transform>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_climbPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> linePoints
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_linePoints));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_linePoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform targetTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_targetTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_personPhysics));
      return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterSensorController sensorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_sensorController));
      return num == System.IntPtr.Zero ? (CharacterSensorController) null : Il2CppObjectPool.Get<CharacterSensorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_sensorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterArmorController armorController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_armorController));
      return num == System.IntPtr.Zero ? (CharacterArmorController) null : Il2CppObjectPool.Get<CharacterArmorController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_armorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAIDefenceController defenceController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_defenceController));
      return num == System.IntPtr.Zero ? (CharacterAIDefenceController) null : Il2CppObjectPool.Get<CharacterAIDefenceController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_defenceController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.NativeFieldInfoPtr_timer)) = value;
    }
  }

  [Serializable]
  public sealed class LazerAim : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRenderer;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartupColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActiveColor;

    static LazerAim()
    {
      Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, nameof (LazerAim));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr);
      BacklineAimController.LazerAim.NativeFieldInfoPtr_LineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr, nameof (LineRenderer));
      BacklineAimController.LazerAim.NativeFieldInfoPtr_StartupColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr, nameof (StartupColor));
      BacklineAimController.LazerAim.NativeFieldInfoPtr_ActiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr, nameof (ActiveColor));
    }

    public LazerAim(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LazerAim()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController.LazerAim>.NativeClassPtr))
    {
    }

    public unsafe LineRenderer LineRenderer
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_LineRenderer));
        return num == System.IntPtr.Zero ? (LineRenderer) null : Il2CppObjectPool.Get<LineRenderer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_LineRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Gradient StartupColor
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_StartupColor));
        return num == System.IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_StartupColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Gradient ActiveColor
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_ActiveColor));
        return num == System.IntPtr.Zero ? (Gradient) null : Il2CppObjectPool.Get<Gradient>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.LazerAim.NativeFieldInfoPtr_ActiveColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.BacklineAimController+<>c__DisplayClass39_0")]
  public sealed class __c__DisplayClass39_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_shotsCount;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

    static __c__DisplayClass39_0()
    {
      Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, "<>c__DisplayClass39_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr);
      BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, "<>4__this");
      BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr_shotsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, nameof (shotsCount));
      BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, 100677435);
      BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, 100677436);
      BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, 100677437);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass39_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129887, XrefRangeEnd = 129891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129891, XrefRangeEnd = 129904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe BacklineAimController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BacklineAimController) null : Il2CppObjectPool.Get<BacklineAimController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int shotsCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr_shotsCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.NativeFieldInfoPtr_shotsCount)) = value;
      }
    }

    [ObfuscatedName("SadCatStudios.Combat.BacklineAimController+<>c__DisplayClass39_0+<<AimAtPlayer>g__Aim|0>d")]
    public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
      System.IntPtr pointer) : Il2CppSystem.Object(pointer)
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

      static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
      {
        Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0>.NativeClassPtr, "<<AimAtPlayer>g__Aim|0>d");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677438);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677439);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677440);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677441);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677442);
        BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100677443);
      }

      [CallerCount(64 /*0x40*/)]
      [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(
        int _param1)
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &_param1
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15159)]
      [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_IDisposable_Dispose()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      public virtual unsafe bool MoveNext()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129882, XrefRangeEnd = 129887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void System_Collections_IEnumerator_Reset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
      {
        [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
        }
      }

      public unsafe int __1__state
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
        }
      }

      public unsafe Il2CppSystem.Object __2__current
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current));
          return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BacklineAimController.__c__DisplayClass39_0 __4__this
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this));
          return num == System.IntPtr.Zero ? (BacklineAimController.__c__DisplayClass39_0) null : Il2CppObjectPool.Get<BacklineAimController.__c__DisplayClass39_0>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController.__c__DisplayClass39_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.BacklineAimController+<AimAtPlayer>d__39")]
  public sealed class _AimAtPlayer_d__39(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___8__1;
    private static readonly System.IntPtr NativeFieldInfoPtr__shotTimer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _AimAtPlayer_d__39()
    {
      Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, "<AimAtPlayer>d__39");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr);
      BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, "<>1__state");
      BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, "<>2__current");
      BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, "<>4__this");
      BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, "<>8__1");
      BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr__shotTimer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, "<shotTimer>5__2");
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677444);
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677445);
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677446);
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677447);
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677448);
      BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr, 100677449);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _AimAtPlayer_d__39(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController._AimAtPlayer_d__39>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129904, XrefRangeEnd = 129912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129912, XrefRangeEnd = 129917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._AimAtPlayer_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BacklineAimController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BacklineAimController) null : Il2CppObjectPool.Get<BacklineAimController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BacklineAimController.__c__DisplayClass39_0 __8__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___8__1));
        return num == System.IntPtr.Zero ? (BacklineAimController.__c__DisplayClass39_0) null : Il2CppObjectPool.Get<BacklineAimController.__c__DisplayClass39_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _shotTimer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr__shotTimer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._AimAtPlayer_d__39.NativeFieldInfoPtr__shotTimer_5__2)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.BacklineAimController+<JumpBack>d__40")]
  public sealed class _JumpBack_d__40(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__jumpPoint_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__jumpDuration_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__jumpTimer_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__start_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__totalDistance_5__6;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _JumpBack_d__40()
    {
      Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, "<JumpBack>d__40");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr);
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<>1__state");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<>2__current");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<>4__this");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpPoint_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<jumpPoint>5__2");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<jumpDuration>5__3");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpTimer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<jumpTimer>5__4");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__start_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<start>5__5");
      BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__totalDistance_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, "<totalDistance>5__6");
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677450);
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677451);
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677452);
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677453);
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677454);
      BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr, 100677455);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _JumpBack_d__40(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController._JumpBack_d__40>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129917, XrefRangeEnd = 129928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129928, XrefRangeEnd = 129933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._JumpBack_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BacklineAimController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BacklineAimController) null : Il2CppObjectPool.Get<BacklineAimController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _jumpPoint_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpPoint_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpPoint_5__2)) = value;
      }
    }

    public unsafe float _jumpDuration_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpDuration_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpDuration_5__3)) = value;
      }
    }

    public unsafe float _jumpTimer_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpTimer_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__jumpTimer_5__4)) = value;
      }
    }

    public unsafe Vector3 _start_5__5
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__start_5__5));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__start_5__5)) = value;
      }
    }

    public unsafe float _totalDistance_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__totalDistance_5__6));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._JumpBack_d__40.NativeFieldInfoPtr__totalDistance_5__6)) = value;
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Combat.BacklineAimController+<MoveToPosition>d__38")]
  public sealed class _MoveToPosition_d__38(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__closestPoint_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__jumpDuration_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__jumpTimer_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr__start_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr__totalDistance_5__6;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _MoveToPosition_d__38()
    {
      Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BacklineAimController>.NativeClassPtr, "<MoveToPosition>d__38");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr);
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<>1__state");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<>2__current");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<>4__this");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__closestPoint_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<closestPoint>5__2");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpDuration_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<jumpDuration>5__3");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpTimer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<jumpTimer>5__4");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__start_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<start>5__5");
      BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__totalDistance_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, "<totalDistance>5__6");
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677456);
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677457);
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677458);
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677459);
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677460);
      BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr, 100677461);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _MoveToPosition_d__38(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BacklineAimController._MoveToPosition_d__38>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129933, XrefRangeEnd = 130023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130023, XrefRangeEnd = 130028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BacklineAimController._MoveToPosition_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BacklineAimController __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BacklineAimController) null : Il2CppObjectPool.Get<BacklineAimController>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Vector3 _closestPoint_5__2
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__closestPoint_5__2));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__closestPoint_5__2)) = value;
      }
    }

    public unsafe float _jumpDuration_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpDuration_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpDuration_5__3)) = value;
      }
    }

    public unsafe float _jumpTimer_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpTimer_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__jumpTimer_5__4)) = value;
      }
    }

    public unsafe Vector3 _start_5__5
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__start_5__5));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__start_5__5)) = value;
      }
    }

    public unsafe float _totalDistance_5__6
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__totalDistance_5__6));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BacklineAimController._MoveToPosition_d__38.NativeFieldInfoPtr__totalDistance_5__6)) = value;
      }
    }
  }
}
