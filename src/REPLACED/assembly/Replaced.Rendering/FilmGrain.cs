// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FilmGrain
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
public sealed class FilmGrain(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultDarkAreaLimit;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultDarkAreaShoulder;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultBrightAreaLimit;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultBrightAreaShoulder;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultDarkAreaRangeStart;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultDarkAreaRangeEnd;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultBrightAreaRangeStart;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultBrightAreaRangeEnd;
  private static readonly IntPtr NativeFieldInfoPtr_texGrain;
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_darkAreaLimit;
  private static readonly IntPtr NativeFieldInfoPtr_darkAreaShoulder;
  private static readonly IntPtr NativeFieldInfoPtr_brightAreaLimit;
  private static readonly IntPtr NativeFieldInfoPtr_brightAreaShoulder;
  private static readonly IntPtr NativeMethodInfoPtr_CalcDarkAreaRangeStart_Public_Static_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalcDarkAreaRangeEnd_Public_Static_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalcBrightAreaRangeStart_Public_Static_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_CalcBrightAreaRangeEnd_Public_Static_Single_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FilmGrain()
  {
    Il2CppClassPointerStore<FilmGrain>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FilmGrain));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr);
    FilmGrain.NativeFieldInfoPtr_kDefaultIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultIntensity));
    FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultDarkAreaLimit));
    FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultDarkAreaShoulder));
    FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultBrightAreaLimit));
    FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultBrightAreaShoulder));
    FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultDarkAreaRangeStart));
    FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultDarkAreaRangeEnd));
    FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultBrightAreaRangeStart));
    FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (kDefaultBrightAreaRangeEnd));
    FilmGrain.NativeFieldInfoPtr_texGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (texGrain));
    FilmGrain.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (intensity));
    FilmGrain.NativeFieldInfoPtr_darkAreaLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (darkAreaLimit));
    FilmGrain.NativeFieldInfoPtr_darkAreaShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (darkAreaShoulder));
    FilmGrain.NativeFieldInfoPtr_brightAreaLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (brightAreaLimit));
    FilmGrain.NativeFieldInfoPtr_brightAreaShoulder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, nameof (brightAreaShoulder));
    FilmGrain.NativeMethodInfoPtr_CalcDarkAreaRangeStart_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100663588);
    FilmGrain.NativeMethodInfoPtr_CalcDarkAreaRangeEnd_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100663589);
    FilmGrain.NativeMethodInfoPtr_CalcBrightAreaRangeStart_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100663590);
    FilmGrain.NativeMethodInfoPtr_CalcBrightAreaRangeEnd_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100663591);
    FilmGrain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr, 100663592);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926621, RefRangeEnd = 926622, XrefRangeStart = 926621, XrefRangeEnd = 926621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcDarkAreaRangeStart(float limit, float shoulder)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &limit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shoulder;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_CalcDarkAreaRangeStart_Public_Static_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcDarkAreaRangeEnd(float limit, float shoulder)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &limit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shoulder;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_CalcDarkAreaRangeEnd_Public_Static_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcBrightAreaRangeStart(float limit, float shoulder)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &limit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shoulder;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_CalcBrightAreaRangeStart_Public_Static_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926622, RefRangeEnd = 926623, XrefRangeStart = 926622, XrefRangeEnd = 926622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float CalcBrightAreaRangeEnd(float limit, float shoulder)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &limit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shoulder;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr_CalcBrightAreaRangeEnd_Public_Static_Single_Single_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926623, XrefRangeEnd = 926644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FilmGrain()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilmGrain>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FilmGrain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kDefaultIntensity
  {
    get
    {
      float defaultIntensity;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultIntensity, (void*) &defaultIntensity);
      return defaultIntensity;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultIntensity, (void*) &value);
    }
  }

  public static unsafe float kDefaultDarkAreaLimit
  {
    get
    {
      float defaultDarkAreaLimit;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaLimit, (void*) &defaultDarkAreaLimit);
      return defaultDarkAreaLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaLimit, (void*) &value);
    }
  }

  public static unsafe float kDefaultDarkAreaShoulder
  {
    get
    {
      float darkAreaShoulder;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaShoulder, (void*) &darkAreaShoulder);
      return darkAreaShoulder;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaShoulder, (void*) &value);
    }
  }

  public static unsafe float kDefaultBrightAreaLimit
  {
    get
    {
      float defaultBrightAreaLimit;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaLimit, (void*) &defaultBrightAreaLimit);
      return defaultBrightAreaLimit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaLimit, (void*) &value);
    }
  }

  public static unsafe float kDefaultBrightAreaShoulder
  {
    get
    {
      float brightAreaShoulder;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaShoulder, (void*) &brightAreaShoulder);
      return brightAreaShoulder;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaShoulder, (void*) &value);
    }
  }

  public static unsafe float kDefaultDarkAreaRangeStart
  {
    get
    {
      float darkAreaRangeStart;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeStart, (void*) &darkAreaRangeStart);
      return darkAreaRangeStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeStart, (void*) &value);
    }
  }

  public static unsafe float kDefaultDarkAreaRangeEnd
  {
    get
    {
      float darkAreaRangeEnd;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeEnd, (void*) &darkAreaRangeEnd);
      return darkAreaRangeEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultDarkAreaRangeEnd, (void*) &value);
    }
  }

  public static unsafe float kDefaultBrightAreaRangeStart
  {
    get
    {
      float brightAreaRangeStart;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeStart, (void*) &brightAreaRangeStart);
      return brightAreaRangeStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeStart, (void*) &value);
    }
  }

  public static unsafe float kDefaultBrightAreaRangeEnd
  {
    get
    {
      float brightAreaRangeEnd;
      IL2CPP.il2cpp_field_static_get_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeEnd, (void*) &brightAreaRangeEnd);
      return brightAreaRangeEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FilmGrain.NativeFieldInfoPtr_kDefaultBrightAreaRangeEnd, (void*) &value);
    }
  }

  public unsafe TextureParameter texGrain
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_texGrain));
      return num == IntPtr.Zero ? (TextureParameter) null : Il2CppObjectPool.Get<TextureParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_texGrain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter intensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_intensity));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter darkAreaLimit
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_darkAreaLimit));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_darkAreaLimit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter darkAreaShoulder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_darkAreaShoulder));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_darkAreaShoulder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter brightAreaLimit
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_brightAreaLimit));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_brightAreaLimit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter brightAreaShoulder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_brightAreaShoulder));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrain.NativeFieldInfoPtr_brightAreaShoulder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
