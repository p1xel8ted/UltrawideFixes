// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.MoveToPointData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public class MoveToPointData(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_HorizontalMove;
  private static readonly IntPtr NativeFieldInfoPtr_Friction;
  private static readonly IntPtr NativeFieldInfoPtr_Acceleration;
  private static readonly IntPtr NativeFieldInfoPtr_CustomRotation;
  private static readonly IntPtr NativeFieldInfoPtr_SafetyMeasures;
  private static readonly IntPtr NativeFieldInfoPtr_IgnoreSlowdown;
  private static readonly IntPtr NativeFieldInfoPtr_IgnoreGravity;
  private static readonly IntPtr NativeFieldInfoPtr_IgnoreDepth;
  private static readonly IntPtr NativeFieldInfoPtr_RestrictAutoStep;
  private static readonly IntPtr NativeFieldInfoPtr_AutoFindClip;
  private static readonly IntPtr NativeFieldInfoPtr_MoveClip;
  private static readonly IntPtr NativeFieldInfoPtr_ArriveClip;
  private static readonly IntPtr NativeMethodInfoPtr_get_MoveUnit_Public_get_MoveUnit_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MoveToPointData()
  {
    Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (MoveToPointData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr);
    MoveToPointData.NativeFieldInfoPtr_HorizontalMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (HorizontalMove));
    MoveToPointData.NativeFieldInfoPtr_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (Friction));
    MoveToPointData.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (Acceleration));
    MoveToPointData.NativeFieldInfoPtr_CustomRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (CustomRotation));
    MoveToPointData.NativeFieldInfoPtr_SafetyMeasures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (SafetyMeasures));
    MoveToPointData.NativeFieldInfoPtr_IgnoreSlowdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (IgnoreSlowdown));
    MoveToPointData.NativeFieldInfoPtr_IgnoreGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (IgnoreGravity));
    MoveToPointData.NativeFieldInfoPtr_IgnoreDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (IgnoreDepth));
    MoveToPointData.NativeFieldInfoPtr_RestrictAutoStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (RestrictAutoStep));
    MoveToPointData.NativeFieldInfoPtr_AutoFindClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (AutoFindClip));
    MoveToPointData.NativeFieldInfoPtr_MoveClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (MoveClip));
    MoveToPointData.NativeFieldInfoPtr_ArriveClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, nameof (ArriveClip));
    MoveToPointData.NativeMethodInfoPtr_get_MoveUnit_Public_get_MoveUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, 100670942);
    MoveToPointData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr, 100670943);
  }

  public unsafe MoveUnit MoveUnit
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 89620, RefRangeEnd = 89621, XrefRangeStart = 89617, XrefRangeEnd = 89620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MoveToPointData.NativeMethodInfoPtr_get_MoveUnit_Public_get_MoveUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(MoveUnit*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MoveToPointData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveToPointData>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MoveToPointData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference HorizontalMove
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_HorizontalMove));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_HorizontalMove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference Friction
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_Friction));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_Friction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference Acceleration
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_Acceleration));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_Acceleration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool CustomRotation
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_CustomRotation));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_CustomRotation)) = value;
    }
  }

  public unsafe bool SafetyMeasures
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_SafetyMeasures));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_SafetyMeasures)) = value;
    }
  }

  public unsafe bool IgnoreSlowdown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreSlowdown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreSlowdown)) = value;
    }
  }

  public unsafe bool IgnoreGravity
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreGravity));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreGravity)) = value;
    }
  }

  public unsafe bool IgnoreDepth
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreDepth));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_IgnoreDepth)) = value;
    }
  }

  public unsafe bool RestrictAutoStep
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_RestrictAutoStep));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_RestrictAutoStep)) = value;
    }
  }

  public unsafe bool AutoFindClip
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_AutoFindClip));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_AutoFindClip)) = value;
    }
  }

  public unsafe MeshClip MoveClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_MoveClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_MoveClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip ArriveClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_ArriveClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveToPointData.NativeFieldInfoPtr_ArriveClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
