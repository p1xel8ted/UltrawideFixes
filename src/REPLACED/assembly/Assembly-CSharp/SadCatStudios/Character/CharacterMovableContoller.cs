// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterMovableContoller
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
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

public class CharacterMovableContoller(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_distanceBreak;
  private static readonly IntPtr NativeFieldInfoPtr_angularVelocityBreak;
  private static readonly IntPtr NativeFieldInfoPtr_movablePhysics;
  private static readonly IntPtr NativeFieldInfoPtr_walkController;
  private static readonly IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly IntPtr NativeFieldInfoPtr_lastMovablePos;
  private static readonly IntPtr NativeFieldInfoPtr_moveInstance;
  private static readonly IntPtr NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Snapped_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CastEdge_Public_Boolean_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapMovable_Public_Void_MovableObjectPhysics_0;
  private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FreeMovable_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Throw_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterMovableContoller()
  {
    Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterMovableContoller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr);
    CharacterMovableContoller.NativeFieldInfoPtr_distanceBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (distanceBreak));
    CharacterMovableContoller.NativeFieldInfoPtr_angularVelocityBreak = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (angularVelocityBreak));
    CharacterMovableContoller.NativeFieldInfoPtr_movablePhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (movablePhysics));
    CharacterMovableContoller.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (walkController));
    CharacterMovableContoller.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (rotationController));
    CharacterMovableContoller.NativeFieldInfoPtr_lastMovablePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (lastMovablePos));
    CharacterMovableContoller.NativeFieldInfoPtr_moveInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, nameof (moveInstance));
    CharacterMovableContoller.NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675417);
    CharacterMovableContoller.NativeMethodInfoPtr_get_Snapped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675418);
    CharacterMovableContoller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675419);
    CharacterMovableContoller.NativeMethodInfoPtr_CastEdge_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675420);
    CharacterMovableContoller.NativeMethodInfoPtr_SnapMovable_Public_Void_MovableObjectPhysics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675421);
    CharacterMovableContoller.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675422);
    CharacterMovableContoller.NativeMethodInfoPtr_FreeMovable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675423);
    CharacterMovableContoller.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675424);
    CharacterMovableContoller.NativeMethodInfoPtr_Move_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675425);
    CharacterMovableContoller.NativeMethodInfoPtr_Throw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675426);
    CharacterMovableContoller.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675427);
    CharacterMovableContoller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr, 100675428);
  }

  public unsafe bool Locked
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 117343, RefRangeEnd = 117344, XrefRangeStart = 117343, XrefRangeEnd = 117343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_get_Locked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Snapped
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 117348, RefRangeEnd = 117349, XrefRangeStart = 117344, XrefRangeEnd = 117348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_get_Snapped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117349, XrefRangeEnd = 117355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117373, RefRangeEnd = 117374, XrefRangeStart = 117355, XrefRangeEnd = 117373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CastEdge(bool isForward)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &isForward
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_CastEdge_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117376, RefRangeEnd = 117377, XrefRangeStart = 117374, XrefRangeEnd = 117376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapMovable(MovableObjectPhysics movablePhysics)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) movablePhysics)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_SnapMovable_Public_Void_MovableObjectPhysics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117377, XrefRangeEnd = 117386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 117391, RefRangeEnd = 117394, XrefRangeStart = 117386, XrefRangeEnd = 117391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeMovable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_FreeMovable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117401, RefRangeEnd = 117402, XrefRangeStart = 117394, XrefRangeEnd = 117401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117403, RefRangeEnd = 117404, XrefRangeStart = 117402, XrefRangeEnd = 117403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Move(float dir)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &dir
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_Move_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 117408, RefRangeEnd = 117409, XrefRangeStart = 117404, XrefRangeEnd = 117408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Throw()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_Throw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117409, XrefRangeEnd = 117410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterMovableContoller()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterMovableContoller>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterMovableContoller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference distanceBreak
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_distanceBreak));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_distanceBreak), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference angularVelocityBreak
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_angularVelocityBreak));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_angularVelocityBreak), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MovableObjectPhysics movablePhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_movablePhysics));
      return num == IntPtr.Zero ? (MovableObjectPhysics) null : Il2CppObjectPool.Get<MovableObjectPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_movablePhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_walkController));
      return num == IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_rotationController));
      return num == IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 lastMovablePos
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_lastMovablePos));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_lastMovablePos)) = value;
    }
  }

  public unsafe EventInstance moveInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_moveInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterMovableContoller.NativeFieldInfoPtr_moveInstance)) = value;
    }
  }
}
