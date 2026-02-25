// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DisplayShadowMapCascadesLayoutParameter
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[Serializable]
public sealed class DisplayShadowMapCascadesLayoutParameter(IntPtr pointer) : 
  VolumeParameter<ShadowMapCascadesLayout>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShadowMapCascadesLayout_Boolean_0;

  static DisplayShadowMapCascadesLayoutParameter()
  {
    Il2CppClassPointerStore<DisplayShadowMapCascadesLayoutParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DisplayShadowMapCascadesLayoutParameter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayShadowMapCascadesLayoutParameter>.NativeClassPtr);
    DisplayShadowMapCascadesLayoutParameter.NativeMethodInfoPtr__ctor_Public_Void_ShadowMapCascadesLayout_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayShadowMapCascadesLayoutParameter>.NativeClassPtr, 100663649);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927083, XrefRangeEnd = 927086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DisplayShadowMapCascadesLayoutParameter(
    ShadowMapCascadesLayout layout,
    bool overrideState = false)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayShadowMapCascadesLayoutParameter>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &layout;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &overrideState;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DisplayShadowMapCascadesLayoutParameter.NativeMethodInfoPtr__ctor_Public_Void_ShadowMapCascadesLayout_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
