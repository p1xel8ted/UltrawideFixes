// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.DeathSoundManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Audio;

public class DeathSoundManager(IntPtr pointer) : LocalSingletonBehaviour<DeathSoundManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_deathSound;
  private static readonly IntPtr NativeFieldInfoPtr_deathSnapshot;
  private static readonly IntPtr NativeFieldInfoPtr_snapshotInstance;
  private static readonly IntPtr NativeFieldInfoPtr_deathInstance;
  private static readonly IntPtr NativeMethodInfoPtr_get_IsDeathSoundPlaying_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayDeathSound_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopDeathSnapshot_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DeathSoundManager()
  {
    Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (DeathSoundManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr);
    DeathSoundManager.NativeFieldInfoPtr_deathSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, nameof (deathSound));
    DeathSoundManager.NativeFieldInfoPtr_deathSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, nameof (deathSnapshot));
    DeathSoundManager.NativeFieldInfoPtr_snapshotInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, nameof (snapshotInstance));
    DeathSoundManager.NativeFieldInfoPtr_deathInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, nameof (deathInstance));
    DeathSoundManager.NativeMethodInfoPtr_get_IsDeathSoundPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, 100676424);
    DeathSoundManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, 100676425);
    DeathSoundManager.NativeMethodInfoPtr_PlayDeathSound_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, 100676426);
    DeathSoundManager.NativeMethodInfoPtr_StopDeathSnapshot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, 100676427);
    DeathSoundManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr, 100676428);
  }

  public unsafe bool IsDeathSoundPlaying
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123309, XrefRangeEnd = 123310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DeathSoundManager.NativeMethodInfoPtr_get_IsDeathSoundPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123310, XrefRangeEnd = 123314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeathSoundManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123321, RefRangeEnd = 123322, XrefRangeStart = 123314, XrefRangeEnd = 123321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayDeathSound()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeathSoundManager.NativeMethodInfoPtr_PlayDeathSound_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123323, RefRangeEnd = 123324, XrefRangeStart = 123322, XrefRangeEnd = 123323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopDeathSnapshot()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeathSoundManager.NativeMethodInfoPtr_StopDeathSnapshot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123324, XrefRangeEnd = 123327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DeathSoundManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathSoundManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeathSoundManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference deathSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathSound)) = value;
    }
  }

  public unsafe EventReference deathSnapshot
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathSnapshot));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathSnapshot)) = value;
    }
  }

  public unsafe EventInstance snapshotInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_snapshotInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_snapshotInstance)) = value;
    }
  }

  public unsafe EventInstance deathInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathSoundManager.NativeFieldInfoPtr_deathInstance)) = value;
    }
  }
}
