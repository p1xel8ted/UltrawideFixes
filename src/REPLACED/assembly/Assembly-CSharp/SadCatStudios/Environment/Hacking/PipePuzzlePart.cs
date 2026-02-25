// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.Hacking.PipePuzzlePart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment.Hacking;

public class PipePuzzlePart(System.IntPtr pointer) : HackableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sidesValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_WorkingEnumValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_sides;
  private static readonly System.IntPtr NativeFieldInfoPtr_sideObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_sidePoweredObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_sideMovableMeshes;
  private static readonly System.IntPtr NativeFieldInfoPtr_sideImmovableMeshes;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotateSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveData;
  private static readonly System.IntPtr NativeFieldInfoPtr_Puzzle;
  private static readonly System.IntPtr NativeFieldInfoPtr_Movable;
  private static readonly System.IntPtr NativeFieldInfoPtr_actualRotationAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_partActive;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Active_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Active_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EffectiveSides_Public_get_WorkingSides_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OppositeSide_Public_Static_WorkingSides_WorkingSides_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HackRotate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PipePuzzlePart()
  {
    Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment.Hacking", nameof (PipePuzzlePart));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr);
    PipePuzzlePart.NativeFieldInfoPtr_sidesValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sidesValues));
    PipePuzzlePart.NativeFieldInfoPtr_WorkingEnumValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (WorkingEnumValues));
    PipePuzzlePart.NativeFieldInfoPtr_sides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sides));
    PipePuzzlePart.NativeFieldInfoPtr_sideObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sideObjects));
    PipePuzzlePart.NativeFieldInfoPtr_sidePoweredObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sidePoweredObjects));
    PipePuzzlePart.NativeFieldInfoPtr_sideMovableMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sideMovableMeshes));
    PipePuzzlePart.NativeFieldInfoPtr_sideImmovableMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (sideImmovableMeshes));
    PipePuzzlePart.NativeFieldInfoPtr_rotateSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (rotateSound));
    PipePuzzlePart.NativeFieldInfoPtr_saveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (saveData));
    PipePuzzlePart.NativeFieldInfoPtr_Puzzle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (Puzzle));
    PipePuzzlePart.NativeFieldInfoPtr_Movable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (Movable));
    PipePuzzlePart.NativeFieldInfoPtr_actualRotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (actualRotationAngle));
    PipePuzzlePart.NativeFieldInfoPtr_partActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (partActive));
    PipePuzzlePart.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676251);
    PipePuzzlePart.NativeMethodInfoPtr_set_Active_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676252);
    PipePuzzlePart.NativeMethodInfoPtr_get_EffectiveSides_Public_get_WorkingSides_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676253);
    PipePuzzlePart.NativeMethodInfoPtr_OppositeSide_Public_Static_WorkingSides_WorkingSides_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676254);
    PipePuzzlePart.NativeMethodInfoPtr_HackRotate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676255);
    PipePuzzlePart.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676256);
    PipePuzzlePart.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676257);
    PipePuzzlePart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, 100676258);
  }

  public unsafe bool Active
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_get_Active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 122240, RefRangeEnd = 122242, XrefRangeStart = 122221, XrefRangeEnd = 122240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_set_Active_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PipePuzzlePart.WorkingSides EffectiveSides
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 122264, RefRangeEnd = 122268, XrefRangeStart = 122242, XrefRangeEnd = 122264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_get_EffectiveSides_Public_get_WorkingSides_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PipePuzzlePart.WorkingSides*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 122275, RefRangeEnd = 122278, XrefRangeStart = 122268, XrefRangeEnd = 122275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PipePuzzlePart.WorkingSides OppositeSide(PipePuzzlePart.WorkingSides side)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &side
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_OppositeSide_Public_Static_WorkingSides_WorkingSides_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PipePuzzlePart.WorkingSides*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122278, XrefRangeEnd = 122301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HackRotate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_HackRotate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122301, XrefRangeEnd = 122303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122303, XrefRangeEnd = 122309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122309, XrefRangeEnd = 122336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PipePuzzlePart()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppStructArray<PipePuzzlePart.WorkingSides> sidesValues
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PipePuzzlePart.NativeFieldInfoPtr_sidesValues, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<PipePuzzlePart.WorkingSides>) null : Il2CppObjectPool.Get<Il2CppStructArray<PipePuzzlePart.WorkingSides>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PipePuzzlePart.NativeFieldInfoPtr_sidesValues, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<PipePuzzlePart.WorkingSides> WorkingEnumValues
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PipePuzzlePart.NativeFieldInfoPtr_WorkingEnumValues, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<PipePuzzlePart.WorkingSides>) null : Il2CppObjectPool.Get<Il2CppStructArray<PipePuzzlePart.WorkingSides>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PipePuzzlePart.NativeFieldInfoPtr_WorkingEnumValues, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PipePuzzlePart.WorkingSides sides
  {
    get
    {
      return *(PipePuzzlePart.WorkingSides*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sides));
    }
    [param: In] set
    {
      *(PipePuzzlePart.WorkingSides*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sides)) = value;
    }
  }

  public unsafe Dictionary<PipePuzzlePart.WorkingSides, Il2CppReferenceArray<GameObject>> sideObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideObjects));
      return num == System.IntPtr.Zero ? (Dictionary<PipePuzzlePart.WorkingSides, Il2CppReferenceArray<GameObject>>) null : Il2CppObjectPool.Get<Dictionary<PipePuzzlePart.WorkingSides, Il2CppReferenceArray<GameObject>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<PipePuzzlePart.WorkingSides, GameObject> sidePoweredObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sidePoweredObjects));
      return num == System.IntPtr.Zero ? (Dictionary<PipePuzzlePart.WorkingSides, GameObject>) null : Il2CppObjectPool.Get<Dictionary<PipePuzzlePart.WorkingSides, GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sidePoweredObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<PipePuzzlePart.WorkingSides, Mesh> sideMovableMeshes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideMovableMeshes));
      return num == System.IntPtr.Zero ? (Dictionary<PipePuzzlePart.WorkingSides, Mesh>) null : Il2CppObjectPool.Get<Dictionary<PipePuzzlePart.WorkingSides, Mesh>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideMovableMeshes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<PipePuzzlePart.WorkingSides, Mesh> sideImmovableMeshes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideImmovableMeshes));
      return num == System.IntPtr.Zero ? (Dictionary<PipePuzzlePart.WorkingSides, Mesh>) null : Il2CppObjectPool.Get<Dictionary<PipePuzzlePart.WorkingSides, Mesh>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_sideImmovableMeshes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference rotateSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_rotateSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_rotateSound)) = value;
    }
  }

  public unsafe PipePuzzlePart.SaveData saveData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_saveData));
      return num == System.IntPtr.Zero ? (PipePuzzlePart.SaveData) null : Il2CppObjectPool.Get<PipePuzzlePart.SaveData>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_saveData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PipePuzzle Puzzle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_Puzzle));
      return num == System.IntPtr.Zero ? (PipePuzzle) null : Il2CppObjectPool.Get<PipePuzzle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_Puzzle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Movable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_Movable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_Movable)) = value;
    }
  }

  public unsafe float actualRotationAngle
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_actualRotationAngle));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_actualRotationAngle)) = value;
    }
  }

  public unsafe bool partActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_partActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.NativeFieldInfoPtr_partActive)) = value;
    }
  }

  [Flags]
  public enum WorkingSides
  {
    Undefined = 0,
    Up = 2,
    Left = 4,
    Down = 8,
    Right = 16, // 0x00000010
  }

  public class SaveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EulerAngles;
    private static readonly System.IntPtr NativeFieldInfoPtr_ActualRotationAngle;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static SaveData()
    {
      Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PipePuzzlePart>.NativeClassPtr, nameof (SaveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr);
      PipePuzzlePart.SaveData.NativeFieldInfoPtr_EulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr, nameof (EulerAngles));
      PipePuzzlePart.SaveData.NativeFieldInfoPtr_ActualRotationAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr, nameof (ActualRotationAngle));
      PipePuzzlePart.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr, 100676260);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PipePuzzlePart.SaveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PipePuzzlePart.SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Vector3 EulerAngles
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.SaveData.NativeFieldInfoPtr_EulerAngles));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.SaveData.NativeFieldInfoPtr_EulerAngles)) = value;
      }
    }

    public unsafe float ActualRotationAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.SaveData.NativeFieldInfoPtr_ActualRotationAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PipePuzzlePart.SaveData.NativeFieldInfoPtr_ActualRotationAngle)) = value;
      }
    }
  }
}
