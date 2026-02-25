// Decompiled with JetBrains decompiler
// Type: UnityEngine.ColorUsageAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class ColorUsageAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_showAlpha;
  private static readonly IntPtr NativeFieldInfoPtr_hdr;
  private static readonly IntPtr NativeFieldInfoPtr_minBrightness;
  private static readonly IntPtr NativeFieldInfoPtr_maxBrightness;
  private static readonly IntPtr NativeFieldInfoPtr_minExposureValue;
  private static readonly IntPtr NativeFieldInfoPtr_maxExposureValue;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0;

  static ColorUsageAttribute()
  {
    Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ColorUsageAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr);
    ColorUsageAttribute.NativeFieldInfoPtr_showAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (showAlpha));
    ColorUsageAttribute.NativeFieldInfoPtr_hdr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (hdr));
    ColorUsageAttribute.NativeFieldInfoPtr_minBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (minBrightness));
    ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (maxBrightness));
    ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (minExposureValue));
    ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, nameof (maxExposureValue));
    ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr, 100667748);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441888, XrefRangeEnd = 441889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ColorUsageAttribute(bool showAlpha, bool hdr)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorUsageAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &showAlpha;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &hdr;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ColorUsageAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool showAlpha
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_showAlpha)) = value;
    }
  }

  public unsafe bool hdr
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_hdr)) = value;
    }
  }

  public unsafe float minBrightness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minBrightness)) = value;
    }
  }

  public unsafe float maxBrightness
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxBrightness)) = value;
    }
  }

  public unsafe float minExposureValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_minExposureValue)) = value;
    }
  }

  public unsafe float maxExposureValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ColorUsageAttribute.NativeFieldInfoPtr_maxExposureValue)) = value;
    }
  }
}
