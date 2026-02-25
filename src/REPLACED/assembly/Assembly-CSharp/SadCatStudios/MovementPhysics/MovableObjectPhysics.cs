// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.MovableObjectPhysics
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Effects;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public class MovableObjectPhysics(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_torqueForce;
  private static readonly System.IntPtr NativeFieldInfoPtr_pushForce;
  private static readonly System.IntPtr NativeFieldInfoPtr_torqueMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_grabZone;
  private static readonly System.IntPtr NativeFieldInfoPtr_oneWay;
  private static readonly System.IntPtr NativeFieldInfoPtr_direction;
  private static readonly System.IntPtr NativeFieldInfoPtr_rb;
  private static readonly System.IntPtr NativeFieldInfoPtr_col;
  private static readonly System.IntPtr NativeFieldInfoPtr_Locked;
  private static readonly System.IntPtr NativeFieldInfoPtr_shouldBeFrozen;
  private static readonly System.IntPtr NativeFieldInfoPtr_freezeTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_bumpEvent;
  private static readonly System.IntPtr NativeFieldInfoPtr_groundMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_untaggedGroup;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragVFXCollection;
  private static readonly System.IntPtr NativeFieldInfoPtr_fallVFXCollection;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr_moveSoundInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_dragEffect;
  private static readonly System.IntPtr NativeFieldInfoPtr_beingDragged;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastDragSide;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FrontEdge_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unfreeze_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Push_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Throw_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dragging_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MovableObjectPhysics()
  {
    Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (MovableObjectPhysics));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr);
    MovableObjectPhysics.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (moveSpeed));
    MovableObjectPhysics.NativeFieldInfoPtr_torqueForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (torqueForce));
    MovableObjectPhysics.NativeFieldInfoPtr_pushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (pushForce));
    MovableObjectPhysics.NativeFieldInfoPtr_torqueMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (torqueMode));
    MovableObjectPhysics.NativeFieldInfoPtr_grabZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (grabZone));
    MovableObjectPhysics.NativeFieldInfoPtr_oneWay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (oneWay));
    MovableObjectPhysics.NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (direction));
    MovableObjectPhysics.NativeFieldInfoPtr_rb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (rb));
    MovableObjectPhysics.NativeFieldInfoPtr_col = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (col));
    MovableObjectPhysics.NativeFieldInfoPtr_Locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (Locked));
    MovableObjectPhysics.NativeFieldInfoPtr_shouldBeFrozen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (shouldBeFrozen));
    MovableObjectPhysics.NativeFieldInfoPtr_freezeTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (freezeTimer));
    MovableObjectPhysics.NativeFieldInfoPtr_originalConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (originalConstraints));
    MovableObjectPhysics.NativeFieldInfoPtr_moveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (moveEvent));
    MovableObjectPhysics.NativeFieldInfoPtr_fallEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (fallEvent));
    MovableObjectPhysics.NativeFieldInfoPtr_bumpEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (bumpEvent));
    MovableObjectPhysics.NativeFieldInfoPtr_groundMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (groundMask));
    MovableObjectPhysics.NativeFieldInfoPtr_untaggedGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (untaggedGroup));
    MovableObjectPhysics.NativeFieldInfoPtr_dragVFXCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (dragVFXCollection));
    MovableObjectPhysics.NativeFieldInfoPtr_fallVFXCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (fallVFXCollection));
    MovableObjectPhysics.NativeFieldInfoPtr_currentMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (currentMaterial));
    MovableObjectPhysics.NativeFieldInfoPtr_moveSoundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (moveSoundInstance));
    MovableObjectPhysics.NativeFieldInfoPtr_dragEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (dragEffect));
    MovableObjectPhysics.NativeFieldInfoPtr_beingDragged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (beingDragged));
    MovableObjectPhysics.NativeFieldInfoPtr_lastDragSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, nameof (lastDragSide));
    MovableObjectPhysics.NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670927);
    MovableObjectPhysics.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670928);
    MovableObjectPhysics.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670929);
    MovableObjectPhysics.NativeMethodInfoPtr_get_FrontEdge_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670930);
    MovableObjectPhysics.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670931);
    MovableObjectPhysics.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670932);
    MovableObjectPhysics.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670933);
    MovableObjectPhysics.NativeMethodInfoPtr_Unfreeze_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670934);
    MovableObjectPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670935);
    MovableObjectPhysics.NativeMethodInfoPtr_Push_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670936);
    MovableObjectPhysics.NativeMethodInfoPtr_Throw_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670937);
    MovableObjectPhysics.NativeMethodInfoPtr_Dragging_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670938);
    MovableObjectPhysics.NativeMethodInfoPtr_GetId_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670939);
    MovableObjectPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670940);
    MovableObjectPhysics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr, 100670941);
  }

  public unsafe Rigidbody Rigidbody
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_get_Rigidbody_Public_get_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num3);
    }
  }

  public unsafe float RightEdge
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 89477, RefRangeEnd = 89478, XrefRangeStart = 89476, XrefRangeEnd = 89477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_get_RightEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LeftEdge
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 89479, RefRangeEnd = 89480, XrefRangeStart = 89478, XrefRangeEnd = 89479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_get_LeftEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float FrontEdge
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89480, XrefRangeEnd = 89481, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_get_FrontEdge_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89481, XrefRangeEnd = 89488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89488, XrefRangeEnd = 89501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89501, XrefRangeEnd = 89556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionStay(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_OnCollisionStay_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89556, XrefRangeEnd = 89558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unfreeze()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Unfreeze_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89558, XrefRangeEnd = 89577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 89581, RefRangeEnd = 89583, XrefRangeStart = 89577, XrefRangeEnd = 89581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Push(float dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dir
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Push_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89586, RefRangeEnd = 89587, XrefRangeStart = 89583, XrefRangeEnd = 89586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Throw(float dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dir
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Throw_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 89591, RefRangeEnd = 89592, XrefRangeStart = 89587, XrefRangeEnd = 89591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dragging(bool drag)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &drag
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Dragging_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 89593, RefRangeEnd = 89608, XrefRangeStart = 89592, XrefRangeEnd = 89593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_GetId_Public_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89608, XrefRangeEnd = 89616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89616, XrefRangeEnd = 89617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MovableObjectPhysics()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovableObjectPhysics>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovableObjectPhysics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference moveSpeed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveSpeed));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 torqueForce
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_torqueForce));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_torqueForce)) = value;
    }
  }

  public unsafe Vector3 pushForce
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_pushForce));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_pushForce)) = value;
    }
  }

  public unsafe ForceMode torqueMode
  {
    get
    {
      return *(ForceMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_torqueMode));
    }
    [param: In] set
    {
      *(ForceMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_torqueMode)) = value;
    }
  }

  public unsafe Transform grabZone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_grabZone));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_grabZone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool oneWay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_oneWay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_oneWay)) = value;
    }
  }

  public unsafe MovableObjectPhysics.PushDirection direction
  {
    get
    {
      return *(MovableObjectPhysics.PushDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_direction));
    }
    [param: In] set
    {
      *(MovableObjectPhysics.PushDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_direction)) = value;
    }
  }

  public unsafe Rigidbody rb
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_rb));
      return num == System.IntPtr.Zero ? (Rigidbody) null : Il2CppObjectPool.Get<Rigidbody>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_rb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Collider col
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_col));
      return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_col), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Locked
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_Locked));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_Locked)) = value;
    }
  }

  public unsafe bool shouldBeFrozen
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_shouldBeFrozen));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_shouldBeFrozen)) = value;
    }
  }

  public unsafe float freezeTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_freezeTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_freezeTimer)) = value;
    }
  }

  public unsafe RigidbodyConstraints originalConstraints
  {
    get
    {
      return *(RigidbodyConstraints*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_originalConstraints));
    }
    [param: In] set
    {
      *(RigidbodyConstraints*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_originalConstraints)) = value;
    }
  }

  public unsafe EventReference moveEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveEvent)) = value;
    }
  }

  public unsafe EventReference fallEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_fallEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_fallEvent)) = value;
    }
  }

  public unsafe EventReference bumpEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_bumpEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_bumpEvent)) = value;
    }
  }

  public unsafe LayerMask groundMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_groundMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_groundMask)) = value;
    }
  }

  public unsafe PhysicsMaterial untaggedGroup
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_untaggedGroup));
      return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_untaggedGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe VFXSurfaceCollection dragVFXCollection
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_dragVFXCollection));
      return num == System.IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_dragVFXCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe VFXSurfaceCollection fallVFXCollection
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_fallVFXCollection));
      return num == System.IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_fallVFXCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PhysicsMaterial currentMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_currentMaterial));
      return num == System.IntPtr.Zero ? (PhysicsMaterial) null : Il2CppObjectPool.Get<PhysicsMaterial>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_currentMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance moveSoundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveSoundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_moveSoundInstance)) = value;
    }
  }

  public unsafe IPoolable dragEffect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_dragEffect));
      return num == System.IntPtr.Zero ? (IPoolable) null : Il2CppObjectPool.Get<IPoolable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_dragEffect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool beingDragged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_beingDragged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_beingDragged)) = value;
    }
  }

  public unsafe bool lastDragSide
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_lastDragSide));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovableObjectPhysics.NativeFieldInfoPtr_lastDragSide)) = value;
    }
  }

  public enum PushDirection
  {
    Backward = -1, // 0xFFFFFFFF
    None = 0,
    Forward = 1,
  }
}
