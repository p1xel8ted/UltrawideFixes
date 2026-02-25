// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIPostProcessing
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
public sealed class UIPostProcessing(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_bloomThreshold;
  private static readonly IntPtr NativeFieldInfoPtr_bloomScatter;
  private static readonly IntPtr NativeFieldInfoPtr_bloomIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_fullscreenVfxMaterial;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIPostProcessing()
  {
    Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIPostProcessing));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr);
    UIPostProcessing.NativeFieldInfoPtr_bloomThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr, nameof (bloomThreshold));
    UIPostProcessing.NativeFieldInfoPtr_bloomScatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr, nameof (bloomScatter));
    UIPostProcessing.NativeFieldInfoPtr_bloomIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr, nameof (bloomIntensity));
    UIPostProcessing.NativeFieldInfoPtr_fullscreenVfxMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr, nameof (fullscreenVfxMaterial));
    UIPostProcessing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr, 100663658);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927306, XrefRangeEnd = 927324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPostProcessing()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPostProcessing>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPostProcessing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MinFloatParameter bloomThreshold
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomThreshold));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomThreshold), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedFloatParameter bloomScatter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomScatter));
      return num == IntPtr.Zero ? (ClampedFloatParameter) null : Il2CppObjectPool.Get<ClampedFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomScatter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MinFloatParameter bloomIntensity
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomIntensity));
      return num == IntPtr.Zero ? (MinFloatParameter) null : Il2CppObjectPool.Get<MinFloatParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_bloomIntensity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MaterialParameter fullscreenVfxMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_fullscreenVfxMaterial));
      return num == IntPtr.Zero ? (MaterialParameter) null : Il2CppObjectPool.Get<MaterialParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPostProcessing.NativeFieldInfoPtr_fullscreenVfxMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
