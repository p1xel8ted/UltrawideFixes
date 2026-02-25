// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.AntiAliasing
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
public sealed class AntiAliasing(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_taa;
  private static readonly IntPtr NativeFieldInfoPtr_sigmaMultiplier;
  private static readonly IntPtr NativeFieldInfoPtr_antiflicker;
  private static readonly IntPtr NativeFieldInfoPtr_subpixelOffset;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AntiAliasing()
  {
    Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (AntiAliasing));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr);
    AntiAliasing.NativeFieldInfoPtr_taa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr, nameof (taa));
    AntiAliasing.NativeFieldInfoPtr_sigmaMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr, nameof (sigmaMultiplier));
    AntiAliasing.NativeFieldInfoPtr_antiflicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr, nameof (antiflicker));
    AntiAliasing.NativeFieldInfoPtr_subpixelOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr, nameof (subpixelOffset));
    AntiAliasing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr, 100663575);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926351, XrefRangeEnd = 926366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AntiAliasing()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AntiAliasing>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AntiAliasing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BoolParameter taa
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_taa));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_taa), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter sigmaMultiplier
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_sigmaMultiplier));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_sigmaMultiplier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter antiflicker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_antiflicker));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_antiflicker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter subpixelOffset
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_subpixelOffset));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AntiAliasing.NativeFieldInfoPtr_subpixelOffset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
