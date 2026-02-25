// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GlobalIllumination
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
public sealed class GlobalIllumination(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_doGlobalIllumination;
  private static readonly IntPtr NativeFieldInfoPtr_radianceSourceLimit1;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoSelfShadowingBias;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoRadiusPixels;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoMaxOccluderDistanceWs;
  private static readonly IntPtr NativeFieldInfoPtr_ssdoAVContrast;
  private static readonly IntPtr NativeFieldInfoPtr_ssrFadeDistanceWs;
  private static readonly IntPtr NativeFieldInfoPtr_screenEdgeFade;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcLeftColor;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcRightColor;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcBottomColor;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcTopColor;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcFrontColor;
  private static readonly IntPtr NativeFieldInfoPtr_ssrAcBackColor;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GlobalIllumination()
  {
    Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GlobalIllumination));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr);
    GlobalIllumination.NativeFieldInfoPtr_doGlobalIllumination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (doGlobalIllumination));
    GlobalIllumination.NativeFieldInfoPtr_radianceSourceLimit1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (radianceSourceLimit1));
    GlobalIllumination.NativeFieldInfoPtr_ssdoSelfShadowingBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssdoSelfShadowingBias));
    GlobalIllumination.NativeFieldInfoPtr_ssdoRadiusPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssdoRadiusPixels));
    GlobalIllumination.NativeFieldInfoPtr_ssdoMaxOccluderDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssdoMaxOccluderDistanceWs));
    GlobalIllumination.NativeFieldInfoPtr_ssdoAVContrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssdoAVContrast));
    GlobalIllumination.NativeFieldInfoPtr_ssrFadeDistanceWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrFadeDistanceWs));
    GlobalIllumination.NativeFieldInfoPtr_screenEdgeFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (screenEdgeFade));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcLeftColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcLeftColor));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcRightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcRightColor));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcBottomColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcBottomColor));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcTopColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcTopColor));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcFrontColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcFrontColor));
    GlobalIllumination.NativeFieldInfoPtr_ssrAcBackColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, nameof (ssrAcBackColor));
    GlobalIllumination.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr, 100663611);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926844, XrefRangeEnd = 926891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalIllumination()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalIllumination>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalIllumination.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BoolParameter doGlobalIllumination
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_doGlobalIllumination));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_doGlobalIllumination), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter radianceSourceLimit1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_radianceSourceLimit1));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_radianceSourceLimit1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter ssdoSelfShadowingBias
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoSelfShadowingBias));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoSelfShadowingBias), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter ssdoRadiusPixels
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoRadiusPixels));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoRadiusPixels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter ssdoMaxOccluderDistanceWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoMaxOccluderDistanceWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoMaxOccluderDistanceWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter ssdoAVContrast
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoAVContrast));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssdoAVContrast), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter ssrFadeDistanceWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrFadeDistanceWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrFadeDistanceWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter screenEdgeFade
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_screenEdgeFade));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_screenEdgeFade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcLeftColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcLeftColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcLeftColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcRightColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcRightColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcRightColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcBottomColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcBottomColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcBottomColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcTopColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcTopColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcTopColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcFrontColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcFrontColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcFrontColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter ssrAcBackColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcBackColor));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalIllumination.NativeFieldInfoPtr_ssrAcBackColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
