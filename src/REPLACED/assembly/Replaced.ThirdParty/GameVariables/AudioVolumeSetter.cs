// Decompiled with JetBrains decompiler
// Type: GameVariables.AudioVolumeSetter
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Audio;

#nullable disable
namespace GameVariables;

public class AudioVolumeSetter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Mixer;
  private static readonly IntPtr NativeFieldInfoPtr_ParameterName;
  private static readonly IntPtr NativeFieldInfoPtr_Variable;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AudioVolumeSetter()
  {
    Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (AudioVolumeSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr);
    AudioVolumeSetter.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr, nameof (Mixer));
    AudioVolumeSetter.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr, nameof (ParameterName));
    AudioVolumeSetter.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr, nameof (Variable));
    AudioVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr, 100663355 /*0x0600003B*/);
    AudioVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr, 100663356 /*0x0600003C*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360554, XrefRangeEnd = 360558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioVolumeSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360558, XrefRangeEnd = 360561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioVolumeSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioVolumeSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioVolumeSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AudioMixer Mixer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_Mixer));
      return num == IntPtr.Zero ? (AudioMixer) null : Il2CppObjectPool.Get<AudioMixer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_Mixer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string ParameterName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_ParameterName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe FloatVariable Variable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_Variable));
      return num == IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioVolumeSetter.NativeFieldInfoPtr_Variable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
