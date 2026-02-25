// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.Volumetric
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
public class Volumetric(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_distGlobalScale;
  private static readonly IntPtr NativeFieldInfoPtr_farDistance;
  private static readonly IntPtr NativeFieldInfoPtr_horizonHeightWs;
  private static readonly IntPtr NativeFieldInfoPtr_startDistance0Ws;
  private static readonly IntPtr NativeFieldInfoPtr_height0Ws;
  private static readonly IntPtr NativeFieldInfoPtr_albedo0;
  private static readonly IntPtr NativeFieldInfoPtr_extinction0;
  private static readonly IntPtr NativeFieldInfoPtr_anisotropy0;
  private static readonly IntPtr NativeFieldInfoPtr_startDistance1Ws;
  private static readonly IntPtr NativeFieldInfoPtr_height1Ws;
  private static readonly IntPtr NativeFieldInfoPtr_albedo1;
  private static readonly IntPtr NativeFieldInfoPtr_extinction1;
  private static readonly IntPtr NativeFieldInfoPtr_anisotropy1;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Volumetric()
  {
    Il2CppClassPointerStore<Volumetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (Volumetric));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Volumetric>.NativeClassPtr);
    Volumetric.NativeFieldInfoPtr_distGlobalScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (distGlobalScale));
    Volumetric.NativeFieldInfoPtr_farDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (farDistance));
    Volumetric.NativeFieldInfoPtr_horizonHeightWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (horizonHeightWs));
    Volumetric.NativeFieldInfoPtr_startDistance0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (startDistance0Ws));
    Volumetric.NativeFieldInfoPtr_height0Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (height0Ws));
    Volumetric.NativeFieldInfoPtr_albedo0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (albedo0));
    Volumetric.NativeFieldInfoPtr_extinction0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (extinction0));
    Volumetric.NativeFieldInfoPtr_anisotropy0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (anisotropy0));
    Volumetric.NativeFieldInfoPtr_startDistance1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (startDistance1Ws));
    Volumetric.NativeFieldInfoPtr_height1Ws = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (height1Ws));
    Volumetric.NativeFieldInfoPtr_albedo1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (albedo1));
    Volumetric.NativeFieldInfoPtr_extinction1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (extinction1));
    Volumetric.NativeFieldInfoPtr_anisotropy1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, nameof (anisotropy1));
    Volumetric.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Volumetric>.NativeClassPtr, 100663667);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927381, XrefRangeEnd = 927432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Volumetric()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Volumetric>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Volumetric.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MinFloatParameter distGlobalScale
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_distGlobalScale));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_distGlobalScale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter farDistance
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_farDistance));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_farDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter horizonHeightWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_horizonHeightWs));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_horizonHeightWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter startDistance0Ws
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_startDistance0Ws));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_startDistance0Ws), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter height0Ws
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_height0Ws));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_height0Ws), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter albedo0
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_albedo0));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_albedo0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter extinction0
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_extinction0));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_extinction0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter anisotropy0
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_anisotropy0));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_anisotropy0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter startDistance1Ws
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_startDistance1Ws));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_startDistance1Ws), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter height1Ws
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_height1Ws));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_height1Ws), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter albedo1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_albedo1));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_albedo1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter extinction1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_extinction1));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_extinction1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter anisotropy1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_anisotropy1));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Volumetric.NativeFieldInfoPtr_anisotropy1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
