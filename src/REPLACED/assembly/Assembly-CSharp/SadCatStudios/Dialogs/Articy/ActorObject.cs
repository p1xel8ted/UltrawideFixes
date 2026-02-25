// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ActorObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class ActorObject(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_articyActorReference;
  private static readonly IntPtr NativeFieldInfoPtr_availableClips;
  private static readonly IntPtr NativeFieldInfoPtr_availableIdles;
  private static readonly IntPtr NativeFieldInfoPtr_typewriterSoundReference;
  private static readonly IntPtr NativeMethodInfoPtr_get_ArticyActorReference_Public_get_ArticyRef_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_TypewriterSound_Public_get_EventReference_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetClip_Public_MeshClip_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetIdle_Public_MeshClipIdleContrainer_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ActorObject()
  {
    Il2CppClassPointerStore<ActorObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ActorObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActorObject>.NativeClassPtr);
    ActorObject.NativeFieldInfoPtr_articyActorReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, nameof (articyActorReference));
    ActorObject.NativeFieldInfoPtr_availableClips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, nameof (availableClips));
    ActorObject.NativeFieldInfoPtr_availableIdles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, nameof (availableIdles));
    ActorObject.NativeFieldInfoPtr_typewriterSoundReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, nameof (typewriterSoundReference));
    ActorObject.NativeMethodInfoPtr_get_ArticyActorReference_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, 100672675);
    ActorObject.NativeMethodInfoPtr_get_TypewriterSound_Public_get_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, 100672676);
    ActorObject.NativeMethodInfoPtr_GetClip_Public_MeshClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, 100672677);
    ActorObject.NativeMethodInfoPtr_GetIdle_Public_MeshClipIdleContrainer_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, 100672678);
    ActorObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActorObject>.NativeClassPtr, 100672679);
  }

  public unsafe ArticyRef ArticyActorReference
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorObject.NativeMethodInfoPtr_get_ArticyActorReference_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
  }

  public unsafe EventReference TypewriterSound
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorObject.NativeMethodInfoPtr_get_TypewriterSound_Public_get_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EventReference*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102739, XrefRangeEnd = 102743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClip GetClip(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorObject.NativeMethodInfoPtr_GetClip_Public_MeshClip_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102743, XrefRangeEnd = 102747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipIdleContrainer GetIdle(string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(key)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActorObject.NativeMethodInfoPtr_GetIdle_Public_MeshClipIdleContrainer_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClipIdleContrainer) null : Il2CppObjectPool.Get<MeshClipIdleContrainer>(num3);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActorObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActorObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActorObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef articyActorReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_articyActorReference));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_articyActorReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClipDictionary availableClips
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_availableClips));
      return num == IntPtr.Zero ? (ClipDictionary) null : Il2CppObjectPool.Get<ClipDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_availableClips), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IdleDictionary availableIdles
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_availableIdles));
      return num == IntPtr.Zero ? (IdleDictionary) null : Il2CppObjectPool.Get<IdleDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_availableIdles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference typewriterSoundReference
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_typewriterSoundReference));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ActorObject.NativeFieldInfoPtr_typewriterSoundReference)) = value;
    }
  }
}
