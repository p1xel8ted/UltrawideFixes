// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ToneMapping
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
public sealed class ToneMapping(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_aces;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ToneMapping()
  {
    Il2CppClassPointerStore<ToneMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ToneMapping));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToneMapping>.NativeClassPtr);
    ToneMapping.NativeFieldInfoPtr_aces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToneMapping>.NativeClassPtr, nameof (aces));
    ToneMapping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToneMapping>.NativeClassPtr, 100663656);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927298, XrefRangeEnd = 927303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ToneMapping()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToneMapping>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ToneMapping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BoolParameter aces
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ToneMapping.NativeFieldInfoPtr_aces));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ToneMapping.NativeFieldInfoPtr_aces), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
