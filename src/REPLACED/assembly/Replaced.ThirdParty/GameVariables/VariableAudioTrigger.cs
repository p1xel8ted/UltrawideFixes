// Decompiled with JetBrains decompiler
// Type: GameVariables.VariableAudioTrigger
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

#nullable disable
namespace GameVariables;

public class VariableAudioTrigger(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_AudioSource;
  private static readonly IntPtr NativeFieldInfoPtr_Variable;
  private static readonly IntPtr NativeFieldInfoPtr_LowThreshold;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VariableAudioTrigger()
  {
    Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (VariableAudioTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr);
    VariableAudioTrigger.NativeFieldInfoPtr_AudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr, nameof (AudioSource));
    VariableAudioTrigger.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr, nameof (Variable));
    VariableAudioTrigger.NativeFieldInfoPtr_LowThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr, nameof (LowThreshold));
    VariableAudioTrigger.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr, 100663391 /*0x0600005F*/);
    VariableAudioTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr, 100663392 /*0x06000060*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360979, XrefRangeEnd = 360982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VariableAudioTrigger.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VariableAudioTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariableAudioTrigger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VariableAudioTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AudioSource AudioSource
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_AudioSource));
      return num == IntPtr.Zero ? (AudioSource) null : Il2CppObjectPool.Get<AudioSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_AudioSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatVariable Variable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_Variable));
      return num == IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_Variable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference LowThreshold
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_LowThreshold));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariableAudioTrigger.NativeFieldInfoPtr_LowThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
