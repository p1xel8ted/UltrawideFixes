// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterWalkController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterWalkController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_fallStart;
  private static readonly IntPtr NativeFieldInfoPtr_fallGravity;
  private static readonly IntPtr NativeFieldInfoPtr_debugSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_velocity;
  private static readonly IntPtr NativeFieldInfoPtr_lastPoint;
  private static readonly IntPtr NativeFieldInfoPtr_lastY;
  private static readonly IntPtr NativeFieldInfoPtr_debugMode;
  private static readonly IntPtr NativeMethodInfoPtr_get_FallStart_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FallGravity_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_LastY_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CachePosition_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_MoveUnit_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_MoveToPoint_Public_Void_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ArrivedAtPoint_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Boost_Public_Virtual_Final_New_Void_Single_Single_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetVelocity_Public_Virtual_Final_New_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterWalkController()
  {
    Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterWalkController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr);
    CharacterWalkController.NativeFieldInfoPtr_fallStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (fallStart));
    CharacterWalkController.NativeFieldInfoPtr_fallGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (fallGravity));
    CharacterWalkController.NativeFieldInfoPtr_debugSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (debugSpeed));
    CharacterWalkController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (personPhysics));
    CharacterWalkController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (rotationController));
    CharacterWalkController.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (velocity));
    CharacterWalkController.NativeFieldInfoPtr_lastPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (lastPoint));
    CharacterWalkController.NativeFieldInfoPtr_lastY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (lastY));
    CharacterWalkController.NativeFieldInfoPtr_debugMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, nameof (debugMode));
    CharacterWalkController.NativeMethodInfoPtr_get_FallStart_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675560);
    CharacterWalkController.NativeMethodInfoPtr_get_FallGravity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675561);
    CharacterWalkController.NativeMethodInfoPtr_get_LastY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675562);
    CharacterWalkController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675563);
    CharacterWalkController.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675564);
    CharacterWalkController.NativeMethodInfoPtr_CachePosition_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675565);
    CharacterWalkController.NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675566);
    CharacterWalkController.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675567);
    CharacterWalkController.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_MoveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675568);
    CharacterWalkController.NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675569);
    CharacterWalkController.NativeMethodInfoPtr_MoveToPoint_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675570);
    CharacterWalkController.NativeMethodInfoPtr_ArrivedAtPoint_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675571);
    CharacterWalkController.NativeMethodInfoPtr_Boost_Public_Virtual_Final_New_Void_Single_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675572);
    CharacterWalkController.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675573);
    CharacterWalkController.NativeMethodInfoPtr_GetVelocity_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675574);
    CharacterWalkController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr, 100675575);
  }

  public unsafe float FallStart
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 118187, RefRangeEnd = 118189, XrefRangeStart = 118186, XrefRangeEnd = 118187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_get_FallStart_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float FallGravity
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118189, XrefRangeEnd = 118191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_get_FallGravity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float LastY
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_get_LastY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118191, XrefRangeEnd = 118197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 118199, RefRangeEnd = 118204, XrefRangeStart = 118197, XrefRangeEnd = 118199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 118206, RefRangeEnd = 118207, XrefRangeStart = 118204, XrefRangeEnd = 118206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CachePosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_CachePosition_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ToggleDebugMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_ToggleDebugMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118207, XrefRangeEnd = 118276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(18)]
  [CachedScanResults(RefRangeStart = 118285, RefRangeEnd = 118303, XrefRangeStart = 118276, XrefRangeEnd = 118285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Move(MoveUnit moveUnit)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &moveUnit
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_MoveUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118303, XrefRangeEnd = 118315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetMovePoint(Vector3 point, bool snapToGround = true)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &point;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &snapToGround;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_SetMovePoint_Public_Void_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118315, XrefRangeEnd = 118318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToPoint(float speed, float acceleration, float friction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &speed;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &acceleration;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &friction;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_MoveToPoint_Public_Void_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118318, XrefRangeEnd = 118324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ArrivedAtPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_ArrivedAtPoint_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 118326, RefRangeEnd = 118329, XrefRangeStart = 118324, XrefRangeEnd = 118326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Boost(float x, float y, bool moveImmediate, bool ignoreRotation = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &x;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &y;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &moveImmediate;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &ignoreRotation;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_Boost_Public_Virtual_Final_New_Void_Single_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 118332, RefRangeEnd = 118343, XrefRangeStart = 118329, XrefRangeEnd = 118332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_Stop_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Vector3 GetVelocity()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr_GetVelocity_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118343, XrefRangeEnd = 118344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterWalkController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterWalkController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterWalkController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference fallStart
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_fallStart));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_fallStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference fallGravity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_fallGravity));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_fallGravity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float debugSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_debugSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_debugSpeed)) = value;
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_personPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 velocity
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_velocity));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_velocity)) = value;
    }
  }

  public unsafe Vector3 lastPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_lastPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_lastPoint)) = value;
    }
  }

  public unsafe float lastY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_lastY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_lastY)) = value;
    }
  }

  public unsafe bool debugMode
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_debugMode));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterWalkController.NativeFieldInfoPtr_debugMode)) = value;
    }
  }
}
