// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.AttackFSMOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

[Serializable]
public class AttackFSMOverride(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_distanceThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_overrideClip;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideClip_Public_get_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InThreshold_Public_Boolean_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackFSMOverride()
  {
    Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (AttackFSMOverride));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr);
    AttackFSMOverride.NativeFieldInfoPtr_distanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, nameof (distanceThreshold));
    AttackFSMOverride.NativeFieldInfoPtr_overrideClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, nameof (overrideClip));
    AttackFSMOverride.NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, 100677090);
    AttackFSMOverride.NativeMethodInfoPtr_get_OverrideClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, 100677091);
    AttackFSMOverride.NativeMethodInfoPtr_InThreshold_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, 100677092);
    AttackFSMOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr, 100677093);
  }

  public unsafe Vector2 DistanceThreshold
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackFSMOverride.NativeMethodInfoPtr_get_DistanceThreshold_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe MeshClip OverrideClip
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackFSMOverride.NativeMethodInfoPtr_get_OverrideClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  [CallerCount(0)]
  public unsafe bool InThreshold(float distance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &distance
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackFSMOverride.NativeMethodInfoPtr_InThreshold_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackFSMOverride()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackFSMOverride>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackFSMOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2 distanceThreshold
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackFSMOverride.NativeFieldInfoPtr_distanceThreshold));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackFSMOverride.NativeFieldInfoPtr_distanceThreshold)) = value;
    }
  }

  public unsafe MeshClip overrideClip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackFSMOverride.NativeFieldInfoPtr_overrideClip));
      return num == System.IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackFSMOverride.NativeFieldInfoPtr_overrideClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
