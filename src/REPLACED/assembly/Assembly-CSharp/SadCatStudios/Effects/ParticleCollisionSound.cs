// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ParticleCollisionSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Effects;

public class ParticleCollisionSound(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_collisionSoundEvent;
  private static readonly IntPtr NativeFieldInfoPtr_particle;
  private static readonly IntPtr NativeFieldInfoPtr_collisionEvents;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ParticleCollisionSound()
  {
    Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ParticleCollisionSound));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr);
    ParticleCollisionSound.NativeFieldInfoPtr_collisionSoundEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, nameof (collisionSoundEvent));
    ParticleCollisionSound.NativeFieldInfoPtr_particle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, nameof (particle));
    ParticleCollisionSound.NativeFieldInfoPtr_collisionEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, nameof (collisionEvents));
    ParticleCollisionSound.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, 100675773);
    ParticleCollisionSound.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, 100675774);
    ParticleCollisionSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr, 100675775);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119402, XrefRangeEnd = 119411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleCollisionSound.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119411, XrefRangeEnd = 119420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnParticleCollision(GameObject other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleCollisionSound.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticleCollisionSound()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionSound>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleCollisionSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference collisionSoundEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_collisionSoundEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_collisionSoundEvent)) = value;
    }
  }

  public unsafe ParticleSystem particle
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_particle));
      return num == IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_particle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ParticleCollisionEvent> collisionEvents
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_collisionEvents));
      return num == IntPtr.Zero ? (List<ParticleCollisionEvent>) null : Il2CppObjectPool.Get<List<ParticleCollisionEvent>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionSound.NativeFieldInfoPtr_collisionEvents), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
