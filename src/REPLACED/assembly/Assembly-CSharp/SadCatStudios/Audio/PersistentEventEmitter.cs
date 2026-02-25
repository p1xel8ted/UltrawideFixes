// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.PersistentEventEmitter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Audio;

public class PersistentEventEmitter(IntPtr pointer) : LocalSingletonBehaviour<PersistentEventEmitter>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_musicEvent;
  private static readonly IntPtr NativeMethodInfoPtr_get_Event_Public_get_EventReference_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PersistentEventEmitter()
  {
    Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (PersistentEventEmitter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr);
    PersistentEventEmitter.NativeFieldInfoPtr_musicEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr, nameof (musicEvent));
    PersistentEventEmitter.NativeMethodInfoPtr_get_Event_Public_get_EventReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr, 100676439);
    PersistentEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr, 100676440);
  }

  public unsafe EventReference Event
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentEventEmitter.NativeMethodInfoPtr_get_Event_Public_get_EventReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(EventReference*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123386, XrefRangeEnd = 123389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PersistentEventEmitter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentEventEmitter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentEventEmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference musicEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentEventEmitter.NativeFieldInfoPtr_musicEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentEventEmitter.NativeFieldInfoPtr_musicEvent)) = value;
    }
  }
}
