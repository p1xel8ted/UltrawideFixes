// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.WalkMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.MovementPhysics;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public sealed class WalkMovement : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MoveUnit;
  private static readonly System.IntPtr NativeFieldInfoPtr_TargetPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly System.IntPtr NativeFieldInfoPtr_transform;
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_initialPointSign;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuidReference_MoveUnit_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0;

  static WalkMovement()
  {
    Il2CppClassPointerStore<WalkMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (WalkMovement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr);
    WalkMovement.NativeFieldInfoPtr_MoveUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (MoveUnit));
    WalkMovement.NativeFieldInfoPtr_TargetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (TargetPoint));
    WalkMovement.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (personPhysics));
    WalkMovement.NativeFieldInfoPtr_transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (transform));
    WalkMovement.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (walkController));
    WalkMovement.NativeFieldInfoPtr_initialPointSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, nameof (initialPointSign));
    WalkMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_MoveUnit_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, 100674961);
    WalkMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, 100674962);
    WalkMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr, 100674963);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114398, RefRangeEnd = 114399, XrefRangeStart = 114388, XrefRangeEnd = 114398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WalkMovement(GuidReference actor, MoveUnit moveUnit, Vector3 targetPoint)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &moveUnit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPoint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WalkMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_MoveUnit_Vector3_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114399, XrefRangeEnd = 114402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsAtPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WalkMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114402, XrefRangeEnd = 114405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Move()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WalkMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public WalkMovement(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public WalkMovement()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WalkMovement>.NativeClassPtr))
  {
  }

  public unsafe MoveUnit MoveUnit
  {
    get
    {
      return *(MoveUnit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_MoveUnit));
    }
    [param: In] set
    {
      *(MoveUnit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_MoveUnit)) = value;
    }
  }

  public unsafe Vector3 TargetPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_TargetPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_TargetPoint)) = value;
    }
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_personPhysics));
      return num == System.IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform transform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_transform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int initialPointSign
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_initialPointSign));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WalkMovement.NativeFieldInfoPtr_initialPointSign)) = value;
    }
  }
}
