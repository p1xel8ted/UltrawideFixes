// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ProjectileShooter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Effects;

public class ProjectileShooter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_muzzleReference;
  private static readonly IntPtr NativeFieldInfoPtr_projectileReference;
  private static readonly IntPtr NativeFieldInfoPtr_shotSoundEvent;
  private static readonly IntPtr NativeMethodInfoPtr_Shoot_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LookAt_Public_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ProjectileShooter()
  {
    Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ProjectileShooter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr);
    ProjectileShooter.NativeFieldInfoPtr_muzzleReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, nameof (muzzleReference));
    ProjectileShooter.NativeFieldInfoPtr_projectileReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, nameof (projectileReference));
    ProjectileShooter.NativeFieldInfoPtr_shotSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, nameof (shotSoundEvent));
    ProjectileShooter.NativeMethodInfoPtr_Shoot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, 100675732);
    ProjectileShooter.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, 100675733);
    ProjectileShooter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr, 100675734);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 119158, RefRangeEnd = 119160, XrefRangeStart = 119136, XrefRangeEnd = 119158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Shoot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProjectileShooter.NativeMethodInfoPtr_Shoot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119160, XrefRangeEnd = 119168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LookAt(Transform targetTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetTransform)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProjectileShooter.NativeMethodInfoPtr_LookAt_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProjectileShooter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileShooter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProjectileShooter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AssetReference muzzleReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_muzzleReference));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_muzzleReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AssetReference projectileReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_projectileReference));
      return num == IntPtr.Zero ? (AssetReference) null : Il2CppObjectPool.Get<AssetReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_projectileReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference shotSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_shotSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileShooter.NativeFieldInfoPtr_shotSoundEvent)) = value;
    }
  }
}
