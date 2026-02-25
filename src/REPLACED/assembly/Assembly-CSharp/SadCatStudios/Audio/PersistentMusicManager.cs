// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.PersistentMusicManager
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

public class PersistentMusicManager(IntPtr pointer) : 
  GlobalSingletonBehaviour<PersistentMusicManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_currentEvent;
  private static readonly IntPtr NativeFieldInfoPtr_currentInstance;
  private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessSceneChange_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PersistentMusicManager()
  {
    Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (PersistentMusicManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr);
    PersistentMusicManager.NativeFieldInfoPtr_currentEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr, nameof (currentEvent));
    PersistentMusicManager.NativeFieldInfoPtr_currentInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr, nameof (currentInstance));
    PersistentMusicManager.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr, 100676441);
    PersistentMusicManager.NativeMethodInfoPtr_ProcessSceneChange_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr, 100676442);
    PersistentMusicManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr, 100676443);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 123392, RefRangeEnd = 123394, XrefRangeStart = 123389, XrefRangeEnd = 123392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Stop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentMusicManager.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123403, RefRangeEnd = 123404, XrefRangeStart = 123394, XrefRangeEnd = 123403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessSceneChange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentMusicManager.NativeMethodInfoPtr_ProcessSceneChange_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123404, XrefRangeEnd = 123407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PersistentMusicManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentMusicManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentMusicManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference currentEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentMusicManager.NativeFieldInfoPtr_currentEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentMusicManager.NativeFieldInfoPtr_currentEvent)) = value;
    }
  }

  public unsafe EventInstance currentInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentMusicManager.NativeFieldInfoPtr_currentInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentMusicManager.NativeFieldInfoPtr_currentInstance)) = value;
    }
  }
}
