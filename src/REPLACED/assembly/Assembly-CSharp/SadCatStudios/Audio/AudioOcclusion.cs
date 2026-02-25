// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.AudioOcclusion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using GameSets;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Audio;

public class AudioOcclusion(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_spawnedSet;
  private static readonly IntPtr NativeFieldInfoPtr_occlusionLayer;
  private static readonly IntPtr NativeFieldInfoPtr_slTransform;
  private static readonly IntPtr NativeFieldInfoPtr_audioEvent;
  private static readonly IntPtr NativeFieldInfoPtr_OcclusionParameter;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpawnedSet_Public_get_StringSet_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_SpawnedSet_Public_set_Void_StringSet_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Occluded_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_NotOccluded_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AudioOcclusion()
  {
    Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (AudioOcclusion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr);
    AudioOcclusion.NativeFieldInfoPtr_spawnedSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, nameof (spawnedSet));
    AudioOcclusion.NativeFieldInfoPtr_occlusionLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, nameof (occlusionLayer));
    AudioOcclusion.NativeFieldInfoPtr_slTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, nameof (slTransform));
    AudioOcclusion.NativeFieldInfoPtr_audioEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, nameof (audioEvent));
    AudioOcclusion.NativeFieldInfoPtr_OcclusionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, nameof (OcclusionParameter));
    AudioOcclusion.NativeMethodInfoPtr_get_SpawnedSet_Public_get_StringSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676417);
    AudioOcclusion.NativeMethodInfoPtr_set_SpawnedSet_Public_set_Void_StringSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676418);
    AudioOcclusion.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676419);
    AudioOcclusion.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676420);
    AudioOcclusion.NativeMethodInfoPtr_Occluded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676421);
    AudioOcclusion.NativeMethodInfoPtr_NotOccluded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676422);
    AudioOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr, 100676423);
  }

  public unsafe StringSet SpawnedSet
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_get_SpawnedSet_Public_get_StringSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (StringSet) null : Il2CppObjectPool.Get<StringSet>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_set_SpawnedSet_Public_set_Void_StringSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123284, XrefRangeEnd = 123290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123290, XrefRangeEnd = 123303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123303, XrefRangeEnd = 123304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Occluded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_Occluded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123304, XrefRangeEnd = 123305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NotOccluded()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr_NotOccluded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123305, XrefRangeEnd = 123309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioOcclusion()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioOcclusion>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioOcclusion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StringSet spawnedSet
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_spawnedSet));
      return num == IntPtr.Zero ? (StringSet) null : Il2CppObjectPool.Get<StringSet>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_spawnedSet), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask occlusionLayer
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_occlusionLayer));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_occlusionLayer)) = value;
    }
  }

  public unsafe Transform slTransform
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_slTransform));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_slTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventInstance audioEvent
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_audioEvent));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_audioEvent)) = value;
    }
  }

  public unsafe string OcclusionParameter
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_OcclusionParameter)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioOcclusion.NativeFieldInfoPtr_OcclusionParameter), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
