// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowsMidtonesHighlights
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class ShadowsMidtonesHighlights(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultShadowsStart;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultShadowsEnd;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultHighlightsStart;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultHighlightsEnd;
  private static readonly IntPtr NativeFieldInfoPtr_kDefaultColorValue;
  private static readonly IntPtr NativeFieldInfoPtr_shadows;
  private static readonly IntPtr NativeFieldInfoPtr_midtones;
  private static readonly IntPtr NativeFieldInfoPtr_highlights;
  private static readonly IntPtr NativeFieldInfoPtr_shadowsStart;
  private static readonly IntPtr NativeFieldInfoPtr_shadowsEnd;
  private static readonly IntPtr NativeFieldInfoPtr_highlightsStart;
  private static readonly IntPtr NativeFieldInfoPtr_highlightsEnd;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ShadowsMidtonesHighlights()
  {
    Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowsMidtonesHighlights));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr);
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (kDefaultShadowsStart));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (kDefaultShadowsEnd));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (kDefaultHighlightsStart));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (kDefaultHighlightsEnd));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultColorValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (kDefaultColorValue));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (shadows));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (midtones));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (highlights));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (shadowsStart));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (shadowsEnd));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (highlightsStart));
    ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, nameof (highlightsEnd));
    ShadowsMidtonesHighlights.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr, 100663653);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927122, XrefRangeEnd = 927152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowsMidtonesHighlights()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowsMidtonesHighlights>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowsMidtonesHighlights.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kDefaultShadowsStart
  {
    get
    {
      float defaultShadowsStart;
      IL2CPP.il2cpp_field_static_get_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsStart, (void*) &defaultShadowsStart);
      return defaultShadowsStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsStart, (void*) &value);
    }
  }

  public static unsafe float kDefaultShadowsEnd
  {
    get
    {
      float defaultShadowsEnd;
      IL2CPP.il2cpp_field_static_get_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsEnd, (void*) &defaultShadowsEnd);
      return defaultShadowsEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultShadowsEnd, (void*) &value);
    }
  }

  public static unsafe float kDefaultHighlightsStart
  {
    get
    {
      float defaultHighlightsStart;
      IL2CPP.il2cpp_field_static_get_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsStart, (void*) &defaultHighlightsStart);
      return defaultHighlightsStart;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsStart, (void*) &value);
    }
  }

  public static unsafe float kDefaultHighlightsEnd
  {
    get
    {
      float defaultHighlightsEnd;
      IL2CPP.il2cpp_field_static_get_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsEnd, (void*) &defaultHighlightsEnd);
      return defaultHighlightsEnd;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultHighlightsEnd, (void*) &value);
    }
  }

  public static unsafe Vector4 kDefaultColorValue
  {
    get
    {
      Vector4 defaultColorValue;
      IL2CPP.il2cpp_field_static_get_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultColorValue, (void*) &defaultColorValue);
      return defaultColorValue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowsMidtonesHighlights.NativeFieldInfoPtr_kDefaultColorValue, (void*) &value);
    }
  }

  public unsafe Vector4Parameter shadows
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadows), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter midtones
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_midtones), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector4Parameter highlights
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights));
      return num == IntPtr.Zero ? (Vector4Parameter) null : Il2CppObjectPool.Get<Vector4Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlights), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter shadowsStart
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter shadowsEnd
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_shadowsEnd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter highlightsStart
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsStart), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter highlightsEnd
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShadowsMidtonesHighlights.NativeFieldInfoPtr_highlightsEnd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
