// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ShadowMappingParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShadowMappingParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_shadowDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_dlNearPlaneDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_dlCascadeCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_dlCascadeSplitRatio;
  private static readonly System.IntPtr NativeFieldInfoPtr_dlDisplayShadowCascades;
  private static readonly System.IntPtr NativeFieldInfoPtr_dlDisplayCascadesLayout;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_CameraType_Boolean_0;
  [FieldOffset(0)]
  public readonly bool on;
  [FieldOffset(4)]
  public readonly float shadowDistance;
  [FieldOffset(8)]
  public readonly float dlNearPlaneDistance;
  [FieldOffset(12)]
  public readonly int dlCascadeCount;
  [FieldOffset(16 /*0x10*/)]
  public readonly Vector3 dlCascadeSplitRatio;
  [FieldOffset(28)]
  public readonly bool dlDisplayShadowCascades;
  [FieldOffset(32 /*0x20*/)]
  public readonly ShadowMapCascadesLayout dlDisplayCascadesLayout;

  static ShadowMappingParams()
  {
    Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ShadowMappingParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr);
    ShadowMappingParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (on));
    ShadowMappingParams.NativeFieldInfoPtr_shadowDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (shadowDistance));
    ShadowMappingParams.NativeFieldInfoPtr_dlNearPlaneDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (dlNearPlaneDistance));
    ShadowMappingParams.NativeFieldInfoPtr_dlCascadeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (dlCascadeCount));
    ShadowMappingParams.NativeFieldInfoPtr_dlCascadeSplitRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (dlCascadeSplitRatio));
    ShadowMappingParams.NativeFieldInfoPtr_dlDisplayShadowCascades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (dlDisplayShadowCascades));
    ShadowMappingParams.NativeFieldInfoPtr_dlDisplayCascadesLayout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, nameof (dlDisplayCascadesLayout));
    ShadowMappingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_CameraType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, 100663608);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926828, RefRangeEnd = 926829, XrefRangeStart = 926824, XrefRangeEnd = 926828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowMappingParams(
    bool on,
    VolumeStack volumeStack,
    CameraType cameraType,
    bool isPrefabScene)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cameraType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &isPrefabScene;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowMappingParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_VolumeStack_CameraType_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowMappingParams>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
