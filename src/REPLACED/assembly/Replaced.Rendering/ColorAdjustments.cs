// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ColorAdjustments
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
public sealed class ColorAdjustments(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_postExposure;
  private static readonly IntPtr NativeFieldInfoPtr_contrast;
  private static readonly IntPtr NativeFieldInfoPtr_hueShift;
  private static readonly IntPtr NativeFieldInfoPtr_saturation;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ColorAdjustments()
  {
    Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ColorAdjustments));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr);
    ColorAdjustments.NativeFieldInfoPtr_postExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, nameof (postExposure));
    ColorAdjustments.NativeFieldInfoPtr_contrast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, nameof (contrast));
    ColorAdjustments.NativeFieldInfoPtr_hueShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, nameof (hueShift));
    ColorAdjustments.NativeFieldInfoPtr_saturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, nameof (saturation));
    ColorAdjustments.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr, 100663581);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926470, XrefRangeEnd = 926485, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorAdjustments()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorAdjustments>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorAdjustments.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatParameter postExposure
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_postExposure));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_postExposure), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter contrast
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_contrast));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_contrast), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter hueShift
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_hueShift));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_hueShift), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter saturation
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_saturation));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ColorAdjustments.NativeFieldInfoPtr_saturation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
