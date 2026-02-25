// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ChannelMixer
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
public sealed class ChannelMixer(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_redRed;
  private static readonly IntPtr NativeFieldInfoPtr_redGreen;
  private static readonly IntPtr NativeFieldInfoPtr_redBlue;
  private static readonly IntPtr NativeFieldInfoPtr_greenRed;
  private static readonly IntPtr NativeFieldInfoPtr_greenGreen;
  private static readonly IntPtr NativeFieldInfoPtr_greenBlue;
  private static readonly IntPtr NativeFieldInfoPtr_blueRed;
  private static readonly IntPtr NativeFieldInfoPtr_blueGreen;
  private static readonly IntPtr NativeFieldInfoPtr_blueBlue;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ChannelMixer()
  {
    Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ChannelMixer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr);
    ChannelMixer.NativeFieldInfoPtr_redRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (redRed));
    ChannelMixer.NativeFieldInfoPtr_redGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (redGreen));
    ChannelMixer.NativeFieldInfoPtr_redBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (redBlue));
    ChannelMixer.NativeFieldInfoPtr_greenRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (greenRed));
    ChannelMixer.NativeFieldInfoPtr_greenGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (greenGreen));
    ChannelMixer.NativeFieldInfoPtr_greenBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (greenBlue));
    ChannelMixer.NativeFieldInfoPtr_blueRed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (blueRed));
    ChannelMixer.NativeFieldInfoPtr_blueGreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (blueGreen));
    ChannelMixer.NativeFieldInfoPtr_blueBlue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, nameof (blueBlue));
    ChannelMixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr, 100663578);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926401, XrefRangeEnd = 926430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChannelMixer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChannelMixer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ChannelMixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ClampedFloatParameter redRed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redRed));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redRed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter redGreen
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redGreen));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redGreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter redBlue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redBlue));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_redBlue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter greenRed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenRed));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenRed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter greenGreen
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenGreen));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenGreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter greenBlue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenBlue));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_greenBlue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter blueRed
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueRed));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueRed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter blueGreen
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueGreen));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueGreen), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter blueBlue
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueBlue));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChannelMixer.NativeFieldInfoPtr_blueBlue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
