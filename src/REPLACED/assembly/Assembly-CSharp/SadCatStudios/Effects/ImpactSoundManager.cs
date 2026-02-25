// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ImpactSoundManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Effects;

public class ImpactSoundManager(IntPtr pointer) : GlobalSingletonBehaviour<ImpactSoundManager>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Void_EventReference_Vector3_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_AttachAndPlaySound_Public_Void_EventReference_Transform_Rigidbody_byref_EventInstance_String_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_DetatchAndStopSound_Public_Void_EventInstance_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactSoundManager()
  {
    Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ImpactSoundManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr);
    ImpactSoundManager.NativeMethodInfoPtr_PlaySound_Public_Void_EventReference_Vector3_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr, 100675721);
    ImpactSoundManager.NativeMethodInfoPtr_AttachAndPlaySound_Public_Void_EventReference_Transform_Rigidbody_byref_EventInstance_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr, 100675722);
    ImpactSoundManager.NativeMethodInfoPtr_DetatchAndStopSound_Public_Void_EventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr, 100675723);
    ImpactSoundManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr, 100675724);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 119073, RefRangeEnd = 119079, XrefRangeStart = 119062, XrefRangeEnd = 119073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlaySound(EventReference soundEvent, Vector3 pos, string param = null, int value = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &soundEvent;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pos;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(param);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactSoundManager.NativeMethodInfoPtr_PlaySound_Public_Void_EventReference_Vector3_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119079, XrefRangeEnd = 119094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AttachAndPlaySound(
    EventReference soundEvent,
    Transform transform,
    Rigidbody rigidbody,
    out EventInstance attachedEventInstance,
    string param = null,
    int paramValue = 1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = (IntPtr) &soundEvent;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rigidbody);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) ref attachedEventInstance;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(param);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &paramValue;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactSoundManager.NativeMethodInfoPtr_AttachAndPlaySound_Public_Void_EventReference_Transform_Rigidbody_byref_EventInstance_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 119101, RefRangeEnd = 119105, XrefRangeStart = 119094, XrefRangeEnd = 119101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DetatchAndStopSound(EventInstance attachedEventInstance)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &attachedEventInstance
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactSoundManager.NativeMethodInfoPtr_DetatchAndStopSound_Public_Void_EventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119105, XrefRangeEnd = 119108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactSoundManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactSoundManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactSoundManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
