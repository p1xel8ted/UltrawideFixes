// Decompiled with JetBrains decompiler
// Type: ParticleEmissionEventEmitter
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
public class ParticleEmissionEventEmitter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_eventEmitter;
  private static readonly IntPtr NativeFieldInfoPtr_system;
  private static readonly IntPtr NativeFieldInfoPtr_played;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ParticleEmissionEventEmitter()
  {
    Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ParticleEmissionEventEmitter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr);
    ParticleEmissionEventEmitter.NativeFieldInfoPtr_eventEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, nameof (eventEmitter));
    ParticleEmissionEventEmitter.NativeFieldInfoPtr_system = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, nameof (system));
    ParticleEmissionEventEmitter.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, nameof (played));
    ParticleEmissionEventEmitter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, 100663419 /*0x0600007B*/);
    ParticleEmissionEventEmitter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, 100663420 /*0x0600007C*/);
    ParticleEmissionEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr, 100663421 /*0x0600007D*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16489, XrefRangeEnd = 16492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleEmissionEventEmitter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16492, XrefRangeEnd = 16494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleEmissionEventEmitter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticleEmissionEventEmitter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticleEmissionEventEmitter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticleEmissionEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StudioEventEmitter eventEmitter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_eventEmitter));
      return num == IntPtr.Zero ? (StudioEventEmitter) null : Il2CppObjectPool.Get<StudioEventEmitter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_eventEmitter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ParticleSystem system
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_system));
      return num == IntPtr.Zero ? (ParticleSystem) null : Il2CppObjectPool.Get<ParticleSystem>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_system), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool played
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_played));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticleEmissionEventEmitter.NativeFieldInfoPtr_played)) = value;
    }
  }
}
