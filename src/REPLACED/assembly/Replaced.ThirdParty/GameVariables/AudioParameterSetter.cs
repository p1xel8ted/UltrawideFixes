// Decompiled with JetBrains decompiler
// Type: GameVariables.AudioParameterSetter
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

public class AudioParameterSetter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Mixer;
  private static readonly IntPtr NativeFieldInfoPtr_ParameterName;
  private static readonly IntPtr NativeFieldInfoPtr_Variable;
  private static readonly IntPtr NativeFieldInfoPtr_Min;
  private static readonly IntPtr NativeFieldInfoPtr_Max;
  private static readonly IntPtr NativeFieldInfoPtr_Curve;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AudioParameterSetter()
  {
    Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (AudioParameterSetter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr);
    AudioParameterSetter.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (Mixer));
    AudioParameterSetter.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (ParameterName));
    AudioParameterSetter.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (Variable));
    AudioParameterSetter.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (Min));
    AudioParameterSetter.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (Max));
    AudioParameterSetter.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, nameof (Curve));
    AudioParameterSetter.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, 100663353 /*0x06000039*/);
    AudioParameterSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr, 100663354 /*0x0600003A*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360544, XrefRangeEnd = 360551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioParameterSetter.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360551, XrefRangeEnd = 360554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioParameterSetter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioParameterSetter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioParameterSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AudioMixer Mixer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Mixer));
      return num == IntPtr.Zero ? (AudioMixer) null : Il2CppObjectPool.Get<AudioMixer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Mixer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string ParameterName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_ParameterName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_ParameterName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe FloatVariable Variable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Variable));
      return num == IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Variable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference Min
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Min));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Min), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference Max
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Max));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Max), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve Curve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Curve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioParameterSetter.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
