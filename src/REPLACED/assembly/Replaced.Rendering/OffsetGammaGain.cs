// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.OffsetGammaGain
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class OffsetGammaGain(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_offset;
  private static readonly IntPtr NativeFieldInfoPtr_gamma;
  private static readonly IntPtr NativeFieldInfoPtr_gain;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OffsetGammaGain()
  {
    Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (OffsetGammaGain));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr);
    OffsetGammaGain.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr, nameof (offset));
    OffsetGammaGain.NativeFieldInfoPtr_gamma = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr, nameof (gamma));
    OffsetGammaGain.NativeFieldInfoPtr_gain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr, nameof (gain));
    OffsetGammaGain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr, 100663613);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926896, XrefRangeEnd = 926909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OffsetGammaGain()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetGammaGain>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OffsetGammaGain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector4Parameter offset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_offset));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_offset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter gamma
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_gamma));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_gamma), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter gain
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_gain));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OffsetGammaGain.NativeFieldInfoPtr_gain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
