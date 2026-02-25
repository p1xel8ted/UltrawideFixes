// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CelestialBody
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
public sealed class CelestialBody(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_texBaseColor;
  private static readonly IntPtr NativeFieldInfoPtr_tint;
  private static readonly IntPtr NativeFieldInfoPtr_intensity;
  private static readonly IntPtr NativeFieldInfoPtr_sizeWs;
  private static readonly IntPtr NativeFieldInfoPtr_horizontalOffsetWs;
  private static readonly IntPtr NativeFieldInfoPtr_verticalOffsetWs;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CelestialBody()
  {
    Il2CppClassPointerStore<CelestialBody>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CelestialBody));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr);
    CelestialBody.NativeFieldInfoPtr_texBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (texBaseColor));
    CelestialBody.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (tint));
    CelestialBody.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (intensity));
    CelestialBody.NativeFieldInfoPtr_sizeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (sizeWs));
    CelestialBody.NativeFieldInfoPtr_horizontalOffsetWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (horizontalOffsetWs));
    CelestialBody.NativeFieldInfoPtr_verticalOffsetWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, nameof (verticalOffsetWs));
    CelestialBody.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr, 100663577);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926378, XrefRangeEnd = 926401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CelestialBody()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CelestialBody>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CelestialBody.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TextureParameter texBaseColor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_texBaseColor));
      return num == IntPtr.Zero ? (TextureParameter) null : Il2CppObjectPool.Get<TextureParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_texBaseColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ColorParameter tint
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_tint));
      return num == IntPtr.Zero ? (ColorParameter) null : Il2CppObjectPool.Get<ColorParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_tint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter intensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_intensity));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter sizeWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_sizeWs));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_sizeWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter horizontalOffsetWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_horizontalOffsetWs));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_horizontalOffsetWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatParameter verticalOffsetWs
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_verticalOffsetWs));
      return num == IntPtr.Zero ? (FloatParameter) null : Il2CppObjectPool.Get<FloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBody.NativeFieldInfoPtr_verticalOffsetWs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
