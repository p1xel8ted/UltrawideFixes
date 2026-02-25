// Decompiled with JetBrains decompiler
// Type: ParticleCollisionEventEmitter
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

#nullable disable
public class ParticleCollisionEventEmitter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_eventEmitter;
  private static readonly IntPtr NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ParticleCollisionEventEmitter()
  {
    Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ParticleCollisionEventEmitter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr);
    ParticleCollisionEventEmitter.NativeFieldInfoPtr_eventEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr, nameof (eventEmitter));
    ParticleCollisionEventEmitter.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr, 100663417 /*0x06000079*/);
    ParticleCollisionEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr, 100663418 /*0x0600007A*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16487, XrefRangeEnd = 16489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnParticleCollision(GameObject _other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleCollisionEventEmitter.NativeMethodInfoPtr_OnParticleCollision_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticleCollisionEventEmitter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleCollisionEventEmitter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleCollisionEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StudioEventEmitter eventEmitter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionEventEmitter.NativeFieldInfoPtr_eventEmitter));
      return num == IntPtr.Zero ? (StudioEventEmitter) null : Il2CppObjectPool.Get<StudioEventEmitter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleCollisionEventEmitter.NativeFieldInfoPtr_eventEmitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
