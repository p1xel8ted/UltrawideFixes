// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.Pixelization
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
public class Pixelization(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_resolution;
  private static readonly IntPtr NativeFieldInfoPtr_posterizationLevels;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Pixelization()
  {
    Il2CppClassPointerStore<Pixelization>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (Pixelization));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Pixelization>.NativeClassPtr);
    Pixelization.NativeFieldInfoPtr_resolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pixelization>.NativeClassPtr, nameof (resolution));
    Pixelization.NativeFieldInfoPtr_posterizationLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Pixelization>.NativeClassPtr, nameof (posterizationLevels));
    Pixelization.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Pixelization>.NativeClassPtr, 100663614);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926909, XrefRangeEnd = 926918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Pixelization()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Pixelization>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Pixelization.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2Parameter resolution
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pixelization.NativeFieldInfoPtr_resolution));
      return num == IntPtr.Zero ? (Vector2Parameter) null : Il2CppObjectPool.Get<Vector2Parameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Pixelization.NativeFieldInfoPtr_resolution), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClampedIntParameter posterizationLevels
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Pixelization.NativeFieldInfoPtr_posterizationLevels));
      return num == IntPtr.Zero ? (ClampedIntParameter) null : Il2CppObjectPool.Get<ClampedIntParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Pixelization.NativeFieldInfoPtr_posterizationLevels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
