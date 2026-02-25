// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PostProcessingDevdbg
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
public sealed class PostProcessingDevdbg(IntPtr pointer) : VolumeComponent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_colorGradingOff;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PostProcessingDevdbg()
  {
    Il2CppClassPointerStore<PostProcessingDevdbg>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PostProcessingDevdbg));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingDevdbg>.NativeClassPtr);
    PostProcessingDevdbg.NativeFieldInfoPtr_colorGradingOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingDevdbg>.NativeClassPtr, nameof (colorGradingOff));
    PostProcessingDevdbg.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingDevdbg>.NativeClassPtr, 100663615);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926918, XrefRangeEnd = 926923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PostProcessingDevdbg()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingDevdbg>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PostProcessingDevdbg.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BoolParameter colorGradingOff
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingDevdbg.NativeFieldInfoPtr_colorGradingOff));
      return num == IntPtr.Zero ? (BoolParameter) null : Il2CppObjectPool.Get<BoolParameter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PostProcessingDevdbg.NativeFieldInfoPtr_colorGradingOff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
